using AdmissionPortal.Infra.Data.Models;

namespace AdmissionPortal.Infra.Data.Interface
{
    public interface IApplicationUserRepository : IGenericRepository<TblSsaApplicationUser>
    {
        public Task<int> AddUser(TblSsaApplicationUser applicationUser);
        public bool IsMobileAlreadyRegistered(string mobile);
        public bool IsEmailAlreadyRegistered(string emailAddress);
        public Task<bool> IsValidUserName(string username);
        public Task<string> GetPassword(string username);
        Task<bool> IsValidActivationCode(string activationCode);
        Task<bool> ResetPassword(string emailId, string password);
    }
}