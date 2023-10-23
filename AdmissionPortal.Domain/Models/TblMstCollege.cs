using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstCollege
{
    public int CollegeRecId { get; set; }

    public int CampusRecId { get; set; }

    public string? CollegeEngName { get; set; }

    public string? CollegeCode { get; set; }

    public string? CollegeLocalName { get; set; }

    public string? CollegeCityEngName { get; set; }

    public string? CollegeCityLocalName { get; set; }

    public string? CollegeType { get; set; }

    public string? CollegeLocallanguage { get; set; }

    public string? CollegeCareer { get; set; }

    public int? CollegeStatus { get; set; }

    public int? InsertBy { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public virtual TblMstCampusMaster CampusRec { get; set; } = null!;
}
