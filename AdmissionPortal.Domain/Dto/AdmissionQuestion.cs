namespace AdmissionPortal.Domain.Dto
{
    public class AdmissionQuestion
    {
        public AdmissionQuestion()
        {
            QuestionDetails = new List<AdmissionQuestionDetails>();
        }
        public int QuestionByTermId { get; set; }
        public int QuestionRecId { get; set; }
        public int QuestionsByTermRecId { get; set; }
        public int DisplayOrder { get; set; }
        public string QuestionEngName { get; set; }
        public string QuestionLocalName { get; set; }
        public string QuestionType { get; set; }
        public bool QuestionStatus { get; set; }
        public List<AdmissionQuestionDetails> QuestionDetails { get; set; }
    }
}
