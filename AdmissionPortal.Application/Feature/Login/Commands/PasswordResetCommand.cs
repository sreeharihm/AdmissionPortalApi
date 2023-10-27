using MediatR;

namespace AdmissionPortal.Application.Feature.Registration.Commands
{
    public class PasswordResetCommand:IRequest<bool>
    {  
        public string Email { get; set; }
      
    }
}
