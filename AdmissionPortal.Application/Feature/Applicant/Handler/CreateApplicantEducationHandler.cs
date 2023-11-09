using AdmissionPortal.Application.Feature.Applicant.Commands;
using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using AdmissionPortal.Infra.Data.Models;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Handler
{
    public class CreateApplicantEducationHandler : IRequestHandler<CreateApplicantEducationCommand, ApplicantDto>
    {
        private readonly IApplicantRepository _applicationRepository;
        public CreateApplicantEducationHandler(IApplicantRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
        public async Task<ApplicantDto> Handle(CreateApplicantEducationCommand request, CancellationToken cancellationToken)
        {
            var data = new TblAdmApplicantEducationalInformation
            { };
            await _applicationRepository.UpsertEducationDetials(data, request.UserId);
            var result = new ApplicantDto { };
            return result;
        }
    }
}
