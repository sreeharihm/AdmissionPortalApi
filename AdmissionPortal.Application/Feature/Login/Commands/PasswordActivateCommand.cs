
using MediatR;

namespace AdmissionPortal.Application.Feature.Login.Commands
{
    public class PasswordActivateCommand : IRequest<bool>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ActivationCode { get; set; }
    }
}
