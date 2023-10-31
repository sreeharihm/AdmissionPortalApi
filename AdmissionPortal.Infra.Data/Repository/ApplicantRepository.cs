using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using AdmissionPortal.Infra.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AdmissionPortal.Infra.Data.Repository
{
    public class ApplicantRepository : IApplicantRepository
    {
        private readonly SisContext _sisContext;
        public ApplicantRepository(SisContext sisContext)
        {
            _sisContext = sisContext;
        }
        public async Task<ApplicantDto> CreateApplicationId(TblAdmApplicantApplicationMaster applicantApplicationMaster)
        {
            var applicant = new ApplicantDto();
            int count = _sisContext.TblAdmApplicantApplicationMasters.Count()+1;
            applicantApplicationMaster.ApplicationStatusRecId = 2; // MSTApplicationStatus Id=2- Application Initiated
            applicantApplicationMaster.ApplicationNumber= applicantApplicationMaster.ApplicationNumber+Convert.ToString(count);
            _sisContext.Add(applicantApplicationMaster);
            await _sisContext.SaveChangesAsync();
            applicant.ApplicationRecId = applicantApplicationMaster.ApplicationRecId;
            applicant.ApplicationNumber = applicantApplicationMaster.ApplicationNumber;
            return applicant;
        }

        public Task GetAdditionalDetails()
        {
            throw new NotImplementedException();
        }

        public Task GetAddressDetails()
        {
            throw new NotImplementedException();
        }

        public Task GetAdmissionCriteria()
        {
            throw new NotImplementedException();
        }

        public Task GetApplicationDetails()
        {
            throw new NotImplementedException();
        }

        public Task GetEducationDetails()
        {
            throw new NotImplementedException();
        }

        public async Task<List<InstructionsDto>> GetInstructions()
        {
            var result = new List<InstructionsDto>();
            result.AddRange(await (from i in _sisContext.TblMstInstructions
                                   orderby i.InstructionsRecId
                                   select new InstructionsDto
                                   { InstructionsEng = i.InstructionsEng, InstructionsLocal = i.InstructionsLocal, InstructionId = i.InstructionsRecId }
                                   ).ToListAsync());
            return result;
        }

        public Task GetPersonalDetails()
        {
            throw new NotImplementedException();
        }

        public Task GetPreference()
        {
            throw new NotImplementedException();
        }

        public Task GetReviewDetails()
        {
            throw new NotImplementedException();
        }

        public Task UpsertAdditionalDetails()
        {
            throw new NotImplementedException();
        }

        public Task UpSertAddressDetails()
        {
            throw new NotImplementedException();
        }

        public Task UpsertAdmissionCriteria()
        {
            throw new NotImplementedException();
        }

        public Task UpSertEducationDetails()
        {
            throw new NotImplementedException();
        }

        public Task UpSertPersonalDetails()
        {
            throw new NotImplementedException();
        }

        public Task UpsertPreference()
        {
            throw new NotImplementedException();
        }
    }
}
