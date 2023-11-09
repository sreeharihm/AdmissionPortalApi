using AdmissionPortal.Domain.Dto;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Queries
{
    public class GetInstructionsQuery : IRequest<List<InstructionsDto>>
    {
        public string InstructionType { get; set; }
    }
}
