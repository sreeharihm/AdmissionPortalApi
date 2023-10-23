using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblRegTermMaster
{
    public int TermId { get; set; }

    public int? TermCode { get; set; }

    public string? TermName { get; set; }

    public int? TermCodeDigits { get; set; }

    public string? TermLocalName { get; set; }

    public int? AcademicYearId { get; set; }

    public DateTime? TermStartDateAndTime { get; set; }

    public DateTime? TermEndDateAndTime { get; set; }

    public DateTime? ClassesStartDateAndTime { get; set; }

    public DateTime? ClassesEndDateAndTime { get; set; }

    public int? AttendanceWeeks { get; set; }

    public int? AttendanceStartCalcuationWeek { get; set; }

    public int? AttendanceAbsentWeeks { get; set; }

    public int? Crncapacity { get; set; }

    public string? AttendacneFormula { get; set; }

    public DateTime? GradePublishingDateAndTime { get; set; }

    public bool? IsFinancialAidApplicable { get; set; }

    public bool? IsDhlpublished { get; set; }

    public bool? IsDngradesPublished { get; set; }

    public DateTime? MidtermEntryFromDateAndTime { get; set; }

    public DateTime? MidtermEntryToDateAndTime { get; set; }

    public bool? IsTermExcludeFromCgpa { get; set; }

    public bool? FamilyDiscount { get; set; }

    public bool? StudentSibilingDiscount { get; set; }

    public int? TermCrnStartCode { get; set; }

    public int? CitizenVat { get; set; }

    public int? NoCitizenVat { get; set; }

    public DateTime? FinalExamStartDateAndTime { get; set; }

    public DateTime? FinalExamEndDateAndTime { get; set; }

    public bool? IsCalendarEventPublish { get; set; }

    public int? CalendarEventPublishedBy { get; set; }

    public DateTime? CalendarEventPublisheDateAndTime { get; set; }

    public int? MinCreditsForRegistration { get; set; }

    public DateTime? GradeSubmissionendStartDateAndTime { get; set; }

    public DateTime? GradeSubmissionendEndDateAndTime { get; set; }

    public DateTime? MidTermSubmissionStarDateAndTime { get; set; }

    public DateTime? MidTermSubmissionEndDateAndTime { get; set; }

    public DateTime? OtherPreFinalGradeEntryStartDateAndTime { get; set; }

    public DateTime? OtherPreFinalGradeEntryEndDateAndTime { get; set; }

    public DateTime? FinalGradeEntryStartDateAndTime { get; set; }

    public DateTime? FinalGradeEntryEndtDateAndTime { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsCurrentTerm { get; set; }

    public int? InsertBy { get; set; }

    public DateTime? InsertDateAndTimeTime { get; set; }

    public int? AmendBy { get; set; }

    public DateTime? AmendDateAndTimeTime { get; set; }

    public virtual ICollection<TblAdmApplicantApplicationMaster> TblAdmApplicantApplicationMasters { get; set; } = new List<TblAdmApplicantApplicationMaster>();

    public virtual ICollection<TblAdmByTermAdmissionPreference> TblAdmByTermAdmissionPreferences { get; set; } = new List<TblAdmByTermAdmissionPreference>();

    public virtual ICollection<TblAdmByTermAdmissionSchedule> TblAdmByTermAdmissionSchedules { get; set; } = new List<TblAdmByTermAdmissionSchedule>();
}
