using AdmissionPortal.Domain.Dto;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Commands
{
    public class CreateApplicantCriteriaCommand : IRequest<ApplicantDto>
    {
        public int ApplicationRecId { get; set; }
        public int TermCriteriaRecId { get; set; }
        public string CriteriaMinimum { get; set; }
        public string CriteriaMaxmum { get; set; }
        public string CriteriaWeightage { get; set; }
        public string CriteriaDocuments { get; set; }
        public string CriteriaRemarks { get; set; }
        public int CriteriaDisplayOrder { get; set; }
        public int UserId { get; set; }
    }
}
