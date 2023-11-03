using AdmissionPortal.Application.Extensions;
using AdmissionPortal.Application.Feature.Login.Commands;
using AdmissionPortal.Application.Helpers;
using AdmissionPortal.Infra.Data.Interface;
using MediatR;
namespace AdmissionPortal.Application.Feature.Login.Handlers
{
    public class LoginHandler : IRequestHandler<LoginCommand, bool>
    {
        private readonly IApplicationUserRepository _applicationUserRepository;

        public LoginHandler(IApplicationUserRepository applicationUserRepository)
        {
            _applicationUserRepository = applicationUserRepository;
        }
        public async Task<bool> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            bool isValidUser = await _applicationUserRepository.IsValidUserName(request.Username);
            string dbPassword = await _applicationUserRepository.GetPassword(request.Username);
            if (isValidUser && (!string.IsNullOrEmpty(dbPassword) && dbPassword.Base64Decode().CompareTo(request.Password) == 0))
            {
                return true;
            }
            return false;
        }

    }
}
