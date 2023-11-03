using MediatR;

namespace AdmissionPortal.Application.Feature.Login.Commands
{
    public class ForgetPasswordCommand : IRequest<bool>
    {
        public string EmailId { get; set; }
        public string Password { get; set; }
    }

}
