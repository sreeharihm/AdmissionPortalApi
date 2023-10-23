using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstReligionMaster
{
    public int MinstryCode { get; set; }

    public string EnglishDescription { get; set; } = null!;

    public string? ArabicDescription { get; set; }

    public bool? ReligionStatus { get; set; }

    public int InsertBy { get; set; }

    public DateTime InsertDateTime { get; set; }

    public int? AmendBy { get; set; }

    public DateTime? AmendDateTime { get; set; }
}
