using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblSsaUserRolesCapability
{
    public int UserRolesCapabilityRecId { get; set; }

    public int? CapabilityRecId { get; set; }

    public bool? UserRolesCapabilityStatus { get; set; }

    public int? RoleRecId { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public short? InsertBy { get; set; }

    public DateTime? AmendDateTime { get; set; }

    public short? AmendBy { get; set; }

    public virtual TblSsaCapabilityMaster? CapabilityRec { get; set; }

    public virtual TblSsaRoleMaster? RoleRec { get; set; }

    public virtual ICollection<TblSsaUserRolesCapabilityControl> TblSsaUserRolesCapabilityControls { get; set; } = new List<TblSsaUserRolesCapabilityControl>();
}
