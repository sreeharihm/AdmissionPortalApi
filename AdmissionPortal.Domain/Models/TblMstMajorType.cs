using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstMajorType
{
    public int MajorTypeRecId { get; set; }

    public string? MajorTypeEngName { get; set; }

    public string? MajorTypeLocalName { get; set; }

    public int? MajorTypeStatus { get; set; }

    public int? InsertBy { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
