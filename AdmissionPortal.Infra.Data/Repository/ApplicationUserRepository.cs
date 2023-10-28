﻿using AdmissionPortal.Infra.Data.Interface;
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

        public bool IsEmailAlreadyRegistered(string emailAddress) => _sisContext.TblSsaApplicationUsers.Any(x => x.EmailAddress == emailAddress);
        public bool IsMobileAlreadyRegistered(string mobile) => _sisContext.TblSsaApplicationUsers.Any(x => x.Mobile == mobile);
        public async Task<bool> IsValidUserName(string username) => _sisContext.TblSsaApplicationUsers.Any(x => x.UserName == username);
        public async Task<string> GetPassword(string username)
        {
            string password = _sisContext.TblSsaApplicationUsers.Where(x => x.UserName == username)
                                                                .Select(c => c.UserPassword)
                                                                .FirstOrDefault();
            return password;
        }
        public async Task<bool> IsRegistrationAvailable() => await _sisContext.TblAdmByTermAdmissionSchedules.AnyAsync(x => x.StartDateTime <= DateTime.Now && x.ExtenssionEndDateTime >= DateTime.Now);
        public TblMstAutoNotification GetRegistrationMessage()
        {
            return _sisContext.TblMstAutoNotifications.First(x => x.AutoNotificationRecId == 1);
        }
        
    }
}
