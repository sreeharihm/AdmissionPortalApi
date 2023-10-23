using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblFiaProgramFeeStructure
{
    public int ProgramFeeId { get; set; }

    public int Ayid { get; set; }

    public int ProgramRecId { get; set; }

    public int ProgramYear { get; set; }

    public int ProgramLevel { get; set; }

    public decimal SemesterFee { get; set; }

    public int NoOfInstallments { get; set; }

    public bool? IsVatIncluded { get; set; }

    public int? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
