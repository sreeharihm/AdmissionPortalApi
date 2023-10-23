using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmByTermAdmissionChecklist
{
    public int ChecklistByTermRecId { get; set; }

    public int? AdmissionScheduleRecId { get; set; }

    public int? ChecklistRecId { get; set; }

    public string? ChecklistEngName { get; set; }

    public string? ChecklistLocalName { get; set; }

    public bool? ChecklistIsMandatory { get; set; }

    public string? ChecklistNotesEng { get; set; }

    public string? ChecklistNotesLocal { get; set; }

    public bool? ChecklistIsForLocals { get; set; }

    public bool? ChecklistIsForNonLocals { get; set; }

    public int? ChecklistGender { get; set; }

    public int? ChecklistAttachments { get; set; }

    public bool? IsChecklistSpecial { get; set; }

    public string? GraduationCountry { get; set; }

    public bool? ChecklistStatus { get; set; }

    public int? DisplayOrder { get; set; }

    public DateTime? EffectiveFrom { get; set; }

    public DateTime? EffectiveTo { get; set; }

    public double? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public string? LastUpdatedBy { get; set; }

    public string? LastUpdatedDateTime { get; set; }

    public virtual TblAdmMasterAdmissionChecklist? ChecklistRec { get; set; }

    public virtual ICollection<TblAdmApplicantChecklist> TblAdmApplicantChecklists { get; set; } = new List<TblAdmApplicantChecklist>();
}
