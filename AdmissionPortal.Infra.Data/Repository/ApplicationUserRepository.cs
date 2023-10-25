using AdmissionPortal.Infra.Data.Interface;
using AdmissionPortal.Infra.Data.Models;

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
        public bool IsEmailAlreadyRegistered(string emailAddress) => _sisContext.TblSsaApplicationUsers.Any(x => x.EmailAddress == emailAddress);            
        public bool IsMobileAlreadyRegistered(string mobile) => _sisContext.TblSsaApplicationUsers.Any(x => x.Mobile == mobile);
        public async Task<int> UpdateTermsandConditions(int userId, bool status)
        {
            var updateData = _sisContext.TblSsaApplicationUsers.Where(x => x.UserId== userId).FirstOrDefault();
            if (updateData!=null) {
                updateData.TermsAcknowledged = status;
                updateData.LastUpdatedDateTime = DateTime.UtcNow;
            }          
            return await _sisContext.SaveChangesAsync();
        }
        public async Task<int> UpdateGuidelinesAcknowledged(int userId, bool status)
        {
            var updateData = _sisContext.TblSsaApplicationUsers.Where(x => x.UserId == userId).FirstOrDefault();
            if (updateData != null)
            {
                updateData.GuidelinesAcknowledged = status;
                updateData.LastUpdatedDateTime = DateTime.UtcNow;
            }
            return await _sisContext.SaveChangesAsync();
        }
    }
}
