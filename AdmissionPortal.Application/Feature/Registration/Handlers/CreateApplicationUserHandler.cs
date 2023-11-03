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
    internal class CreateApplicationUserHandler : IRequestHandler<CreateApplicationUserCommand, UserDto>
    {
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IEmailSender _emailSender;

        public CreateApplicationUserHandler(IApplicationUserRepository applicationUserRepository, IEmailSender emailSender)
        {
            _applicationUserRepository = applicationUserRepository;
            _emailSender = emailSender; 
        }
        public async Task<UserDto> Handle(CreateApplicationUserCommand command, CancellationToken cancellationToken)
        {
            var userDetails = new TblSsaApplicationUser();
            var response = new UserDto();
            userDetails.NationalId = command.NationalId;
            userDetails.Nationality = command.Nationality;
            userDetails.EmailAddress = command.EmailAddress;
            userDetails.Mobile = command.Mobile;
            userDetails.Gender = command.Gender;
            userDetails.FirstNameEng = command.FirstNameEng;
            userDetails.LastNameEng = command.LastNameEng;
            if (!string.IsNullOrEmpty(command.FatherNameEng)) userDetails.FatherNameEng = command.FatherNameEng;
            if (!string.IsNullOrEmpty(command.GrandFatherNameEng)) userDetails.GrandFatherNameEng = command.GrandFatherNameEng;
            if (!string.IsNullOrEmpty(command.FirstNameLocal)) userDetails.FirstNameLocal = command.FirstNameLocal;
            if (!string.IsNullOrEmpty(command.LastNameLocal)) userDetails.LastNameLocal = command.LastNameLocal;
            if (!string.IsNullOrEmpty(command.FatherNameLocal)) userDetails.FatherNameLocal = command.FatherNameLocal;
            if (!string.IsNullOrEmpty(command.GrandFatherNameLocal)) userDetails.GrandFatherNameLocal = command.GrandFatherNameLocal;
            userDetails.UserName = command.EmailAddress;
            var activationCode = command.NationalId.GetLastFourCharacters() + command.Mobile.GetLastFourCharacters();
            userDetails.UserPassword = activationCode.Base64Encode();
            userDetails.TermsAcknowledged = command.TermsAcknowledged;
            userDetails.GuidelinesAcknowledged = command.GuidelinesAcknowledged;
            userDetails.InsertedBy = command.InsertedBy;
            userDetails.InsertedDateTime = DateTime.UtcNow;
            response.UserId = await _applicationUserRepository.AddUser(userDetails);

            //userDetails.UserType = need to ask 
            var data = _applicationUserRepository.GetRegistrationMessage();
            StringBuilder sb= new StringBuilder(data.EmailMessageEng);
            sb.Replace("<%UserName%>", userDetails.EmailAddress);
            sb.Replace("<%Password%>", userDetails.UserPassword);
            var message = new Message(userDetails.EmailAddress, "Welcome",sb.ToString());

            _emailSender.SendEmail(message);
            response.Message = "User registration succesfull";
            response.ActivationCode = activationCode;
            return response;
        }
    }
}
