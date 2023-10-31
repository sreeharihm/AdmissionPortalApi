using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using AdmissionPortal.Infra.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AdmissionPortal.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly SisContext _sisContext;
        public CourseRepository(SisContext sisContext)
        {
            _sisContext = sisContext;
        }
        public async Task<CourseDetailDto> GetCourseDetails()
        {
            var result = new CourseDetailDto
            {
                admissionTypes = new List<AdmissionType>(),
                courseTenure = new CourseTenure(),
                courseTypes = new List<CourseType>(),
                courseYears = new List<CourseYear>(),
            };
            result.admissionTypes.AddRange(await (from ast in _sisContext.TblAdmByTermAdmissionSchedules
                                                  join at in _sisContext.TblMstAdmissionTypeMasters
                                                  on ast.AdmissionTypeRecId equals at.AdmissionTypeRecId
                                                  select new AdmissionType { AdmissionTypeRecId = ast.AdmissionTypeRecId, AdmissionTypeEngName = at.AdmissionTypeEngName, AdmissionTypeLocalName = at.AdmissionTypeLocalName }
                                ).Distinct().ToListAsync());

            result.courseTypes.AddRange(await (from ast in _sisContext.TblAdmByTermAdmissionSchedules
                                               join at in _sisContext.TblMstDegreeTypeMasters
                                               on ast.DegreeTypeRecId equals at.DegreeTypeRecId
                                               select new CourseType { DegreeTypeRecId = ast.DegreeTypeRecId.Value, DegreeTypeEngName = at.DegreeTypeEngName, DegreeTypeLocalName = at.DegreeTypeLocalName }
                              ).Distinct().ToListAsync());

            result.courseYears.AddRange(await (from ast in _sisContext.TblAdmByTermAdmissionSchedules
                                               join ay in _sisContext.TblRegAcademicYears
                                               on ast.AcademicYearRecId equals ay.AcademicYearRecId
                                               select new CourseYear { AyStartYear = ay.AystartYear, AyEndYear = ay.AyendYear, AyStartYearLocal = ay.AystartYearLocal, AyEndYearLocal = ay.AyendYear1Local }
                              ).Distinct().ToListAsync());

            var courseTenure = await (from t in _sisContext.TblRegTermMasters
                                      where t.TermStartDateAndTime <= DateTime.Now && t.TermEndDateAndTime >= DateTime.Now
                                      select new CourseTenure { TermCode = t.TermCode.Value, TermId = t.TermId, TermName = t.TermName }
                               ).FirstOrDefaultAsync();
            if (courseTenure != null)
            {
                result.courseTenure = courseTenure;
            }
            return result;
        }
    }
}
