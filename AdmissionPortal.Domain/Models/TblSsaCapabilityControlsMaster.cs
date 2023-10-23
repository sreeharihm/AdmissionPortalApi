using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblSsaCapabilityControlsMaster
{
    public int CapabilityControlsRecId { get; set; }

    public int? CapabilityRecId { get; set; }

    public string CapabilityControlsDescEng { get; set; } = null!;

    public string? CapabilityControlsDescLocal { get; set; }

    public string? CapabilityControlsName { get; set; }

    public string? CapabilityControlsControlName { get; set; }

    public int? ModuleRecId { get; set; }

    public string? CapabilityControlsPhysicalPath { get; set; }

    public string? CapabilityControlsRelativePath { get; set; }

    public bool? CapabilityControlsStatus { get; set; }

    public short InsertBy { get; set; }

    public DateTime InsertDateTime { get; set; }

    public short? AmendBy { get; set; }

    public DateTime? AmendDateTime { get; set; }

    public virtual TblSsaCapabilityMaster? CapabilityRec { get; set; }

    public virtual ICollection<TblSsaUserRolesCapabilityControl> TblSsaUserRolesCapabilityControls { get; set; } = new List<TblSsaUserRolesCapabilityControl>();
}
