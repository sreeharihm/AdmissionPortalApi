using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmApplicantPersonalInformation
{
    public int PersonalInfoRecId { get; set; }

    public int UserId { get; set; }

    public string? AlternateEmailId { get; set; }

    public string? AlternateMobileNo { get; set; }

    public string? FisrtNameLocal { get; set; }

    public string? SecondNameLocal { get; set; }

    public string? ThirdNameLocal { get; set; }

    public string? FourthNameLocal { get; set; }

    public string? FisrtNameEng { get; set; }

    public string? SecondNameEng { get; set; }

    public string? ThirdNameEng { get; set; }

    public string? FourthNameEng { get; set; }

    public int? Gender { get; set; }

    public int? CountryId { get; set; }

    public int? VisaTypeId { get; set; }

    public int? StudentTypeId { get; set; }

    public string? IdentityNumber { get; set; }

    public string? HomeIdentityNumber { get; set; }

    public string? PassportNumber { get; set; }

    public string? PassporPlaceOfIssueEng { get; set; }

    public DateTime? PassportExpiryDate { get; set; }

    public string? PassporPlaceOfIssueLocal { get; set; }

    public string? BorderNumber { get; set; }

    public DateTime? DateofBirth { get; set; }

    public int? ContactCountryId { get; set; }

    public string? ContactProvinceName { get; set; }

    public string? ContactCityName { get; set; }

    public string? ContactHomeTelephoneNumber { get; set; }

    public string? ContactPostalCode { get; set; }

    public string? ContactPobox { get; set; }

    public string? ContactAddress { get; set; }

    public string? ContactEmailAddress { get; set; }

    public int? Religion { get; set; }

    public int? MaritalStatus { get; set; }

    public string? Hobbies { get; set; }

    public int? IsMobileVerified { get; set; }

    public int? IsEmailVerified { get; set; }

    public int? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public virtual TblSsaApplicationUser User { get; set; } = null!;
}
