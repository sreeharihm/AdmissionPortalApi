using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstRecordStatus
{
    public int RecordStatusRecId { get; set; }

    public string RecordStatusLocalName { get; set; } = null!;

    public string RecordStatusEngName { get; set; } = null!;

    public int InsertBy { get; set; }

    public DateTime InsertDateTime { get; set; }

    public int? AmendBy { get; set; }

    public DateTime? AmendDateTime { get; set; }
}
