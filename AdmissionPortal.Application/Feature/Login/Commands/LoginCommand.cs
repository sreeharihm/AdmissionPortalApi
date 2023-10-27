using MediatR;

namespace AdmissionPortal.Application.Feature.Login.Commands
{
    public class LoginCommand : IRequest<bool>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

}
