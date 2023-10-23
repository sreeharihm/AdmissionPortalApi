using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstOrganazationMaster
{
    public int OrganizationRecId { get; set; }

    public int? OrganazationCatogeryRecId { get; set; }

    public string? OrganizationEngName { get; set; }

    public string? OrganizationLocalName { get; set; }

    public string? OrganizationCodeEng { get; set; }

    public string? OrganizationCodeLocal { get; set; }

    public int? OrganizationCountry { get; set; }

    public int? OrganizationType { get; set; }

    public int? OrganizationStatus { get; set; }

    public int? InsertBy { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
