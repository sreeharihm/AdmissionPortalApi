using AdmissionPortal.Domain.Dto;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Queries
{
    public class GetEducationDataQuery: IRequest<EducationData>
    {
    }
}
