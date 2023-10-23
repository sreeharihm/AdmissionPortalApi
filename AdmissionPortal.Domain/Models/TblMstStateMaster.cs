using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstStateMaster
{
    public int StateRecId { get; set; }

    public string StateName { get; set; } = null!;

    public string? StateNameLocal { get; set; }

    public string? StateCode { get; set; }

    public int? CountryRecId { get; set; }

    public int? StateExternalCode { get; set; }

    public bool? StateStatus { get; set; }

    public int InsertBy { get; set; }

    public DateTime InsertDateTime { get; set; }

    public int? AmendBy { get; set; }

    public DateTime? AmendDateTime { get; set; }
}
