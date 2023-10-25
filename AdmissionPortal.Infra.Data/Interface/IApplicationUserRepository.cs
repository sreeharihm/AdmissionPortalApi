using AdmissionPortal.Infra.Data.Models;

namespace AdmissionPortal.Infra.Data.Interface
{
    public interface IApplicationUserRepository : IGenericRepository<TblSsaApplicationUser>
    {
        public Task<int> AddUser(TblSsaApplicationUser applicationUser);
        public Task<int> UpdateTermsandConditions(int userId, bool status);
        public Task<int> UpdateGuidelinesAcknowledged(int userId,bool status);
        public bool IsMobileAlreadyRegistered(string mobile);
        public bool IsEmailAlreadyRegistered(string emailAddress);
    }
}