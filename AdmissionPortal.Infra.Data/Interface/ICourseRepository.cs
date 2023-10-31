using AdmissionPortal.Domain.Dto;

namespace AdmissionPortal.Infra.Data.Interface
{
    public interface ICourseRepository
    {
        Task<CourseDetailDto> GetCourseDetails();
    }
}
