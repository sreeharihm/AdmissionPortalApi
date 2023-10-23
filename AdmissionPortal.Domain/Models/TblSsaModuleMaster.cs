using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblSsaModuleMaster
{
    public int ModuleRecId { get; set; }

    public string? ModuleName { get; set; }

    public string ModuleDescEng { get; set; } = null!;

    public string? ModuleDescLocal { get; set; }

    public string? ModuleControlName { get; set; }

    public string? ModulePhysicalPath { get; set; }

    public string? ModuleRelativePath { get; set; }

    public bool? ModuleStatus { get; set; }

    public short InsertBy { get; set; }

    public DateTime InsertDateTime { get; set; }

    public short? AmendBy { get; set; }

    public DateTime? AmendDateTime { get; set; }

    public virtual ICollection<TblSsaCapabilityMaster> TblSsaCapabilityMasters { get; set; } = new List<TblSsaCapabilityMaster>();
}
