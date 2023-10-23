using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstDegreeTypeMaster
{
    public int DegreeTypeRecId { get; set; }

    public string? DegreeTypeEngName { get; set; }

    public string? DegreeTypeLocalName { get; set; }

    public string? DegreeTypelocalDescription { get; set; }

    public string? DegreeTypePreRequisites { get; set; }

    public string? DegreeTypeEngDescription { get; set; }

    public string? DegreeTypeCode { get; set; }

    public bool IsDegreeTypeInternalDegree { get; set; }

    public string? Mohecode { get; set; }

    public int? DegreeStatus { get; set; }

    public int InsertBy { get; set; }

    public DateTime InsertDateTime { get; set; }

    public int? AmendBy { get; set; }

    public DateTime? AmendDateTime { get; set; }

    public virtual ICollection<TblAdmApplicantApplicationMaster> TblAdmApplicantApplicationMasters { get; set; } = new List<TblAdmApplicantApplicationMaster>();

    public virtual ICollection<TblAdmByTermAdmissionPreference> TblAdmByTermAdmissionPreferences { get; set; } = new List<TblAdmByTermAdmissionPreference>();

    public virtual ICollection<TblAdmByTermAdmissionSchedule> TblAdmByTermAdmissionSchedules { get; set; } = new List<TblAdmByTermAdmissionSchedule>();
}
