using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmApplicantApplicationMaster
{
    public int ApplicationRecId { get; set; }

    public string ApplicationNumber { get; set; } = null!;

    public int ApplicationStatusRecId { get; set; }

    public int UserId { get; set; }

    public int AdmissionTypeRecId { get; set; }

    public int DegreeTypeRecId { get; set; }

    public int AcademicYearRecId { get; set; }

    public int TermId { get; set; }

    public string? StudentId { get; set; }

    public decimal? AdmissionFee { get; set; }

    public decimal? Vat { get; set; }

    public DateTime? AdmissionFeePaymentDate { get; set; }

    public bool? PersonalDataCompleted { get; set; }

    public DateTime? PersonalDataCompletedDate { get; set; }

    public bool? EducationalDataCompleted { get; set; }

    public DateTime? EducationalDataCompletedDate { get; set; }

    public bool? CriteriaDataCompleted { get; set; }

    public DateTime? CriteriaDataCompletedDate { get; set; }

    public bool? CheckListDataCompleted { get; set; }

    public DateTime? CheckListDataCompletedDate { get; set; }

    public bool? PreferenceDataCompleted { get; set; }

    public DateTime? PreferenceDataCompletedDate { get; set; }

    public bool? AdmissionPaymentCompleted { get; set; }

    public DateTime? AdmissionPaymentCompletedDate { get; set; }

    public bool? TuitionPaymentCompleted { get; set; }

    public DateTime? TuitionPaymentCompletedDate { get; set; }

    public bool? ExamScheduled { get; set; }

    public DateTime? ExamScheduledDate { get; set; }

    public bool? ExamScoreCompleted { get; set; }

    public DateTime? ExamScoreDate { get; set; }

    public string? ExamScoreValue { get; set; }

    public int? ExamScoreUpdatedBy { get; set; }

    public DateTime? ExamScoreUpdatedByDate { get; set; }

    public bool? DeclerationCompleted { get; set; }

    public DateTime? DeclerationCompletedDate { get; set; }

    public int? ConfirmedMajor { get; set; }

    public int InsertedBy { get; set; }

    public DateTime InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }

    public virtual TblRegAcademicYear AcademicYearRec { get; set; } = null!;

    public virtual TblMstAdmissionTypeMaster AdmissionTypeRec { get; set; } = null!;

    public virtual TblMstApplicationStatus ApplicationStatusRec { get; set; } = null!;

    public virtual TblMstDegreeTypeMaster DegreeTypeRec { get; set; } = null!;

    public virtual ICollection<TblAdmApplicantAdmissionCriteria> TblAdmApplicantAdmissionCriteria { get; set; } = new List<TblAdmApplicantAdmissionCriteria>();

    public virtual ICollection<TblAdmApplicantAdmissionQuestion> TblAdmApplicantAdmissionQuestions { get; set; } = new List<TblAdmApplicantAdmissionQuestion>();

    public virtual ICollection<TblAdmApplicantChecklist> TblAdmApplicantChecklists { get; set; } = new List<TblAdmApplicantChecklist>();

    public virtual ICollection<TblAdmApplicantEducationalInformation> TblAdmApplicantEducationalInformations { get; set; } = new List<TblAdmApplicantEducationalInformation>();

    public virtual ICollection<TblAdmApplicantPreferenceInformation> TblAdmApplicantPreferenceInformations { get; set; } = new List<TblAdmApplicantPreferenceInformation>();

    public virtual TblRegTermMaster Term { get; set; } = null!;

    public virtual TblSsaApplicationUser User { get; set; } = null!;
}
