using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstCampusMaster
{
    public int CampusRecId { get; set; }

    public string? CampusEngName { get; set; }

    public string? CampusLocalName { get; set; }

    public string? CampusCode { get; set; }

    public string? CampusType { get; set; }

    public int? CampusCountry { get; set; }

    public int? CampusState { get; set; }

    public int? CampusCity { get; set; }

    public string? CampusAddressEng { get; set; }

    public string? CampusAddressLocal { get; set; }

    public int? CampusStatus { get; set; }

    public int? InsertBy { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public virtual ICollection<TblMstCollege> TblMstColleges { get; set; } = new List<TblMstCollege>();
}
