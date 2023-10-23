using AdmissionPortal.Infra.Data.Models;

namespace AdmissionPortal.Infra.Data.Interface
{
    public interface ICountryMasterRepository : IGenericRepository<TblMstCountryMaster>
    {
        Task<List<TblMstCountryMaster>> GetCountryMaster();
    }
}
