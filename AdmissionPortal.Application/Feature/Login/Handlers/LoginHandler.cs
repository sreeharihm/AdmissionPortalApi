using AdmissionPortal.Application.Feature.Login.Commands;
using AdmissionPortal.Application.Helpers;
using AdmissionPortal.Infra.Data.Interface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            bool isValidUser=  await _applicationUserRepository.IsValidUserName(request.Username);
            string dbPassword= await _applicationUserRepository.GetPassword(request.Username);
            if (isValidUser && (!string.IsNullOrEmpty(dbPassword) && Decryption.Base64Decode(dbPassword)==request.Password))
            {
                return true;
            }
            return false;
        }

    }
}
