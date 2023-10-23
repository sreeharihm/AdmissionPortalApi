using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstAutoNotification
{
    public int AutoNotificationRecId { get; set; }

    public string? ApplicationsStatusRecId { get; set; }

    public string? SmsmessageEng { get; set; }

    public string? EmailMessageEng { get; set; }

    public string? WhatsappMessageEng { get; set; }

    public string? SmsmessageLocal { get; set; }

    public string? EmailMessageLocal { get; set; }

    public string? WhatsappMessageLocal { get; set; }
}
