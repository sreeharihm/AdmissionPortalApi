using AdmissionPortal.Application.Feature.Applicant.Commands;
using AdmissionPortal.Infra.Data.Interface;
using AdmissionPortal.Infra.Data.Models;
using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Handler
{
    public class CreateAdditionalDetailsHandler : IRequestHandler<CreateAdditionalDetailsCommand, bool>
    {
        private readonly IApplicantRepository _applicationRepository;
        public CreateAdditionalDetailsHandler(IApplicantRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }

        public async Task<bool> Handle(CreateAdditionalDetailsCommand request, CancellationToken cancellationToken)
        {
            var model = new TblAdmApplicantAdmissionQuestion
            {
                ApplicationRecId = request.ApplicationRecId,
                QuestionDetailsRecId = request.QuestionsDetailsRecId,
                QuestionsByTermRecId = request.QuestionsByTermRecId
            };
            return await _applicationRepository.UpsertAdditionalDetails(model, request.UserId);
        }
    }
}
