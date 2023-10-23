using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstFeeTypeMaster
{
    public int? FeeTypeMasterId { get; set; }

    public string? FeeTypeTitle { get; set; }

    public string? FeeTypeTitleLocal { get; set; }

    public int? MinOnlinepayment { get; set; }

    public int? MaxOnlinepayment { get; set; }

    public int? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
