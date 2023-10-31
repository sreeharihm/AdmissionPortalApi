using AdmissionPortal.Application.Feature.Login.Commands;
using AdmissionPortal.Infra.Data.Interface;
using MediatR;

namespace AdmissionPortal.Application.Feature.Login.Handlers
{
    public class PasswordActivateHandler : IRequestHandler<PasswordActivateCommand, bool>
    {
        private readonly IApplicationUserRepository _applicationUserRepository;

        public PasswordActivateHandler(IApplicationUserRepository applicationUserRepository)
        {
            _applicationUserRepository = applicationUserRepository;
        }
        public async Task<bool> Handle(PasswordActivateCommand request, CancellationToken cancellationToken)
        {
            bool isValidUser = _applicationUserRepository.IsEmailAlreadyRegistered(request.Email);
            bool isValidActivationCode = await _applicationUserRepository.IsValidActivationCode(request.ActivationCode);
            if (isValidUser && isValidActivationCode)
            {
                return await _applicationUserRepository.ResetPassword(request.Email, request.Password);
            }
            return false;
        }

    }
}
