using AdmissionPortal.Application.CustomValidations;
using AdmissionPortal.Application.Feature.Registration.Commands;
using AdmissionPortal.Infra.Data.Interface;
using FluentValidation;

namespace AdmissionPortal.Application.Feature.Registration.Validator
{
    public class CreateApplicationUserValidator : AbstractValidator<CreateApplicationUserCommand>
    {
        private readonly IApplicationUserRepository _applicationUserRepository;

        public CreateApplicationUserValidator(IApplicationUserRepository applicationUserRepository)
        {
            _applicationUserRepository = applicationUserRepository;

            RuleFor(p => p.Nationality).NotEmpty().When(x=>x.IsArabCountry==false);
            RuleFor(p => p.NationalId).NotEmpty();
            RuleFor(p => p.FirstNameEng).NotEmpty().Matches("^[a-zA-Z ]*$").WithMessage("Only letters are allowed");
            RuleFor(p => p.LastNameEng).NotEmpty().Matches("^[a-zA-Z ]*$").WithMessage("Only letters are allowed"); 
            RuleFor(p => p.FatherNameEng).Matches("^[a-zA-Z ]*$").WithMessage("Only letters are allowed").NotEmpty().When(x=>x.IsArabCountry); 
            RuleFor(p => p.GrandFatherNameEng).NotEmpty().Matches("^[a-zA-Z ]*$").WithMessage("Only letters are allowed").When(x => x.IsArabCountry); 
            RuleFor(p => p.FirstNameLocal).NotEmpty().Matches("^[ء-ي]+").WithMessage("Only arabic letters are allowed").When(x => x.IsArabCountry);
            RuleFor(p => p.LastNameLocal).NotEmpty().Matches("^[ء-ي]+").WithMessage("Only arabic letters are allowed").When(x => x.IsArabCountry); ;
            RuleFor(p => p.FatherNameLocal).NotEmpty().Matches("^[ء-ي]+").WithMessage("Only arabic letters are allowed").When(x => x.IsArabCountry);
            RuleFor(p => p.GrandFatherNameLocal).NotEmpty().Matches("^[ء-ي]+").WithMessage("Only arabic letters are allowed").When(x => x.IsArabCountry);
            RuleFor(p => p.Gender).NotEmpty();
            RuleFor(p => p.DateofBirth).Must(BeAValidDate).WithMessage("Invalid date of birth");
                }
        private bool BeAValidDate(DateTime date) => !date.Equals(default(DateTime));      
    }
}