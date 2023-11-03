namespace AdmissionPortal.Domain.Dto
{
    public class AdmissionQuestionDetails
    {
        public int QuestionsDetailsRecId { get; set; }
        public string QuestionsDetailsOrder { get; set; }
        public string AnswerEngName { get; set; }
        public string AnswerLocalName { get; set; }
        public int AnswerGender { get; set; }
        public bool AnswerStatus { get; set; }
    }
}
