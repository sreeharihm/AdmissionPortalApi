using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblRegAcademicYear
{
    public int AcademicYearRecId { get; set; }

    public int AystartYear { get; set; }

    public int AyendYear { get; set; }

    public string? AystartYearLocal { get; set; }

    public string? AyendYear1Local { get; set; }

    public DateTime? AystartDate { get; set; }

    public DateTime? AyendDate { get; set; }

    public bool? Aystatus { get; set; }

    public bool IsAyeventCopied { get; set; }

    public int InsertBy { get; set; }

    public DateTime InsertDateTime { get; set; }

    public int? AmendBy { get; set; }

    public DateTime? AmendDateTime { get; set; }

    public virtual ICollection<TblAdmApplicantApplicationMaster> TblAdmApplicantApplicationMasters { get; set; } = new List<TblAdmApplicantApplicationMaster>();

    public virtual ICollection<TblAdmByTermAdmissionSchedule> TblAdmByTermAdmissionSchedules { get; set; } = new List<TblAdmByTermAdmissionSchedule>();
}
