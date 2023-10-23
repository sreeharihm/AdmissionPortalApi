using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstAdmissionTypeMaster
{
    public int AdmissionTypeRecId { get; set; }

    public string AdmissionTypeEngName { get; set; } = null!;

    public string? AdmissionTypeLocalName { get; set; }

    public bool? AdmissionTypeStatus { get; set; }

    public int? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public virtual ICollection<TblAdmApplicantApplicationMaster> TblAdmApplicantApplicationMasters { get; set; } = new List<TblAdmApplicantApplicationMaster>();

    public virtual ICollection<TblAdmByTermAdmissionPreference> TblAdmByTermAdmissionPreferences { get; set; } = new List<TblAdmByTermAdmissionPreference>();

    public virtual ICollection<TblAdmByTermAdmissionSchedule> TblAdmByTermAdmissionSchedules { get; set; } = new List<TblAdmByTermAdmissionSchedule>();
}
