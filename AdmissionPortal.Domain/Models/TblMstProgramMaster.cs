using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstProgramMaster
{
    public int ProgramRecId { get; set; }

    public int MajorRecId { get; set; }

    public string ProgramEngName { get; set; } = null!;

    public string? ProgramLocalName { get; set; }

    public string? ProgramShortDisplayEng { get; set; }

    public string? ProgramShortDisplayLocal { get; set; }

    public string ProgramCode { get; set; } = null!;

    public int? DegreeRecId { get; set; }

    public string? MajorId { get; set; }

    public string? CampusRecId { get; set; }

    public int? OldProgramRecId { get; set; }

    public string? ProgramDurationInYears { get; set; }

    public string? ProgramDurationInSemesters { get; set; }

    public string? ProgramDurationInRebatYears { get; set; }

    public bool? ProgramStatus { get; set; }

    public int? ProgramFodid { get; set; }

    public string? ExternalCollegeCode { get; set; }

    public string? ExternaMajorCode { get; set; }

    public string? ExternaStudyTypeCode { get; set; }

    public string? ExternaSascedp { get; set; }

    public int? ExternaSascedl { get; set; }

    public string? ProgramColor { get; set; }

    public bool? AccpetAdmissionIfEnglishTestPass { get; set; }

    public bool? AcceptAdmissionIfEnglishTestFail { get; set; }

    public int InsertBy { get; set; }

    public DateTime InsertDateTime { get; set; }

    public int? AmendBy { get; set; }

    public DateTime? AmendDateTime { get; set; }
}
