using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using MediatR;

namespace AdmissionPortal.Application.Feature.Course.Queries
{
    public class GetCourseHandler : IRequestHandler<GetCourseQuery, CourseDetailDto>
    {
        private readonly ICourseRepository _courseRepository;

        public GetCourseHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public async Task<CourseDetailDto> Handle(GetCourseQuery request, CancellationToken cancellationToken)
        {
            return await _courseRepository.GetCourseDetails();
        }
    }
}
