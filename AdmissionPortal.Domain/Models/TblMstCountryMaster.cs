using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstCountryMaster
{
    public int CountryRecId { get; set; }

    public string? CountryName { get; set; }

    public string? CountryCode { get; set; }

    public string? CountryNameLocal { get; set; }

    public string? Moecode { get; set; }

    public string? NationalityEngName { get; set; }

    public string? NationalityLocalName { get; set; }

    public string? Idpattern { get; set; }

    public bool? IsArabCountry { get; set; }

    public string? CountryIdstartsNo { get; set; }

    public bool? IslocalCountry { get; set; }

    public int? InsertBy { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public int? AmendBy { get; set; }

    public DateTime? AmendDateTime { get; set; }

    public virtual ICollection<TblAdmApplicantEducationalInformation> TblAdmApplicantEducationalInformations { get; set; } = new List<TblAdmApplicantEducationalInformation>();
}
