using AdmissionPortal.Infra.Data.Interface;
using AdmissionPortal.Infra.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace AdmissionPortal.Infra.Data.Repository
{
    public class CountryMasterRepository : GenericRepository<TblMstCountryMaster>, ICountryMasterRepository
    {
        private readonly SisContext _sisContext;
        public CountryMasterRepository(SisContext sisContext) : base(sisContext)
        {
            _sisContext = sisContext;
        }

        public async Task<List<TblMstCountryMaster>> GetCountryMaster()
        {
            return await _sisContext.TblMstCountryMasters.ToListAsync();
        }
    }
}
