using AdmissionPortal.Application.Feature.Applicant.Queries;
using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Handler
{
    public class GetProgramPreferencesHandler : IRequestHandler<GetProgramPreferencesQuery, List<ApplicantPreferenceDto>>
    {
        private readonly IApplicantRepository _applicationRepository;
        public GetProgramPreferencesHandler(IApplicantRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }

        public async Task<List<ApplicantPreferenceDto>> Handle(GetProgramPreferencesQuery request, CancellationToken cancellationToken)
        {
            return await _applicationRepository.GetPreference(request.ApplicationRecId, request.ApplicationNumber);
        }
    }
}
