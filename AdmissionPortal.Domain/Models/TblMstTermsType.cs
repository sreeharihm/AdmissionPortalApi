using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstTermsType
{
    public int TermTypeRecId { get; set; }

    public string? TermTypeEngName { get; set; }

    public string? TermTypeLocalName { get; set; }

    public int? TermTypeCode { get; set; }

    public int? NumberOfWeeks { get; set; }

    public int? AattendanceWeeks { get; set; }

    public int? InsertBy { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
