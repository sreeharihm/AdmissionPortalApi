using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmMasterAdmissionCriteria
{
    public int CriteriasMasterRecId { get; set; }

    public string CriteriaLocalName { get; set; } = null!;

    public string? CriteriaEngName { get; set; }

    public int? AdmissionCriteriaGroupRecId { get; set; }

    public bool? CriteriaStatus { get; set; }

    public string? CriteriaLocalRemarks { get; set; }

    public string? CriteriaEngRemarks { get; set; }

    public int? CriteriaGender { get; set; }

    public bool? CriteriaforCitizen { get; set; }

    public bool? CriteriaforNonCitizen { get; set; }

    public int? ValidityYears { get; set; }

    public DateTime? EffectiveFrom { get; set; }

    public DateTime? EffectiveTo { get; set; }

    public int InsertedBy { get; set; }

    public DateTime InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public virtual TblAdmMasterAdmissionCriteriaGroup? AdmissionCriteriaGroupRec { get; set; }

    public virtual ICollection<TblAdmByTermAdmissionCriteria> TblAdmByTermAdmissionCriteria { get; set; } = new List<TblAdmByTermAdmissionCriteria>();
}
