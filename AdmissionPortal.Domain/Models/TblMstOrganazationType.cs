using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstOrganazationType
{
    public double? RecId { get; set; }

    public string? OrganazationTypeEngName { get; set; }

    public string? OrganazationTypeLocalName { get; set; }

    public double? OrganazationTypeStatus { get; set; }

    public double? InsertBy { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public double? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
