using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmByTermAdmissionQuestion
{
    public int QuestionsByTermRecId { get; set; }

    public int? QuestionRecId { get; set; }

    public int TermId { get; set; }

    public int? DisplayOrder { get; set; }

    public int? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public int? LastUpdaetdBy { get; set; }

    public DateTime? LastUpdaetdDateTime { get; set; }

    public virtual TblAdmMasterAdmissionQuestion? QuestionRec { get; set; }

    public virtual ICollection<TblAdmApplicantAdmissionQuestion> TblAdmApplicantAdmissionQuestions { get; set; } = new List<TblAdmApplicantAdmissionQuestion>();
}
