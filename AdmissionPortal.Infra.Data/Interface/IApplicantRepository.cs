using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Models;

namespace AdmissionPortal.Infra.Data.Interface
{
    public interface IApplicantRepository
    {
        Task<string> GetEmailOtp(int applicationRecId);
        Task<string> GetMobileOtp(int applicationRecId);
        Task<ApplicantDto> CreateApplicationId(TblAdmApplicantApplicationMaster applicantApplicationMaster);
        Task GetApplicationDetails();
        Task<List<InstructionsDto>> GetInstructions();
        Task<ApplicantPersonalDetailsDto> GetPersonalDetails(int userId);
        Task UpSertPersonalDetails(TblAdmApplicantPersonalInformation applicantPersonalInformation, int userId);
        Task GetAddressDetails(int applicationRecId, string applicationNumber);
        Task UpSertAddressDetails(TblAdmApplicantPersonalInformation applicantPersonalInformation);
        Task GetEducationDetails();
        Task UpSertEducationDetails();
        Task<List<AdmissionCriteriaDto>> GetAdmissionCriteria(int applicationRecId, string applicationNumber);
        Task UpsertAdmissionCriteria(TblAdmApplicantAdmissionCriteria applicantAdmissionCriteria);
        Task<List<ApplicantPreferenceDto>> GetPreference(int applicationRecId, string applicationNumber);
        Task UpsertPreference(TblAdmApplicantPreferenceInformation applicantPreferenceInformation);
        Task<List<AdmissionQuestion>> GetAdditionalDetails(int applicationRecId, string applicationNumber);
        Task<bool> UpsertAdditionalDetails(TblAdmApplicantAdmissionQuestion applicationQuestion, int userId);
        Task GetReviewDetails();
    }
}
