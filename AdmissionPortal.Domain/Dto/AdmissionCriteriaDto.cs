namespace AdmissionPortal.Domain.Dto
{
    public class AdmissionCriteriaDto
    {
        public string CriteriaLocalName { get; set; }
        public int CriteriaTypeRecId { get; set; }
        public string CriteriaType { get; set; }
        public string CriteriaEngName { get; set; }
        public int CriteriaMinimum { get; set; }
        public int CriteriaMaxmum { get; set; }
        public int CriteriaWeightage { get; set; }
        public int CriteriaGroupRecId { get; set; }
        public int CriteriaGender { get; set; }
        public bool CriteriaForCitizen { get; set; }
        public string Condition { get; set; }
        public bool CriteriaForNonCitizen { get; set; }
        public string CriteriaLocalRemarks { get; set; }
        public string CriteriaEngRemarks { get; set; }
    }
}
