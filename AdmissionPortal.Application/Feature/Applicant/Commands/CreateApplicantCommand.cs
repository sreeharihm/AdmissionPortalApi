using AdmissionPortal.Domain.Dto;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Commands
{
    public class CreateApplicantCommand : IRequest<ApplicantDto>
    {
        public int UserId { get; set; }
        public int AdmissionTypeRecId { get; set; }
        public int DegreeTypeRecId { get; set; }
        public int AcademicYearRecId { get; set; }
        public int TermId { get; set; }
        public int AyStartYear { get; set; }
    }
}
