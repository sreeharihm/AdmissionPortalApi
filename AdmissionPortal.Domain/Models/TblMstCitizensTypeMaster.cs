using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstCitizensTypeMaster
{
    public int CitizensTypeRecId { get; set; }

    public string CitizensTypeEngName { get; set; } = null!;

    public string? CitizensTypeLocalName { get; set; }

    public bool? CitizensTypeStatus { get; set; }

    public int InsertBy { get; set; }

    public DateTime InsertDateTime { get; set; }

    public int? AmendBy { get; set; }

    public DateTime? AmendDateTime { get; set; }
}
