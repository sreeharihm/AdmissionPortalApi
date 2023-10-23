using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmMasterAdmissionChecklist
{
    public int ChecklistRecId { get; set; }

    public string ChecklistEngName { get; set; } = null!;

    public string ChecklistLoalName { get; set; } = null!;

    public bool ChecklistIsMandatory { get; set; }

    public string ChecklistNotesEng { get; set; } = null!;

    public string ChecklistNotesLocal { get; set; } = null!;

    public int CheklistTypeRecId { get; set; }

    public bool? ChecklistStatus { get; set; }

    public bool? IsMedicalReport { get; set; }

    public DateTime EffectiveFrom { get; set; }

    public DateTime EffectiveTo { get; set; }

    public int InsertedBy { get; set; }

    public DateTime InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public virtual TblMstCheklistTypeMaster CheklistTypeRec { get; set; } = null!;

    public virtual ICollection<TblAdmByTermAdmissionChecklist> TblAdmByTermAdmissionChecklists { get; set; } = new List<TblAdmByTermAdmissionChecklist>();
}
