using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstAttendanceComponent
{
    public int? AttendanceComponentRecId { get; set; }

    public string? ComponenetCode { get; set; }

    public string? ComponenetEngName { get; set; }

    public string? ComponenetLocalName { get; set; }

    public int? ComponenetStatus { get; set; }

    public int? InsertBy { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
