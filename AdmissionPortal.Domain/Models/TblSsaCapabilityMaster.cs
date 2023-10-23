using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblSsaCapabilityMaster
{
    public int CapabilityRecId { get; set; }

    public int? ParentCapabilityId { get; set; }

    public string CapabilityDescEng { get; set; } = null!;

    public string? CapabilityDescLocal { get; set; }

    public string? CapabilityName { get; set; }

    public string? CapabilityControlName { get; set; }

    public int? ModuleRecId { get; set; }

    public string? CapabilityPhysicalPath { get; set; }

    public string? CapabilityRelativePath { get; set; }

    public bool? CapabilityStatus { get; set; }

    public short InsertBy { get; set; }

    public DateTime InsertDateTime { get; set; }

    public short? AmendBy { get; set; }

    public DateTime? AmendDateTime { get; set; }

    public virtual TblSsaModuleMaster? ModuleRec { get; set; }

    public virtual ICollection<TblSsaCapabilityControlsMaster> TblSsaCapabilityControlsMasters { get; set; } = new List<TblSsaCapabilityControlsMaster>();

    public virtual ICollection<TblSsaUserRolesCapability> TblSsaUserRolesCapabilities { get; set; } = new List<TblSsaUserRolesCapability>();
}
