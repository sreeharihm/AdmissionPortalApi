using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblAdmApplicantThirdPartyExamResult
{
    public int ExamResultId { get; set; }

    public string? NationalId { get; set; }

    public bool? IsSuccess { get; set; }

    public int? ErrorCode { get; set; }

    public string? ErrorMessage { get; set; }

    public string? FirstName { get; set; }

    public string? SecondName { get; set; }

    public string? ThirdName { get; set; }

    public string? LastName { get; set; }

    public string? FullName { get; set; }

    public string? ExamResult { get; set; }

    public string? ExamResultTypeLocal { get; set; }

    public string? ExamResultTypeEng { get; set; }

    public string? MaxExamResult { get; set; }

    public string? ExamType { get; set; }

    public string? ExamSpecialty { get; set; }

    public string? Error { get; set; }

    public string? ExamCode { get; set; }

    public string? Remarks { get; set; }

    public int? AdmissionTeamUpdated { get; set; }

    public int? Status { get; set; }

    public int InsertedBy { get; set; }

    public DateTime InsertedDatetime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDatetime { get; set; }
}
