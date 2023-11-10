using AdmissionPortal.Domain.Dto;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Commands
{
    public class CreateApplicantPersonalDetailsCommand : IRequest<ApplicantDto>
    {
        public string ApplicationNumber { get; set; }
        public int ApplicationRecId { get; set; }
        public int UserId { get; set; }
        public string FirstNameEng { get; set; }
        public string LastNameEng { get; set; }
        public string FirstNameLocal { get; set; }
        public string LastNameLocal { get; set; }
        public string FatherNameEng { get; set; }
        public string FatherNameLocal { get; set; }
        public string GrandFatherNameEng { get; set; }
        public string GrandFatherNameLocal { get; set; }
        public string PrimaryEmailId { get; set; }
        public string PrimaryMobileNo { get; set; }
        public string Gender { get; set; }
        public int CountryId { get; set; }
        public int IsMobileVerified { get; set; }
        public int IsEmailVerified { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
