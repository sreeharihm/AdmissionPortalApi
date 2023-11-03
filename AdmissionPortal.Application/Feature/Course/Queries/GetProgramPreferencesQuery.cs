using AdmissionPortal.Domain.Dto;
using MediatR;

namespace AdmissionPortal.Application.Feature.Course.Queries
{
    public class GetProgramPreferencesQuery : IRequest<List<ApplicantPreferenceDto>>
    {
        public int ApplicationRecId { get; set; }
        public string ApplicationNumber { get; set; }
    }
}
