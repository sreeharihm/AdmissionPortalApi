namespace AdmissionPortal.Domain.Dto
{
    public class ApplicantPreferenceDto
    {
        public int ProgramRecID { get; set; }
        public int MajorRecID { get; set; }
        public string ProgramEngName { get; set; }
        public string ProgramLocalName { get; set; }
        public string ProgramShortDisplayEng { get; set; }
        public string ProgramShortDisplayLocal { get; set; }
        public string ProgramCode { get; set; }
        public int DegreeRecId { get; set; }
        public int TermId { get; set; }
        public int AdmissionTypeRecId { get; set; }
    }
}
