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
            userDetails.Gender = command.Gender;
            userDetails.FirstNameEng = command.FirstNameEng;
            userDetails.LastNameEng = command.LastNameEng;
            if (!string.IsNullOrEmpty(command.FatherNameEng)) userDetails.FatherNameEng = command.FatherNameEng;
            if (!string.IsNullOrEmpty(command.GrandFatherNameEng)) userDetails.GrandFatherNameEng = command.GrandFatherNameEng;
            if (!string.IsNullOrEmpty(command.FirstNameLocal)) userDetails.FirstNameLocal = command.FirstNameLocal;
            if (!string.IsNullOrEmpty(command.LastNameLocal)) userDetails.LastNameLocal = command.LastNameLocal;
            if (!string.IsNullOrEmpty(command.FatherNameLocal)) userDetails.FatherNameLocal = command.FatherNameLocal;
            if (!string.IsNullOrEmpty(command.GrandFatherNameLocal)) userDetails.GrandFatherNameLocal = command.GrandFatherNameLocal;
            userDetails.GuidelinesAcknowledged = command.GuidelinesAcknowledged;
            userDetails.InsertedBy = command.InsertedBy;
            userDetails.InsertedDateTime = DateTime.UtcNow;
            userDetails.UserName = command.FirstNameEng;userDetails.UserPassword= command.LastNameEng;
            response.UserId = await _applicationUserRepository.AddUser(userDetails);
            response.Message = "User registration succesfull";
            response.ActivationCode = "";
            return response;
        }
    }
}
