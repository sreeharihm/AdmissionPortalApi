using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmApplicantAdmissionCriteria
{
    public int ApplicantByTermCriteriaRecId { get; set; }

    public int ApplicationRecId { get; set; }

    public int TermCriteriaRecId { get; set; }

    public string CriteriaMinimum { get; set; } = null!;

    public string? CriteriaMaxmum { get; set; }

    public string CriteriaWeightage { get; set; } = null!;

    public string? CriteriaDocuments { get; set; }

    public string? CriteriaRemarks { get; set; }

    public int? CriteriaDisplayOrder { get; set; }

    public int? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public virtual TblAdmApplicantApplicationMaster ApplicationRec { get; set; } = null!;

    public virtual TblAdmByTermAdmissionCriteria TermCriteriaRec { get; set; } = null!;
}
