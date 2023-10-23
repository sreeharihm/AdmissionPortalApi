using System;
using System.Collections.Generic;

namespace AdmissionPortal.Infra.Data.Models;

public partial class TblSsaStaffMaster
{
    public int? RecId { get; set; }

    public int? UserId { get; set; }

    public int? Religion { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? PlaceOfBirth { get; set; }

    public int? LocalProvinceId { get; set; }

    public int? LocalCityId { get; set; }

    public string? LocalZipCode { get; set; }

    public string? LocalAddress { get; set; }

    public int? HomeProvinceId { get; set; }

    public int? HomeCityId { get; set; }

    public string? HomeZipCode { get; set; }

    public string? HomeAddress { get; set; }

    public string? HomeTelePhoneNumber { get; set; }

    public string? PersonalEmailAddress { get; set; }

    public int? MaritalStatus { get; set; }

    public int? Status { get; set; }

    public int? PrimaryRoleId { get; set; }

    public string? RoleName { get; set; }

    public string? ProgramtId { get; set; }

    public string? StaffDepartmentId { get; set; }

    public string? HoDid { get; set; }

    public string? EmployeeId { get; set; }

    public string? OfficeLocation { get; set; }

    public string? OfficeTelephone { get; set; }

    public string? StaffInGoogleMeet { get; set; }

    public string? IsSpecialNeeds { get; set; }

    public string? SpecialNeed { get; set; }

    public string? AcademicRankCode { get; set; }

    public string? Profession { get; set; }

    public int? InsertedBy { get; set; }

    public DateTime? InsertedDateTime { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedDateTime { get; set; }
}
