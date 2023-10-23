using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstApplicationStatus
{
    public int ApplicationStatusRecId { get; set; }

    public string? ActionNameEng { get; set; }

    public string? ActionNameLocal { get; set; }

    public int? ActionSequance { get; set; }

    public string? NextActionSequanceOne { get; set; }

    public string? NextActionOperator { get; set; }

    public string? NextActionSequanceTwo { get; set; }

    public bool? SendSms { get; set; }

    public bool? SendEmail { get; set; }

    public string? NotifyUserRol { get; set; }

    public string? ActionByUserRol { get; set; }

    public int? PushNotification { get; set; }

    public string? ActionRequieredDays { get; set; }

    public int? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public virtual ICollection<TblAdmApplicantApplicationMasterDetail> TblAdmApplicantApplicationMasterDetails { get; set; } = new List<TblAdmApplicantApplicationMasterDetail>();

    public virtual ICollection<TblAdmApplicantApplicationMaster> TblAdmApplicantApplicationMasters { get; set; } = new List<TblAdmApplicantApplicationMaster>();
}
