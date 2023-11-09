using AdmissionPortal.Application.Feature.Applicant.Commands;
using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using AdmissionPortal.Infra.Data.Models;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Handler
{
    public class CreateApplicantCriteriaHandler : IRequestHandler<CreateApplicantCriteriaCommand, ApplicantDto>
    {
        private readonly IApplicantRepository _applicationRepository;
        public CreateApplicantCriteriaHandler(IApplicantRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
        public async Task<ApplicantDto> Handle(CreateApplicantCriteriaCommand request, CancellationToken cancellationToken)
        {
            var result = new ApplicantDto();
            var model = new TblAdmApplicantAdmissionCriteria();
            model.ApplicationRecId = request.ApplicationRecId;
            model.TermCriteriaRecId = request.TermCriteriaRecId;
            model.CriteriaMinimum = request.CriteriaMinimum;
            model.CriteriaMaxmum = request.CriteriaMaxmum;
            model.CriteriaWeightage = request.CriteriaWeightage;
            model.CriteriaDocuments = request.CriteriaDocuments;
            model.CriteriaRemarks = request.CriteriaRemarks;
            model.CriteriaDisplayOrder = request.CriteriaDisplayOrder;
            model.InsertedBy = request.UserId;

            await _applicationRepository.UpsertAdmissionCriteria(model,request.UserId);
            return result;
        }
    }
}
