using AdmissionPortal.Domain.Dto;
using MediatR;

namespace AdmissionPortal.Application.Feature.Registration.Commands
{
    public class CreateApplicationUserCommand : IRequest<UserDto>
    {
        public bool IsArabCountry { get; set; }
        public string? Nationality { get; set; }
        public string? NationalId { get; set; }
        public string? FirstNameEng { get; set; }
        public string? LastNameEng { get; set; }
        public string? FatherNameEng { get; set; }
        public string? GrandFatherNameEng { get; set; }
        public string? FirstNameLocal { get; set; }
        public string? FatherNameLocal { get; set; }
        public string? GrandFatherNameLocal { get; set; }
        public string? LastNameLocal { get; set; }
        public bool? Gender { get; set; }
        public DateTime DateofBirth { get; set; }
        public string? EmailAddress { get; set; }
        public string? Mobile { get; set; }
        public bool? GuidelinesAcknowledged { get; set; } = true;
        public bool? TermsAcknowledged { get; set; } = true;
        public int? InsertedBy { get; set; } = 1;
        public DateTime InsertedDateTime { get; set; }

    }
}