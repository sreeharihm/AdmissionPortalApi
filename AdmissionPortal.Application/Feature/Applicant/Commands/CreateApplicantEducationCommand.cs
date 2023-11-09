using AdmissionPortal.Domain.Dto;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Commands
{
    public class CreateApplicantEducationCommand : IRequest<ApplicantDto>
    {
        public int ApplicationRecId { get; set; }
        public string SchoolName { get; set; }
        public int CountryId { get; set; }
        public string ProvinceName { get; set; }
        public string CityName { get; set; }
        public string StudyCenterName { get; set; }
        public int GraducationYear { get; set; }
        public string CertificateType { get; set; }
        public string GradeType { get; set; }
        public string ExternalCode { get; set; }
        public int UserId { get; set; }
    }
}
