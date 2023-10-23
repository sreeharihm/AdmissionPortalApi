using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmMajorMaster
{
    public int MajorRecId { get; set; }

    public string MajorEngName { get; set; } = null!;

    public string MajorLocalName { get; set; } = null!;

    public bool? MajorStatus { get; set; }

    public int? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
