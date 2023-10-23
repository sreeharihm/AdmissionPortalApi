using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmMasterAdmissionCriteriaType
{
    public int CriteriaTypeRecId { get; set; }

    public string CriteriaTypeLocalName { get; set; } = null!;

    public string CriteriaTypeEngName { get; set; } = null!;

    public bool CriteriaTypeStatus { get; set; }

    public int InsertedBy { get; set; }

    public DateTime InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
