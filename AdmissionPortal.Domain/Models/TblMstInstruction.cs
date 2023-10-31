using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstInstruction
{
    public int InstructionsRecId { get; set; }

    public string? InstructionsEng { get; set; }

    public string? InstructionsLocal { get; set; }

    public string? InstructionsType { get; set; }

    public int? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
