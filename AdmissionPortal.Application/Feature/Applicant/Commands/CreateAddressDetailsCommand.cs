using AdmissionPortal.Domain.Dto;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Commands
{
    public class CreateAddressDetailsCommand : IRequest<ApplicantDto>
    {
        public int ApplicationRecId { get; set; }
        public int UserId { get; set; }
        public string ApplicationNumber { get; set; }
        public string ContactAddress { get; set; }
        public string ContactCityName { get; set; }
        public int ContactCountryId { get; set; }
        public string ContactPobox { get; set; }
        public string ContactPostalCode { get; set; }
        public string ContactProvinceName { get; set; }
        public string ContactHomeTelephoneNumber { get; set; }
        public string PermanentAddress { get; set; }
        public string PermanentCityName { get; set; }
        public int PermanentCountryId { get; set; }
        public string PermanentHomeTelephoneNumber { get; set; }
        public string PermanentPobox { get; set; }
        public string PermanentPostalCode { get; set; }
        public string PermanentProvinceName { get; set; }
    }
}
