using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstAttendanceMethod
{
    public int AttendanceMethodRecId { get; set; }

    public string? AttendanceMethodName { get; set; }

    public string? AttendanceMethodLocalName { get; set; }

    public int? Status { get; set; }

    public int? InsertBy { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public double? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
