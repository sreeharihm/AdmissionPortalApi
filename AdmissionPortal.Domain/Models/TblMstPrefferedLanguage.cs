using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstPrefferedLanguage
{
    public int PrefferedLanguageRecId { get; set; }

    public string PrefferedLanguageEngName { get; set; } = null!;

    public string PrefferedLanguageLocalName { get; set; } = null!;

    public bool? PrefferedLanguageStatus { get; set; }

    public int InsertBy { get; set; }

    public DateTime InsertDateTime { get; set; }

    public int? AmendBy { get; set; }

    public DateTime? AmendDateTime { get; set; }
}
