using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstErrorMessageMaster
{
    public int ErrorMessageRecId { get; set; }

    public string ErrorMessageCode { get; set; } = null!;

    public string ErrorMessageEng { get; set; } = null!;

    public string? ErrorMessageLocalName { get; set; }

    public bool? ErrorMessageStatus { get; set; }

    public int InsertBy { get; set; }

    public DateTime InsertDateTime { get; set; }

    public int? AmendBy { get; set; }

    public DateTime? AmendDateTime { get; set; }
}
