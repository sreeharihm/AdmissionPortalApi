using AdmissionPortal.Domain.Dto;
using MediatR;

namespace AdmissionPortal.Application.Feature.Registration.Commands
{
    public class UpdateApplicationUserCommand : IRequest<UserDto>
    {
        
        public int UserId { get; set; }
        public string? EmailAddress { get; set; }
        public string? Mobile { get; set; }
        public bool? TermsAcknowledged { get; set; } = true;

    }
}