using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstCollegeGrading
{
    public int CollegeGradeId { get; set; }

    public string? GradeEngName { get; set; }

    public string? GradeLocalName { get; set; }

    public int? MaxValueForValidation { get; set; }

    public int? MinValueForValidation { get; set; }

    public int? GardingStatus { get; set; }

    public string? InsertBy { get; set; }

    public string? InsertDateTime { get; set; }

    public string? AmendBy { get; set; }

    public string? AmendDateTime { get; set; }

    public int? InsertBy1 { get; set; }

    public DateTime? InsertDateTime1 { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
