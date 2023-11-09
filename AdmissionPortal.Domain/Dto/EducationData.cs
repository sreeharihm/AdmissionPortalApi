namespace AdmissionPortal.Domain.Dto
{
    public class EducationData
    {
        public EducationData() 
        {
            countryData = new List<CountryData>();
            provinceData = new List<ProvinceData>();
            educationTypeData = new List<EducationTypeData>();
            cityData = new List<CityData>();
            StudyCenterData = new List<StudyCenterData>();
            highSchoolTypeData = new List<HighSchoolTypeData>();
        }
        public List<CountryData> countryData { get; set; }
        public List<ProvinceData> provinceData { get; set; }
        public List<EducationTypeData> educationTypeData { get; set; }
        public List<CityData> cityData { get; set; }
        public List<StudyCenterData> StudyCenterData { get; set; }
        public List<HighSchoolTypeData> highSchoolTypeData { get; set; }
    }
}
