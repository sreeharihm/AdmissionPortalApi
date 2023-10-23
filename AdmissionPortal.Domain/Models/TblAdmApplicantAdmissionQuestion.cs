using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmApplicantAdmissionQuestion
{
    public int ApplicaentQuestionsByTermRecId { get; set; }

    public int ApplicationRecId { get; set; }

    public int QuestionsByTermRecId { get; set; }

    public int? QuestionDetailsRecId { get; set; }

    public int InsertedBy { get; set; }

    public DateTime InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public virtual TblAdmApplicantApplicationMaster ApplicationRec { get; set; } = null!;

    public virtual TblAdmByTermAdmissionQuestion QuestionsByTermRec { get; set; } = null!;
}
