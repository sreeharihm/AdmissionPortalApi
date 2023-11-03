using AdmissionPortal.Domain.Dto;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Queries
{
    public class GetAdmissionCriteriaQuery : IRequest<List<AdmissionCriteriaDto>>
    {
        public int ApplicationRecId { get; set; }
        public string ApplicationNumber { get; set; }
    }
}
