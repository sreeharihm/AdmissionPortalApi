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
    }
}
