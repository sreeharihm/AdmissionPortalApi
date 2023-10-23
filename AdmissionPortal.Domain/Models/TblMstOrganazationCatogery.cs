using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstOrganazationCatogery
{
    public int? OrganazationCatogeryRecId { get; set; }

    public string? CareerTypeEngName { get; set; }

    public string? CareerTypeLocalName { get; set; }

    public int? CareerTypeStatus { get; set; }

    public int? InsertBy { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
