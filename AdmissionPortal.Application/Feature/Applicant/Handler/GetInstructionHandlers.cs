using AdmissionPortal.Application.Feature.Applicant.Queries;
using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Handler
{
    public class GetInstructionHandlers : IRequestHandler<GetInstructionsQuery, List<InstructionsDto>>
    {
        private readonly IApplicantRepository _applicationRepository;
        public GetInstructionHandlers(IApplicantRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
        public async Task<List<InstructionsDto>> Handle(GetInstructionsQuery request, CancellationToken cancellationToken)
        {
            return await _applicationRepository.GetInstructions();
        }
    }
}
