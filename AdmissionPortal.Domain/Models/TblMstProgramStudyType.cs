using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstProgramStudyType
{
    public int ProgramStudyTypeRecId { get; set; }

    public int? ProgramStudyTypeNumber { get; set; }

    public string? ProgramStudyTypeIndicator { get; set; }

    public int? ProgramStudyTypeIndicatorInWeeks { get; set; }

    public string? Indicator { get; set; }

    public bool? SummertobeIncluded { get; set; }

    public string? ProgramStudyTypeLocalName { get; set; }

    public int? InsertBy { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
