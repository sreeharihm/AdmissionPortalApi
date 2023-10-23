using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstAddressTypeMaster
{
    public int AddressTypeRecId { get; set; }

    public string AddressTypeEngName { get; set; } = null!;

    public string AddressTypeLocalName { get; set; } = null!;

    public string? AddressTypeDescriptionEngName { get; set; }

    public string? AddressTypeDescriptionLocalName { get; set; }

    public bool IsAddressTypeRequiered { get; set; }

    public bool AddressTypeStatus { get; set; }

    public int? DisplayOrder { get; set; }

    public int? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
