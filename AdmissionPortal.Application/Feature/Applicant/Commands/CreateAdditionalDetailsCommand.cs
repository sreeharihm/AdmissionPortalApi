using MediatR;

namespace AdmissionPortal.Application.Feature.Applicant.Commands
{
    public class CreateAdditionalDetailsCommand : IRequest<bool>
    {
        public int UserId { get; set; }
        public int ApplicationRecId { get; set; }
        public int QuestionsByTermRecId { get; set; }
        public int QuestionsDetailsRecId { get; set; }
    }
}
