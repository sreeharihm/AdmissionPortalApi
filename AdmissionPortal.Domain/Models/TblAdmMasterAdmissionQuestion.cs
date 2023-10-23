using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmMasterAdmissionQuestion
{
    public int QuestionRecId { get; set; }

    public string QuestionEngName { get; set; } = null!;

    public string QuestionLocalName { get; set; } = null!;

    public bool? QuestionStatus { get; set; }

    public string QuestionType { get; set; } = null!;

    public int? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public virtual ICollection<TblAdmByTermAdmissionQuestion> TblAdmByTermAdmissionQuestions { get; set; } = new List<TblAdmByTermAdmissionQuestion>();

    public virtual ICollection<TblAdmMasterAdmissionQuestionsDetail> TblAdmMasterAdmissionQuestionsDetails { get; set; } = new List<TblAdmMasterAdmissionQuestionsDetail>();
}
