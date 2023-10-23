using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstCheklistTypeMaster
{
    public int CheklistTypeRecId { get; set; }

    public string CheklistTypeEngName { get; set; } = null!;

    public string CheklistTypeLocalName { get; set; } = null!;

    public int? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public virtual ICollection<TblAdmMasterAdmissionChecklist> TblAdmMasterAdmissionChecklists { get; set; } = new List<TblAdmMasterAdmissionChecklist>();
}
