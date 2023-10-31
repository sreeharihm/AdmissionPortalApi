using AdmissionPortal.Domain.Dto;
using MediatR;

namespace AdmissionPortal.Application.Feature.Course.Queries
{
    public class GetCourseQuery:IRequest<CourseDetailDto>
    {
    }
}
