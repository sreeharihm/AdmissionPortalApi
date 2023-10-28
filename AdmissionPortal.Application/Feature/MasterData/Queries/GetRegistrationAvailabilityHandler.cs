using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using MediatR;

namespace AdmissionPortal.Application.Feature.MasterData.Queries
{
    public class GetRegistrationAvailabilityHandler : IRequestHandler<GetRegistrationAvailability, bool>
    {
        private readonly IApplicationUserRepository _applicationUserRepository;

        public GetRegistrationAvailabilityHandler(IApplicationUserRepository applicationUserRepository)
        {
            _applicationUserRepository = applicationUserRepository;
        }
        public async Task<bool> Handle(GetRegistrationAvailability request, CancellationToken cancellationToken)
        {
            return await _applicationUserRepository.IsRegistrationAvailable();
        }
    }
}
