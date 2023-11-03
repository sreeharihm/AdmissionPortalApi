using AdmissionPortal.Application.Feature.Login.Commands;
using AdmissionPortal.Infra.Data.Interface;
using MediatR;

namespace AdmissionPortal.Application.Feature.Login.Handlers
{
    public class ForgetPasswordHandler: IRequestHandler<ForgetPasswordCommand, bool>
    {
        private readonly IApplicationUserRepository _applicationUserRepository;

        public ForgetPasswordHandler(IApplicationUserRepository applicationUserRepository)
        {
            _applicationUserRepository = applicationUserRepository;
        }
        public async Task<bool> Handle(ForgetPasswordCommand request, CancellationToken cancellationToken)
        {
            bool isValidEmail =  _applicationUserRepository.IsEmailAlreadyRegistered(request.EmailId);
            if (isValidEmail)
            {
                return await _applicationUserRepository.ResetPassword(request.EmailId,request.Password);
            }
            return false;
        }

    }
}
