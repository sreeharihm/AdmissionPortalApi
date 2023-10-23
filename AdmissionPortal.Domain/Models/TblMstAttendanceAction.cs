using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstAttendanceAction
{
    public int GradingDefintionActionRecId { get; set; }

    public string? GradingDefintionActionEngName { get; set; }

    public string? GradingDefintionActionLocalName { get; set; }

    public int? Score { get; set; }

    public string? GradeCodeEng { get; set; }

    public int? Satus { get; set; }

    public string? GradeClass { get; set; }

    public int? InsertBy { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
