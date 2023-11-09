using AdmissionPortal.Application.CustomValidations;
using AdmissionPortal.Application.Feature.Registration.Commands;
using AdmissionPortal.Infra.Data.Interface;
using FluentValidation;

namespace AdmissionPortal.Application.Feature.Registration.Validator
{
    public class UpdateApplicationUserValidator : AbstractValidator<UpdateApplicationUserCommand>
    {
        private readonly IApplicationUserRepository _applicationUserRepository;

        public UpdateApplicationUserValidator(IApplicationUserRepository applicationUserRepository)
        {
            _applicationUserRepository = applicationUserRepository;

            RuleFor(p=>p.UserId).NotEmpty();
            RuleFor(p => p.Mobile).NotEmpty().PhoneNumber().Must(BeUniqueMobile).WithMessage("There is an account already registered with this mobile.Try to login or Reset the password");
            RuleFor(p => p.EmailAddress).NotEmpty().EmailAddress().Must(BeUniqueEmail).WithMessage("There is an account already registered with this email.Try to login or Reset the password"); ;
        }
        private bool BeUniqueMobile(string mobile) => !_applicationUserRepository.IsMobileAlreadyRegistered(mobile);
        private bool BeUniqueEmail(string email) => !_applicationUserRepository.IsEmailAlreadyRegistered(email);       

    }
}