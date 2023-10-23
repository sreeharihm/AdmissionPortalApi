using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmByTermAdmissionCriteria
{
    public int TermCriteriaRecId { get; set; }

    public int? AdmissionScheduleRecId { get; set; }

    public int? CriteriasMasterRecId { get; set; }

    public string? CriteriaLocalName { get; set; }

    public string? CriteriaEngName { get; set; }

    public int? CriteriaGroupRecId { get; set; }

    public int? CriteriaMinimum { get; set; }

    public int? CriteriaMaxmum { get; set; }

    public int? CriteriaWeightage { get; set; }

    public string? CriteriaLocalRemarks { get; set; }

    public string? CriteriaEngRemarks { get; set; }

    public int? CriteriaTypeRecId { get; set; }

    public string? CriteriaType { get; set; }

    public string? GraduationCountry { get; set; }

    public int? CriteriaDisplayOrder { get; set; }

    public int? CriteriaGender { get; set; }

    public bool? CriteriaForCitizen { get; set; }

    public bool? CriteriaForNonCitizen { get; set; }

    public string? Condition { get; set; }

    public int? CriteriaValidityDays { get; set; }

    public string? CriteriaStatus { get; set; }

    public int? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public virtual TblAdmMasterAdmissionCriteria? CriteriasMasterRec { get; set; }

    public virtual ICollection<TblAdmApplicantAdmissionCriteria> TblAdmApplicantAdmissionCriteria { get; set; } = new List<TblAdmApplicantAdmissionCriteria>();
}
