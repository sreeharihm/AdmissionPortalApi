using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstStudyCenterMaster
{
    public int? StudyCenterRecId { get; set; }

    public string? StudyCenterEngName { get; set; }

    public string? StudyCenterLocalName { get; set; }

    public int? CityRecId { get; set; }

    public int? StudyCenterCode { get; set; }

    public string? StudyCenterDescEng { get; set; }

    public string? StudyCenterDescLocal { get; set; }

    public int? StudyCenterStatus { get; set; }

    public string? StudyCenterType { get; set; }

    public string? StudyCenterExternalCode { get; set; }

    public int? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
