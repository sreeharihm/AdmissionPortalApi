using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstNotifcationsType
{
    public int? NotificationTypeId { get; set; }

    public string? TypeNameEng { get; set; }

    public string? TypeNameLocal { get; set; }

    public string? Color { get; set; }

    public int? Status { get; set; }

    public int? InsertBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public int? LastUpdaetdBy { get; set; }

    public DateTime? LastUpdaetdDateTime { get; set; }
}
