using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblSsaRoleMaster
{
    public int RoleRecId { get; set; }

    public int? RoleCategoryId { get; set; }

    public string RoleNameEnglish { get; set; } = null!;

    public string? RoleNameLocal { get; set; }

    public string? RoleDescEnglish { get; set; }

    public string? RoleDescLocal { get; set; }

    public bool? IsOtpreqForLogin { get; set; }

    public bool? RollStatus { get; set; }

    public int InsertBy { get; set; }

    public DateTime InsertDateTime { get; set; }

    public DateTime? AmendDateTime { get; set; }

    public int? AmendBy { get; set; }

    public virtual ICollection<TblSsaUserRole> TblSsaUserRoles { get; set; } = new List<TblSsaUserRole>();

    public virtual ICollection<TblSsaUserRolesCapability> TblSsaUserRolesCapabilities { get; set; } = new List<TblSsaUserRolesCapability>();
}
