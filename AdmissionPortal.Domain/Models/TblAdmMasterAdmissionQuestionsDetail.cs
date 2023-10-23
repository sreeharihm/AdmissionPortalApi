using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmMasterAdmissionQuestionsDetail
{
    public int QuestionsDetailsRecId { get; set; }

    public int? QuestionRecId { get; set; }

    public string? QuestionsDetailsOrder { get; set; }

    public string AnswearEngName { get; set; } = null!;

    public string? AnswearLocalName { get; set; }

    public int? AnswearGender { get; set; }

    public bool? AnswearStatus { get; set; }

    public int? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public virtual TblAdmMasterAdmissionQuestion? QuestionRec { get; set; }
}
