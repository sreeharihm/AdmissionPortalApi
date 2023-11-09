using AdmissionPortal.Domain.Dto;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Queries
{
    public class GetApplicantCheckListQuery : IRequest<List<ApplicantCheckList>>
    {
        public int UserId { get; set; }
        public string ApplicationNumber { get; set; }
        public int ApplicationRecId { get; set; }
    }
}
