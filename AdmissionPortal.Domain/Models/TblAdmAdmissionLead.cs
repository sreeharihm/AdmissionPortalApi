using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmAdmissionLead
{
    public int AdmissionLeadRecId { get; set; }

    public string? ProgramOfIntrest { get; set; }

    public int? ProgramOfIntrestId { get; set; }

    public string? FullName { get; set; }

    public string? NationalId { get; set; }

    public string? EmailId { get; set; }

    public string? MobileNumber { get; set; }

    public DateTime? InsertedDate { get; set; }
}
