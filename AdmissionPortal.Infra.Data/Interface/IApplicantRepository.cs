using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Models;

namespace AdmissionPortal.Infra.Data.Interface
{
    public interface IApplicantRepository
    {
        Task<string> GetEmailOtp(int userId);
        Task<string> GetMobileOtp(int userId);
        Task<ApplicantDto> CreateApplicationId(TblAdmApplicantApplicationMaster applicantApplicationMaster);
        Task GetApplicationDetails();
        Task<List<InstructionsDto>> GetInstructions(string instructionType);
        Task<ApplicantPersonalDetailsDto> GetPersonalDetails(int userId);
        Task UpSertPersonalDetails(TblAdmApplicantPersonalInformation applicantPersonalInformation, int userId);
        Task<ApplicantAddressDto> GetAddressDetails(int applicationRecId, string applicationNumber);
        Task UpSertAddressDetails(int userId, TblAdmApplicantPersonalInformation applicantPersonalInformation);
        Task GetEducationDetails();
        Task<List<AdmissionCriteriaDto>> GetAdmissionCriteria(int applicationRecId, string applicationNumber);
        Task UpsertAdmissionCriteria(TblAdmApplicantAdmissionCriteria applicantAdmissionCriteria, int userId);
        Task<List<ApplicantPreferenceDto>> GetPreference(int applicationRecId, string applicationNumber);
        Task UpsertPreference(TblAdmApplicantPreferenceInformation applicantPreferenceInformation);
        Task<List<AdmissionQuestion>> GetAdditionalDetails(int applicationRecId, string applicationNumber);
        Task<bool> UpsertAdditionalDetails(TblAdmApplicantAdmissionQuestion applicationQuestion, int userId);
        Task GetReviewDetails();
        Task<List<ApplicantCheckList>> GetAdmissionCheckList(int applicationRecId, string applicationNumber, int userId);
        Task UpsertAdmissionCheckList(TblAdmApplicantChecklist applicantChecklist, int userId);
        Task UpsertEducationDetials(TblAdmApplicantEducationalInformation educationInformation, int userId);
    }
}
