using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmDepartmentMaster
{
    public int DepartmentId { get; set; }

    public string? DepartmentEngName { get; set; }

    public string? DepartmentLocalName { get; set; }

    public string? DepartmentShortNameEng { get; set; }

    public string? DepartmentShortNameLocal { get; set; }

    public int? IsItSharedDepartment { get; set; }

    public string? DepartmenImage { get; set; }

    public int? DepartmentStatus { get; set; }

    public string? DepartmentCode { get; set; }

    public string? DepartmentCampus { get; set; }

    public int InsertBy { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public int AmendBy { get; set; }

    public DateTime? AmendDateTime { get; set; }
}
