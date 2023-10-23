using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmApplicantApplicationMasterDetail
{
    public int ApplicationDetailsRecId { get; set; }

    public int ApplicationRecId { get; set; }

    public int ApplicationStatusRecId { get; set; }

    public DateTime? ApplicationStatusUpdateDate { get; set; }

    public string? ApplicationStep { get; set; }

    public DateTime? ApplicationStepDate { get; set; }

    public string? ApplicationNextStep { get; set; }

    public DateTime? ApplicationNextStepDate { get; set; }

    public int InsertedBy { get; set; }

    public DateTime InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public virtual TblMstApplicationStatus ApplicationStatusRec { get; set; } = null!;
}
