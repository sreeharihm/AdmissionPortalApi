using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblSsaUserRolesCapabilityControl
{
    public int UserRoleCapabilityControlRecId { get; set; }

    public int? UserRolesCapabilityRecId { get; set; }

    public int? CapabilityControlsRecId { get; set; }

    public bool? UserRoleCapabilityControlStatus { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public short? InsertBy { get; set; }

    public DateTime? AmendDateTime { get; set; }

    public short? AmendBy { get; set; }

    public virtual TblSsaCapabilityControlsMaster? CapabilityControlsRec { get; set; }

    public virtual TblSsaUserRolesCapability? UserRolesCapabilityRec { get; set; }
}
