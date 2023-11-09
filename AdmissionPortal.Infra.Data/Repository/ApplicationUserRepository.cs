using AdmissionPortal.Infra.Data.Interface;
using AdmissionPortal.Infra.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AdmissionPortal.Infra.Data.Repository
{
    internal class ApplicationUserRepository : GenericRepository<TblSsaApplicationUser>, IApplicationUserRepository
    {
        private readonly SisContext _sisContext;
        public ApplicationUserRepository(SisContext sisContext) : base(sisContext)
        {
            _sisContext = sisContext;
        }
        public async Task<int> AddUser(TblSsaApplicationUser applicationUser)
        {
            var result = _sisContext.TblSsaApplicationUsers.Add(applicationUser);
            await _sisContext.SaveChangesAsync();
            return result.Entity.UserId;
        }

        public async Task<bool> ResetPassword(string emailId, string password)
        {
            var result = _sisContext.TblSsaApplicationUsers.First(x => x.EmailAddress == emailId);
            result.UserPassword = password;
            await _sisContext.SaveChangesAsync();
            return true;
        }
        public bool IsEmailAlreadyRegistered(string emailAddress) => _sisContext.TblSsaApplicationUsers.Any(x => x.EmailAddress == emailAddress);
        public bool IsMobileAlreadyRegistered(string mobile) => _sisContext.TblSsaApplicationUsers.Any(x => x.Mobile == mobile);
        public async Task<int> IsValidUserName(string username)
        {
            if (_sisContext.TblSsaApplicationUsers.Any(x => x.UserName == username))
            {
                int userid = _sisContext.TblSsaApplicationUsers.Where(x => x.UserName == username)
                                                                .Select(c => c.UserId)
                                                                .FirstOrDefault();
                return userid;
            }
            return 0;
        }
        public async Task<bool> IsValidActivationCode(string password) => _sisContext.TblSsaApplicationUsers.Any(x => x.UserPassword == password);
        public async Task<string> GetPassword(string username)
        {
            return await _sisContext.TblSsaApplicationUsers.Where(x => x.UserName == username)
                                                                .Select(c => c.UserPassword)
                                                                .FirstAsync();
        }
        public async Task<bool> IsRegistrationAvailable() => await _sisContext.TblAdmByTermAdmissionSchedules.AnyAsync(x => x.StartDateTime <= DateTime.Now && x.ExtenssionEndDateTime >= DateTime.Now);
        public TblMstAutoNotification GetRegistrationMessage()
        {
            return _sisContext.TblMstAutoNotifications.First(x => x.AutoNotificationRecId == 1);
        }

        public async Task<string> UpdateRegistrationDetails(TblSsaApplicationUser applicationUser)
        {
            var registrationDetails = await _sisContext.TblSsaApplicationUsers.FirstOrDefaultAsync(i => i.UserId == applicationUser.UserId);
            if (registrationDetails != null)
            {
                registrationDetails.Mobile = applicationUser.Mobile;
                registrationDetails.EmailAddress = applicationUser.EmailAddress;
                registrationDetails.UserName = applicationUser.EmailAddress;
                registrationDetails.LastUpdatedBy = applicationUser.LastUpdatedBy;
                registrationDetails.LastUpdatedDateTime = applicationUser.LastUpdatedDateTime;
                registrationDetails.TermsAcknowledged = applicationUser.TermsAcknowledged;
                var activationCode = registrationDetails.NationalId.GetLastFourCharacters() + registrationDetails.Mobile.GetLastFourCharacters();
                registrationDetails.UserPassword = activationCode.Base64Encode();
                await _sisContext.SaveChangesAsync();
                return activationCode;
            }
            return "";
        }

    }
}
