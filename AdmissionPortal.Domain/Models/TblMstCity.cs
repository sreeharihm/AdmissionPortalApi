using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstCity
{
    public int CityId { get; set; }

    public string? CityName { get; set; }

    public string? CityNameLocal { get; set; }

    public int? CountryId { get; set; }

    public int? ProvinceId { get; set; }

    public int? Code { get; set; }

    public bool? Status { get; set; }

    public int? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
