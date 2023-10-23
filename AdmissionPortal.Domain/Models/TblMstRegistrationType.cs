using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstRegistrationType
{
    public int? RegistrationTypeRecId { get; set; }

    public string? RegistrationEngNameType { get; set; }

    public string? RegistrationLocalNameType { get; set; }

    public int? RegistrationTypeStatus { get; set; }

    public int? InsertedBy { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
