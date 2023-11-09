namespace AdmissionPortal.Domain.Dto
{
    public class ApplicantCheckList
    {
        public int ChecklistByTermRecId { get; set; }
        public int ChecklistRecId { get; set; }
        public string ChecklistEngName { get; set; }
        public string ChecklistLocalName { get; set; }
        public string ChecklistNotesEng { get; set; }
        public string ChecklistNotesLocal { get; set; }
        public bool ChecklistIsForLocals { get; set; }
        public bool ChecklistIsForNonLocals { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsLocal { get; set; }
    }
}
