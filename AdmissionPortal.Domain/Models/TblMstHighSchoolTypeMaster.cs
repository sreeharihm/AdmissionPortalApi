using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstHighSchoolTypeMaster
{
    public int HighSchoolTypeRecId { get; set; }

    public string HighSchoolTypeEnName { get; set; } = null!;

    public bool? IsDelete { get; set; }

    public bool? HighSchoolTypeStatus { get; set; }

    public string? HighSchoolTypeLocalName { get; set; }

    public int InsertBy { get; set; }

    public DateTime InsertDateTime { get; set; }

    public int? AmendBy { get; set; }

    public DateTime? AmendDateTime { get; set; }
}
