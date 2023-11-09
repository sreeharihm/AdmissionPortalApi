using AdmissionPortal.Application.Feature.Applicant.Commands;
using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using AdmissionPortal.Infra.Data.Models;
using MediatR;
using System.Text;

namespace AdmissionPortal.Application.Feature.Applicant.Handler
{
    public class CreateApplicantCheckListHandler : IRequestHandler<CreateApplicantCheckListCommand, ApplicantDto>
    {
        private readonly IApplicantRepository _applicationRepository;
        public CreateApplicantCheckListHandler(IApplicantRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }
        public async Task<ApplicantDto> Handle(CreateApplicantCheckListCommand request, CancellationToken cancellationToken)
        {
            var model = new TblAdmApplicantChecklist
            {
                ApplicationRecId = request.ApplicationRecId,
                ChecklistByTermRecId = request.CheckListbyTermRecId,
                ChecklistStatus = request.CheckListStatus,
                DisplayOrder = request.DisplayOrder,
                ChecklistAttachments = Encoding.ASCII.GetBytes(request.CheckListAttachments)
            };
            await _applicationRepository.UpsertAdmissionCheckList(model, request.UserId);
            return new ApplicantDto();
        }
    }
}
