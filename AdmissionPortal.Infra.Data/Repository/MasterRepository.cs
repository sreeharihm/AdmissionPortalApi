using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using AdmissionPortal.Infra.Data.Models;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Math.EC.Rfc7748;
using System.Net.Http.Headers;

namespace AdmissionPortal.Infra.Data.Repository
{
    public class MasterRepository : IMasterRepository
    {
        private readonly SisContext _sisContext;
        public MasterRepository(SisContext sisContext)
        {
            _sisContext = sisContext;
        }
        public async Task<EducationData> GetLocalData()
        {
            var result = new EducationData();
            result.countryData = await _sisContext.TblMstCountryMasters.Select(x => new CountryData { CountryNameLocal= x.NationalityLocalName, CountryRecId=x.CountryRecId, CountryName=x.NationalityEngName }).ToListAsync();
            result.provinceData = await _sisContext.TblMstProvinces.Select(x => new ProvinceData { ProvinceNameLocal = x.ProvinceNameLocal, ProvinceId = x.ProvinceId, ProvinceName = x.ProvinceName }).ToListAsync();
            result.educationTypeData = await _sisContext.TblMstEducationTypes.Select(x => new EducationTypeData { EducationTypeLocalName = x.EducationTypeLocalName, EducationTypeRecId = x.EducationTypeRecId, EducationTypeEngName = x.EducationTypeEngName }).ToListAsync();
            result.cityData = await _sisContext.TblMstCities.Select(x => new CityData { CityNameLocal = x.CityNameLocal, ProvinceId = x.ProvinceId.Value, CityName = x.CityName }).ToListAsync();
            result.StudyCenterData = await _sisContext.TblMstStudentTypeMasters.Select(x => new StudyCenterData { StudyCenterLocalName = x.StudentTypeLocalName, StudentTypeRecId = x.StudentTypeRecId, StudyCenterEngName = x.StudentTypeEngName }).ToListAsync();
            result.highSchoolTypeData = await _sisContext.TblMstHighSchoolTypeMasters.Select(x => new HighSchoolTypeData { HighSchoolTypeLocalName = x.HighSchoolTypeLocalName, HighSchoolTypeRecId = x.HighSchoolTypeRecId, HighSchoolTypeEnName = x.HighSchoolTypeEnName }).ToListAsync();
            return result;
        }
    }
}
