using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmMasterAdmissionCriteriaGroup
{
    public int AdmissionCriteriaGroupRecId { get; set; }

    public string CriteriaGroupLocalName { get; set; } = null!;

    public string CriteriaGroupEngName { get; set; } = null!;

    public bool? CriteriaGroupStatus { get; set; }

    public int InsertedBy { get; set; }

    public DateTime InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public virtual ICollection<TblAdmMasterAdmissionCriteria> TblAdmMasterAdmissionCriteria { get; set; } = new List<TblAdmMasterAdmissionCriteria>();
}
