using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmissionPortal.Infra.Data.Interface
{
    public interface IApplicantRepository
    {
        Task<ApplicantDto> CreateApplicationId(TblAdmApplicantApplicationMaster applicantApplicationMaster);
        Task GetApplicationDetails();
        Task<List<InstructionsDto>> GetInstructions();
        Task GetPersonalDetails();
        Task UpSertPersonalDetails();
        Task GetAddressDetails();
        Task UpSertAddressDetails();
        Task GetEducationDetails();
        Task UpSertEducationDetails();
        Task GetAdmissionCriteria();
        Task UpsertAdmissionCriteria();
        Task GetPreference();
        Task UpsertPreference();
        Task GetAdditionalDetails();
        Task UpsertAdditionalDetails();
        Task GetReviewDetails();
    }
}
