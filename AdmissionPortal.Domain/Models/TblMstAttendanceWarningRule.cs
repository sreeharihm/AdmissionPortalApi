using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstAttendanceWarningRule
{
    public int WarningRecId { get; set; }

    public int? WarningOrder { get; set; }

    public int? AbsentPercentFrom { get; set; }

    public int? AbsentPercentTo { get; set; }

    public int? CheckOffsetDays { get; set; }

    public string? WarningColor { get; set; }

    public bool? FollowedByGrade { get; set; }

    public string? GradeLetter { get; set; }

    public string? IncludeExecuseRequestInFormula { get; set; }

    public string? Formula { get; set; }

    public int? IsActive { get; set; }

    public int? InsertBy { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
