using AdmissionPortal.Application.Feature.Applicant.Queries;
using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Handler
{
    public class GetAdditionalDetailsHandler : IRequestHandler<GetAdditionalDetailsQuery, List<AdmissionQuestion>>
    {
        private readonly IApplicantRepository _applicationRepository;
        public GetAdditionalDetailsHandler(IApplicantRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
        public async Task<List<AdmissionQuestion>> Handle(GetAdditionalDetailsQuery request, CancellationToken cancellationToken)
        {
            return await _applicationRepository.GetAdditionalDetails(request.ApplicationRecId, request.ApplicationNumber);
        }
    }
}
