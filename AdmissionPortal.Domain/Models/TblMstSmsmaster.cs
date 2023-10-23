using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstSmsmaster
{
    public int SmsRecId { get; set; }

    public int? ApplicationStatusTypeRecId { get; set; }

    public string? SmsengText { get; set; }

    public string? SmslocalText { get; set; }

    public int? SmsStatus { get; set; }

    public int InsertBy { get; set; }

    public DateTime InsertDateTime { get; set; }

    public int? AmendBy { get; set; }

    public DateTime? AmendDateTime { get; set; }
}
