using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmApplicantPreferenceInformation
{
    public int ApplicationPreferenceRecId { get; set; }

    public int ApplicationRecId { get; set; }

    public int ProgramPreferenceRecId { get; set; }

    public int? ProgramPreferenceSequence { get; set; }

    public bool? ProgramPreferenceConfiramtionStatus { get; set; }

    public DateTime? ProgramPreferenceConfiramtionDate { get; set; }

    public int InsertBy { get; set; }

    public DateTime InsertDateTime { get; set; }

    public int? AmendBy { get; set; }

    public DateTime? AmendDateTime { get; set; }

    public virtual TblAdmApplicantApplicationMaster ApplicationRec { get; set; } = null!;
}
