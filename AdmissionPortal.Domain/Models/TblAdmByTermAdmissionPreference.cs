using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmByTermAdmissionPreference
{
    public int ProgramPreferenceRecId { get; set; }

    public int? TermId { get; set; }

    public int? DegreeTypeRecId { get; set; }

    public int? AdmissionTypeRecId { get; set; }

    public int? ProgramRecId { get; set; }

    public bool? Status { get; set; }

    public int InsertedBy { get; set; }

    public DateTime InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public virtual TblMstAdmissionTypeMaster? AdmissionTypeRec { get; set; }

    public virtual TblMstDegreeTypeMaster? DegreeTypeRec { get; set; }

    public virtual TblRegTermMaster? Term { get; set; }
}
