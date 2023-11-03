using AdmissionPortal.Application.Feature.Applicant.Commands;
using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using AdmissionPortal.Infra.Data.Models;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Handler
{
    public class CreateApplicantPerferenceHandler : IRequestHandler<CreateApplicantPerferenceCommand, ApplicantDto>
    {
        private readonly IApplicantRepository _applicationRepository;
        public CreateApplicantPerferenceHandler(IApplicantRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
        public async Task<ApplicantDto> Handle(CreateApplicantPerferenceCommand request, CancellationToken cancellationToken)
        {
            var model = new TblAdmApplicantPreferenceInformation();
            var result = new ApplicantDto();
            model.ProgramPreferenceConfiramtionStatus = request.ProgramPreferenceConfiramtionStatus;
            model.ProgramPreferenceConfiramtionDate = DateTime.Now;
            model.ApplicationRecId = request.ApplicationRecId;
            model.ProgramPreferenceRecId = request.ProgramPreferenceRecId;
            model.InsertBy = request.UserId;
            await _applicationRepository.UpsertPreference(model);
            return result;
        }
    }
}
