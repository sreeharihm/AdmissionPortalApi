using AdmissionPortal.Application.Feature.Registration.Commands;
using AdmissionPortal.Infra.Data.Interface;
using MediatR;

namespace AdmissionPortal.Application.Feature.Login.Handlers
{
    public class PasswordResetHandler : IRequestHandler<PasswordResetCommand, bool>
    {
        private readonly IApplicationUserRepository _applicationUserRepository;

        public PasswordResetHandler(IApplicationUserRepository applicationUserRepository)
        {
            _applicationUserRepository = applicationUserRepository;
        }
        public async Task<bool> Handle(PasswordResetCommand request, CancellationToken cancellationToken)
        {
            bool isValidUser = _applicationUserRepository.IsEmailAlreadyRegistered(request.Email);
            string oldPassword = await _applicationUserRepository.GetPassword(request.Email);
            if (isValidUser && oldPassword.CompareTo(request.OldPassword)==0)
            {
                return await _applicationUserRepository.ResetPassword(request.Email, request.NewPassword);
            }
            return false;
        }

    }
}
