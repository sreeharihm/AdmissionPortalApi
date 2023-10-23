using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblSsaApplicationUser
{
    public int UserId { get; set; }

    public string? Prefix { get; set; }

    public byte[]? ProfilePic { get; set; }

    public string? FirstNameEng { get; set; }

    public string? FirstNameLocal { get; set; }

    public string? FatherNameEng { get; set; }

    public string? FatherNameLocal { get; set; }

    public string? GrandFatherNameEng { get; set; }

    public string? GrandFatherNameLocal { get; set; }

    public string? LastNameEng { get; set; }

    public string? LastNameLocal { get; set; }

    public string? Nationality { get; set; }

    public string? NationalId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public string? UserType { get; set; }

    public int? UserStatus { get; set; }

    public string? EmailAddress { get; set; }

    public string? Mobile { get; set; }

    public int? IsPasswordExpired { get; set; }

    public int? Isrequriedupdate { get; set; }

    public string? AltranateUserName { get; set; }

    public string? ProfilePin { get; set; }

    public DateTime? ProfilePinupdatedDate { get; set; }

    public DateTime? ProfilePinexpiryDate { get; set; }

    public int? PrefferedLanguage { get; set; }

    public bool? Gender { get; set; }

    public bool? GuidelinesAcknowledged { get; set; }

    public bool? TermsAcknowledged { get; set; }

    public int? InsertedBy { get; set; }

    public DateTime InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public virtual ICollection<TblAdmApplicantApplicationMaster> TblAdmApplicantApplicationMasters { get; set; } = new List<TblAdmApplicantApplicationMaster>();

    public virtual ICollection<TblAdmApplicantPersonalInformation> TblAdmApplicantPersonalInformations { get; set; } = new List<TblAdmApplicantPersonalInformation>();

    public virtual ICollection<TblSsaUserRole> TblSsaUserRoles { get; set; } = new List<TblSsaUserRole>();
}
