using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblSsaUserRole
{
    public int RoleId { get; set; }

    public int UserId { get; set; }

    public int InsertBy { get; set; }

    public DateTime InsertDateTime { get; set; }

    public int? AmendBy { get; set; }

    public DateTime? AmendDateTime { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual TblSsaRoleMaster Role { get; set; } = null!;

    public virtual TblSsaApplicationUser User { get; set; } = null!;
}
