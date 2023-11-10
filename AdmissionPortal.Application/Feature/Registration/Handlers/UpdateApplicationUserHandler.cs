using AdmissionPortal.Application.Extensions;
using AdmissionPortal.Application.Feature.Registration.Commands;
using AdmissionPortal.Application.Helpers;
using AdmissionPortal.Application.Interface;
using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using AdmissionPortal.Infra.Data.Models;
using MediatR;
using NETCore.MailKit.Core;
using System.Text;

namespace AdmissionPortal.Application.Feature.Registrarion.Handlers
{
    internal class UpdateApplicationUserHandler : IRequestHandler<UpdateApplicationUserCommand, UserDto>
    {
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IEmailSender _emailSender;
        private readonly ISMSSender _smsSender;

        public UpdateApplicationUserHandler(IApplicationUserRepository applicationUserRepository, IEmailSender emailSender,ISMSSender smsSender)
        {
            _applicationUserRepository = applicationUserRepository;
            _emailSender = emailSender; 
            _smsSender = smsSender;
        }
        public async Task<UserDto> Handle(UpdateApplicationUserCommand command, CancellationToken cancellationToken)
        {
            bool cc= await _smsSender.SendSmsAsync();
            var userDetails = new TblSsaApplicationUser();
            var response = new UserDto();
            userDetails.UserId = command.UserId;
            response.UserId = command.UserId;
            userDetails.EmailAddress = command.EmailAddress;
            userDetails.Mobile = command.Mobile;           
            userDetails.UserName = command.EmailAddress;           
            userDetails.TermsAcknowledged = command.TermsAcknowledged;
            userDetails.LastUpdatedBy = command.UserId;
            userDetails.LastUpdatedDateTime = DateTime.Now;
            string activationCode = await _applicationUserRepository.UpdateRegistrationDetails(userDetails);
            if (!string.IsNullOrEmpty(activationCode))
            {
                var data = _applicationUserRepository.GetRegistrationMessage();
                StringBuilder sb = new StringBuilder(data.EmailMessageEng);
                sb.Replace("<%UserName%>", userDetails.EmailAddress);
                sb.Replace("<%Password%>", activationCode);
                var message = new Message(userDetails.EmailAddress, "Welcome", sb.ToString());
                _emailSender.SendEmail(message);
                response.Message = "User registration succesfull";
                response.ActivationCode = activationCode;
            }
            else
            {
                response.Message = "User registration failed";
            }
            return response;
        }
    }
}
