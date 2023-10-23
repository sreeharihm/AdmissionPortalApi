using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstNotificationsMaster
{
    public int? NotificationId { get; set; }

    public int? NotificationTypeId { get; set; }

    public string? SubjectEng { get; set; }

    public string? SubjectLocal { get; set; }

    public string? ContentEng { get; set; }

    public string? ContentLocal { get; set; }

    public int? FromUser { get; set; }

    public int? ToUser { get; set; }

    public DateTime? SentDateTime { get; set; }

    public DateTime? ReadDateTime { get; set; }

    public bool? IsRead { get; set; }

    public bool? IsDelete { get; set; }

    public int? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }
}
