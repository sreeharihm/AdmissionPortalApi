using AdmissionPortal.Application.Feature.Applicant.Queries;
using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Handler
{
    public class GetApplicantAddressHandler : IRequestHandler<GetApplicantAddressQuery, ApplicantAddressDto>
    {
        private readonly IApplicantRepository _applicationRepository;
        public GetApplicantAddressHandler(IApplicantRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
        public async Task<ApplicantAddressDto> Handle(GetApplicantAddressQuery request, CancellationToken cancellationToken)
        {
            return await _applicationRepository.GetAddressDetails(request.ApplicationRecId, request.ApplicationNumber);
        }
    }
}
