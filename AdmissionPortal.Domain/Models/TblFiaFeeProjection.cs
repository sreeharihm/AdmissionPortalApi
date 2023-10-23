using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblFiaFeeProjection
{
    public int? RecId { get; set; }

    public string? StudentId { get; set; }

    public int? ProgramYear { get; set; }

    public int? ProgramLevel { get; set; }

    public int? ProgramId { get; set; }

    public double? TutionFee { get; set; }

    public string? Status { get; set; }

    public int? SponsorPercentageAmount { get; set; }

    public int? StudentPercentageAmount { get; set; }

    public int? CollegePercentageAmount { get; set; }

    public int? PaybleAmount { get; set; }

    public int? FinlaVatamont { get; set; }

    public int? TotalAmount { get; set; }

    public int? TermSem { get; set; }

    public int? TermCode { get; set; }

    public string? TermName { get; set; }

    public string? Issponsor { get; set; }

    public double? Balance { get; set; }

    public double? Sumtotal { get; set; }

    public double? TotalAmountWithBalance { get; set; }

    public double? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LastUpdatedDateTime { get; set; }
}
