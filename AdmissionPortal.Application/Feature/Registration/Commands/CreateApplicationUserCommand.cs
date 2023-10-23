using MediatR;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdmissionPortal.Application.Feature.Registration.Commands
{
    public class CreateApplicationUserCommand : IRequest<int>
    {
        public bool IsArabCountry { get; set; }
        [Required]
        public string? Nationality { get; set; }
        [Required] public string? NationalId { get; set; }
        [Required][RegularExpression(@"^[a-zA-Z ]*$")] public string? FirstNameEng { get; set; }
        [Required][RegularExpression(@"^[a-zA-Z ]*$")] public string? LastNameEng { get; set; }
        [RegularExpression(@"^[a-zA-Z ]*$")] public string? FatherNameEng { get; set; }
        [RegularExpression(@"^[a-zA-Z ]*$")] public string? GrandFatherNameEng { get; set; }
        [RegularExpression(@"^[ء-ي]+$")] public string? FirstNameLocal { get; set; }
        [RegularExpression(@"^[ء-ي]+$")] public string? FatherNameLocal { get; set; }
        [RegularExpression(@"^[ء-ي]+$")] public string? GrandFatherNameLocal { get; set; }
        [RegularExpression(@"^[ء-ي]+$")] public string? LastNameLocal { get; set; }
        [Required] public bool? Gender { get; set; }
        [Required, DataType(DataType.Date)] public DateTime DateofBirth { get; set; }
        [Required][EmailAddress] public string? EmailAddress { get; set; }
        [Required][Phone] public string? Mobile { get; set; }
        public bool? GuidelinesAcknowledged { get; set; } = true;
        public bool? TermsAcknowledged { get; set; } = true;
        public int? InsertedBy { get; set; } = 1;
        public DateTime InsertedDateTime { get; set; }

    }
}