using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmProgramStructure
{
    public int ProgramStructureId { get; set; }

    public int ProgramRecId { get; set; }

    public int SemesterOrder { get; set; }

    public int Psyear { get; set; }

    public int Pslevel { get; set; }

    public bool? SemeterStatus { get; set; }

    public bool? ForDegreeCompletion { get; set; }

    public bool? ForProgramCompletion { get; set; }

    public int? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
