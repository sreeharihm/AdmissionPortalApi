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
    internal class CreateApplicationUserHandler : IRequestHandler<CreateApplicationUserCommand, int>
    {
        private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IEmailSender _emailSender;

        public CreateApplicationUserHandler(IApplicationUserRepository applicationUserRepository, IEmailSender emailSender)
        {
            _applicationUserRepository = applicationUserRepository;
            _emailSender = emailSender; 
        }
        public async Task<int> Handle(CreateApplicationUserCommand command, CancellationToken cancellationToken)
        {
            var userDetails = new TblSsaApplicationUser();
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
            string password = command.Mobile.Substring(command.Mobile.Length - 4) + command.NationalId.Substring(command.NationalId.Length - 4);
            userDetails.UserPassword = Encryption.Base64Encode(password); 
            userDetails.TermsAcknowledged = command.TermsAcknowledged;
            userDetails.GuidelinesAcknowledged = command.GuidelinesAcknowledged;
            userDetails.InsertedBy = command.InsertedBy;
            userDetails.InsertedDateTime = DateTime.UtcNow;
            var userId= await _applicationUserRepository.AddUser(userDetails);
            var data = _applicationUserRepository.GetRegistrationMessage();
            StringBuilder sb= new StringBuilder(data.EmailMessageEng);
            sb.Replace("<%UserName%>", userDetails.EmailAddress);
            sb.Replace("<%Password%>", password);
            var message = new Message(userDetails.EmailAddress, "Welcome",sb.ToString());

            _emailSender.SendEmail(message);
            return userId;
        }
    }
}
