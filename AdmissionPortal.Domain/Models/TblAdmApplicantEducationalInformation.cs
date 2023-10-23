using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmApplicantEducationalInformation
{
    public int EducationalInformationRecIdid { get; set; }

    public int? ApplicationRecId { get; set; }

    public string? SchoolName { get; set; }

    public int? CountryRecId { get; set; }

    public string? ProvinceName { get; set; }

    public string? CityName { get; set; }

    public string? StudyCenterName { get; set; }

    public int? GraduationYear { get; set; }

    public string? CertificateType { get; set; }

    public string? GradeType { get; set; }

    public string? Grade { get; set; }

    public string? ExternalCode { get; set; }

    public int? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public virtual TblAdmApplicantApplicationMaster? ApplicationRec { get; set; }

    public virtual TblMstCountryMaster? CountryRec { get; set; }
}
