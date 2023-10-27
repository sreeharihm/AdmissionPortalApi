using FluentValidation;

namespace AdmissionPortal.Application.CustomValidations
{
    public static class PhoneNumberValidation
    {
        public static IRuleBuilder<T, string> PhoneNumber<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            var options = ruleBuilder
                .Matches(@"^\+?[0-9]*$")
                .WithMessage("Invalid Mobile number ");
            return options;
        }
    }
}
