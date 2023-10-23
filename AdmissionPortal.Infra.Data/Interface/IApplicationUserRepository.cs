using AdmissionPortal.Infra.Data.Models;

namespace AdmissionPortal.Infra.Data.Interface
{
    public interface IApplicationUserRepository : IGenericRepository<TblSsaApplicationUser>
    {
        public Task<int> AddUser(TblSsaApplicationUser applicationUser);
    }
}