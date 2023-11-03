using AdmissionPortal.Domain.Dto;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Queries
{
    public class GetAdditionalDetailsQuery : IRequest<List<AdmissionQuestion>>
    {
        public int ApplicationRecId { get; set; }
        public string ApplicationNumber { get; set; }
    }
}
