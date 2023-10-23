using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblMstStaffMaster
{
    public int StaffId { get; set; }

    public int? ApplicationUserId { get; set; }

    public string? Prefix { get; set; }

    public string? Name1 { get; set; }

    public string? Name2 { get; set; }

    public string? Name3 { get; set; }

    public string? GrandFatherName { get; set; }

    public string? ProfilePicPath { get; set; }

    public string? ProfilePicFileName { get; set; }

    public string? Nationality { get; set; }

    public string? Religion { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? PlaceOfBirth { get; set; }

    public string? NationalId { get; set; }

    public DateTime? NationalIdExpiryDate { get; set; }

    public DateTime? NationalIdIssueDate { get; set; }

    public string? NationalIdIssuePlace { get; set; }

    public int? MacountryId { get; set; }

    public int? MaprovinceId { get; set; }

    public int? MacityId { get; set; }

    public int? MazipCode { get; set; }

    public string? Maaddress { get; set; }

    public int? IncountryId { get; set; }

    public int? InprovinceId { get; set; }

    public int? IncityId { get; set; }

    public int? InzipCode { get; set; }

    public string? Inaddress { get; set; }

    public string? HomeTelePhoneNumber { get; set; }

    public string? MobileNumber { get; set; }

    public string? Gender { get; set; }

    public string? CollegeEmailAddress { get; set; }

    public string? PersonalEmailAddress { get; set; }

    public string? Iban { get; set; }

    public string? MaritalStatus { get; set; }

    public string? Status { get; set; }

    public bool? IsDeleted { get; set; }

    public int? InsertBy { get; set; }

    public int? AmendBy { get; set; }

    public DateTime? InsertDateTime { get; set; }

    public DateTime? AmendDateTime { get; set; }

    public int RoleId { get; set; }

    public string? RoleNameEnglish { get; set; }

    public int? CollegeDepartmentId { get; set; }

    public int? StaffDepartmentId { get; set; }

    public DateTime? JoiningDate { get; set; }

    public int? UserId { get; set; }

    public int? Fodid { get; set; }

    public int? EmployeeId { get; set; }

    public int? IsPartOfExaminationCommitte { get; set; }

    public int? IsInInvigilation { get; set; }

    public string? OfficeLocation { get; set; }

    public string? OfficeTelephone { get; set; }

    public TimeSpan? OfficeHoursFrom { get; set; }

    public TimeSpan? OfficeHoursTo { get; set; }

    public int? IsPartOfStudentCommittee { get; set; }

    public int? StaffInGoogleMeet { get; set; }

    public int? ItsupportGroupId { get; set; }

    public string? HrCategory { get; set; }

    public int? HrmHod { get; set; }

    public int? HomeCountryIdentityNumber { get; set; }

    public string? PostalAddress { get; set; }

    public string? ZipCode { get; set; }

    public string? WorkTelephoneNumber { get; set; }

    public string? WorkTelephoneExtentionNumber { get; set; }

    public bool? IsSpecialNeeds { get; set; }

    public string? SpecialNeedCode { get; set; }

    public string? BirthPlaceCode { get; set; }

    public string? AcademicRankCode { get; set; }

    public string? FunctionalTasks { get; set; }

    public string? JobType { get; set; }

    public string? AppointmentTypeCode { get; set; }

    public string? MajorCode { get; set; }

    public string? MinorCode { get; set; }

    public string? CollegeCode { get; set; }

    public DateTime? HiringDate { get; set; }

    public DateTime? StartWorkingDate { get; set; }

    public DateTime? EndWorkingDate { get; set; }

    public string? Profession { get; set; }

    public string? Employeelocation { get; set; }
}
