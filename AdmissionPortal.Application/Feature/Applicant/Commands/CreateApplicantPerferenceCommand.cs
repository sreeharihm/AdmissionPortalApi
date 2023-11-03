using AdmissionPortal.Domain.Dto;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Commands
{
    public class CreateApplicantPerferenceCommand : IRequest<ApplicantDto>
    {
        public int ApplicationRecId { get; set; }
        public int ProgramPreferenceRecId { get; set; }
        public int ProgramPreferenceSequence { get; set; }
        public bool ProgramPreferenceConfiramtionStatus { get; set; }
        public int UserId { get; set; } 
    }
}
