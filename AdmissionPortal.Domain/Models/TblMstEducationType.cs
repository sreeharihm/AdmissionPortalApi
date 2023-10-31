using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstEducationType
{
    public int EducationTypeRecId { get; set; }

    public string EducationTypeEngName { get; set; } = null!;

    public string? EducationTypeLocalName { get; set; }

    public string? EducationTypeCode { get; set; }

    public bool? EducationTypeStatus { get; set; }

    public int? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
