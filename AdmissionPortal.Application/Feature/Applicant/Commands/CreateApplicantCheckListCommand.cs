using AdmissionPortal.Domain.Dto;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Commands
{
    public class CreateApplicantCheckListCommand : IRequest<ApplicantDto>
    {
        public int ApplicationRecId { get; set; }
        public int CheckListbyTermRecId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public bool IsUploaded { get; set; }
        public string FileName { get; set; }
        public string FileData { get; set; }
        public int DisplayOrder { get; set; }
    }
}
