using AdmissionPortal.Application.Feature.Applicant.Queries;
using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Handler
{
    public class GetAdmissionCriteriaHandler : IRequestHandler<GetAdmissionCriteriaQuery, List<AdmissionCriteriaDto>>
    {
        private readonly IApplicantRepository _applicationRepository;
        public GetAdmissionCriteriaHandler(IApplicantRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
        public async Task<List<AdmissionCriteriaDto>> Handle(GetAdmissionCriteriaQuery request, CancellationToken cancellationToken)
        {
            return await _applicationRepository.GetAdmissionCriteria(request.ApplicationRecId, request.ApplicationNumber);
        }
    }
}
