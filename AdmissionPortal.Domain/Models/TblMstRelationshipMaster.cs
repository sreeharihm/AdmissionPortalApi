using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstRelationshipMaster
{
    public int RelationShipRecId { get; set; }

    public string RelationShipEngName { get; set; } = null!;

    public string RelationShipLocalName { get; set; } = null!;

    public string RelationShipCode { get; set; } = null!;

    public bool? RelationShipStatus { get; set; }

    public int InsertBy { get; set; }

    public DateTime InsertDateTime { get; set; }

    public int? AmendBy { get; set; }

    public DateTime? AmendDateTime { get; set; }
}
