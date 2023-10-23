using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstGradingDefintion
{
    public int GradeDefinitionId { get; set; }

    public string? GradeCodeEng { get; set; }

    public string? CourseGradeEngName { get; set; }

    public string? CourseGradeLocalName { get; set; }

    public string? GradeCodeLocal { get; set; }

    public int? Points { get; set; }

    public int? MarksStartFrom { get; set; }

    public int? MarksEndTo { get; set; }

    public int? EffectiveFromTerm { get; set; }

    public int? EffectiveToTerm { get; set; }

    public int? InsertBy { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public string? GradeClass { get; set; }
}
