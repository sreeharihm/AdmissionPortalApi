using AdmissionPortal.Application.Feature.Applicant.Queries;
using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Handler
{
    public class GetEducationDataHandler : IRequestHandler<GetEducationDataQuery, EducationData>
    {
        private readonly IMasterRepository _masterRepository;
        public GetEducationDataHandler(IMasterRepository masterRepository)
        {
            _masterRepository = masterRepository;
        }
        public async Task<EducationData> Handle(GetEducationDataQuery request, CancellationToken cancellationToken)
        {
            return await _masterRepository.GetLocalData();
        }
    }
}
