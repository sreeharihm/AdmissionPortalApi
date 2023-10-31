namespace AdmissionPortal.Domain.Dto
{
    public class ApplicantPersonalDetailsDto
    {
        public int UserId { get; set; }
        public string Nationality { get; set; }
        public string NationalId { get; set; }
        public string FirstNameEng { get; set; }
        public string LastNameEng { get; set; }
        public string FirstNameLocal { get; set; }
        public string LastNameLocal { get; set; }
        public string FatherNameEng { get; set; }
        public string FatherNameLocal { get; set; }
        public string GrandFatherNameEng { get; set; }
        public string GrandFatherNameLocal { get; set; }
        public string PrimaryEmailId { get; set; }
        public string PrimaryMobileNo { get; set; }
        public string Gender { get; set; }
        public string CountryId { get; set; }
    }
}
