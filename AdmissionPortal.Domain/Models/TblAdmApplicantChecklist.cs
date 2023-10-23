using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmApplicantChecklist
{
    public int ApplicantChecklistByTermRecId { get; set; }

    public int ApplicationRecId { get; set; }

    public int ChecklistByTermRecId { get; set; }

    public byte[]? ChecklistAttachments { get; set; }

    public bool? ChecklistStatus { get; set; }

    public int? DisplayOrder { get; set; }

    public int InsertedBy { get; set; }

    public DateTime InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public virtual TblAdmApplicantApplicationMaster ApplicationRec { get; set; } = null!;

    public virtual TblAdmByTermAdmissionChecklist ChecklistByTermRec { get; set; } = null!;
}
