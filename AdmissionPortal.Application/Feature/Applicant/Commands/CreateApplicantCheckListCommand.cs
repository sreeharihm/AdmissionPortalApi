using AdmissionPortal.Domain.Dto;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Commands
{
    public class CreateApplicantCheckListCommand : IRequest<ApplicantDto>
    {
        public int ApplicationRecId { get; set; }
        public int CheckListbyTermRecId { get; set; }
        public string CheckListAttachments { get; set; }
        public bool CheckListStatus { get; set; }
        public int DisplayOrder { get; set; }
        public int UserId { get; set; }
    }
}
