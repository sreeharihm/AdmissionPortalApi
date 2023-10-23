using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstVisaMaster
{
    public int VisaTypeRecId { get; set; }

    public string VisaTypeEngName { get; set; } = null!;

    public string? VisaTypeLocalName { get; set; }

    public string? VisaTypeCode { get; set; }

    public bool? VisaTypeStatus { get; set; }

    public int InsertBy { get; set; }

    public DateTime InsertDateTime { get; set; }

    public int? AmendBy { get; set; }

    public DateTime? AmendDateTime { get; set; }
}
