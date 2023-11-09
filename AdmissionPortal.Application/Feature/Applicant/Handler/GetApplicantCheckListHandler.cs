using AdmissionPortal.Application.Feature.Applicant.Queries;
using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Handler
{
    public class GetApplicantCheckListHandler : IRequestHandler<GetApplicantCheckListQuery, List<ApplicantCheckList>>
    {
        private readonly IApplicantRepository _applicationRepository;
        public GetApplicantCheckListHandler(IApplicantRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
        public async Task<List<ApplicantCheckList>> Handle(GetApplicantCheckListQuery request, CancellationToken cancellationToken)
        {
            return await _applicationRepository.GetAdmissionCheckList(request.ApplicationRecId, request.ApplicationNumber, request.UserId);
        }
    }
}
