using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstStudentTypeMaster
{
    public int StudentTypeRecId { get; set; }

    public string StudentTypeCode { get; set; } = null!;

    public string StudentTypeEngName { get; set; } = null!;

    public string StudentTypeLocalName { get; set; } = null!;

    public int NextStudentTypeRecId { get; set; }

    public bool SystemRequiered { get; set; }

    public bool? StudentTypeStatus { get; set; }

    public int InsertBy { get; set; }

    public DateTime InsertDateTime { get; set; }

    public int? AmendBy { get; set; }

    public DateTime? AmendDateTime { get; set; }
}
