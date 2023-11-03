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

        public async Task<string> GetEmailOtp(int applicationRecId)
        {
            var applicationMaster = await _sisContext.TblAdmApplicantApplicationMasters.FirstOrDefaultAsync(x => x.ApplicationRecId == applicationRecId);
            return applicationMaster.EmailOtp;
        }
        public async Task<string> GetMobileOtp(int applicationRecId)
        {
            var applicationMaster = await _sisContext.TblAdmApplicantApplicationMasters.FirstOrDefaultAsync(x => x.ApplicationRecId == applicationRecId);
            return applicationMaster.MobileOtp;
        }

        public async Task<ApplicantDto> CreateApplicationId(TblAdmApplicantApplicationMaster applicantApplicationMaster)
        {
            var applicant = new ApplicantDto();
            int count = _sisContext.TblAdmApplicantApplicationMasters.Count() + 1;
            applicantApplicationMaster.ApplicationStatusRecId = 2; // MSTApplicationStatus Id=2- Application Initiated
            applicantApplicationMaster.ApplicationNumber = applicantApplicationMaster.ApplicationNumber + Convert.ToString(count);
            _sisContext.Add(applicantApplicationMaster);
            await _sisContext.SaveChangesAsync();
            applicant.ApplicationRecId = applicantApplicationMaster.ApplicationRecId;
            applicant.ApplicationNumber = applicantApplicationMaster.ApplicationNumber;
            return applicant;
        }

        public async Task<List<AdmissionQuestion>> GetAdditionalDetails(int applicationRecId, string applicationNumber)
        {
            var admissionQuestions = await (from am in _sisContext.TblAdmApplicantApplicationMasters
                                            join aq in _sisContext.TblAdmByTermAdmissionQuestions
                                            on am.TermId equals aq.TermId
                                            join aqd in _sisContext.TblAdmMasterAdmissionQuestions
                                            on aq.QuestionRecId equals aqd.QuestionRecId
                                            where am.ApplicationNumber == applicationNumber && am.ApplicationRecId == applicationRecId
                                            select new AdmissionQuestion
                                            {
                                                QuestionRecId = aq.QuestionRecId.Value,
                                                QuestionsByTermRecId = aq.QuestionsByTermRecId,
                                                DisplayOrder = aq.DisplayOrder.Value,
                                                QuestionEngName = aqd.QuestionEngName,
                                                QuestionLocalName = aqd.QuestionLocalName,
                                                QuestionType = aqd.QuestionType,
                                                QuestionStatus = aqd.QuestionStatus.Value,
                                                QuestionByTermId = aq.QuestionsByTermRecId
                                            }
                                  ).ToListAsync();

            var admissionQuestionDetails = (from aq in admissionQuestions
                                            join aqd in _sisContext.TblAdmMasterAdmissionQuestionsDetails
                                            on aq.QuestionRecId equals aqd.QuestionRecId
                                            select new AdmissionQuestionDetails
                                            {
                                                QuestionsDetailsRecId = aqd.QuestionsDetailsRecId,
                                                QuestionsDetailsOrder = aqd.QuestionsDetailsOrder,
                                                AnswerEngName = aqd.AnswearEngName,
                                                AnswerLocalName = aqd.AnswearLocalName,
                                                AnswerGender = aqd.AnswearGender.Value,
                                                AnswerStatus = aqd.AnswearStatus.Value
                                            }).ToList();

            foreach (var item in admissionQuestions)
            {
                item.QuestionDetails = admissionQuestionDetails.Where(x => x.QuestionsDetailsRecId == item.QuestionRecId).ToList();
            }

            return admissionQuestions;
        }

        public async Task GetAddressDetails(int applicationRecId, string applicationNumber)
        {
            //var data = from asm in _sisContext.TblAdmApplicantApplicationMasters
            //           join ac in _sisContext.TblAdmByTermAdmissionChecklists
            //           on asm.AcademicYearRecId equals ac.AdmissionScheduleRecId
            //           where asm.ApplicationRecId== applicationRecId && asm.ApplicationNumber == applicationNumber
            //           orderby ac.DisplayOrder
            //           select new 
            //           { 

            //           }
            throw new NotImplementedException();
        }

        public Task GetAdmissionCriteria(int applicationRecId, string applicationNumber)
        {
//            Select CriteriaLocalName, CriteriaTypeRecID, CriteriaType
//, CriteriaEngName, CriteriaMinimum, CriteriaMaxmum, CriteriaWeightage, CriteriaGroupRecID
//, CriteriaGender, CriteriaForCitizen, Condition, CriteriaForNonCitizen, Condition, CriteriaLocalRemarks, CriteriaEngRemarks
//from tbl_ADM_ByTerm_AdmissionCriterias
            //var data = from asm in _sisContext.TblAdmApplicantApplicationMasterDetails
            //           join ac in _sisContext.TblAdmByTermAdmissionCriterias
            //           on asm.
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

        public async Task<ApplicantPersonalDetailsDto> GetPersonalDetails(int userId)
        {
            var result = new ApplicantPersonalDetailsDto
            {
                UserId = userId
            };
            var applicantpersonalDetail = await _sisContext.TblAdmApplicantPersonalInformations.FirstOrDefaultAsync(i => i.UserId == userId);
            if (applicantpersonalDetail != null)
            {
                result.FatherNameLocal = applicantpersonalDetail.ThirdNameLocal;
                result.FirstNameLocal = applicantpersonalDetail.FisrtNameLocal;
                result.LastNameLocal = applicantpersonalDetail.SecondNameLocal;
                result.GrandFatherNameLocal = applicantpersonalDetail.FourthNameLocal;
                result.FatherNameEng = applicantpersonalDetail.ThirdNameEng;
                result.FirstNameEng = applicantpersonalDetail.FisrtNameEng;
                result.LastNameEng = applicantpersonalDetail.SecondNameEng;
                result.GrandFatherNameEng = applicantpersonalDetail.FourthNameEng;
                result.CountryId = applicantpersonalDetail.CountryId.Value;
                result.NationalId = applicantpersonalDetail.IdentityNumber;
                result.PrimaryEmailId = applicantpersonalDetail.ContactEmailAddress;
                result.PrimaryMobileNo = applicantpersonalDetail.ContactHomeTelephoneNumber;
                result.Gender = applicantpersonalDetail.Gender.Value == 1 ? "M" : "F";
                result.IsEmailVerified = applicantpersonalDetail.IsEmailVerified.Value;
                result.IsMobileVerified = applicantpersonalDetail.IsMobileVerified.Value;
            }
            else
            {
                var userDetails = await _sisContext.TblSsaApplicationUsers.FirstOrDefaultAsync(i => i.UserId == userId);
                result.FatherNameLocal = userDetails.FatherNameLocal;
                result.FirstNameLocal = userDetails.FirstNameLocal;
                result.LastNameLocal = userDetails.LastNameLocal;
                result.GrandFatherNameLocal = userDetails.GrandFatherNameLocal;
                result.FatherNameEng = userDetails.FatherNameEng;
                result.FirstNameEng = userDetails.FirstNameEng;
                result.LastNameEng = userDetails.LastNameEng;
                result.GrandFatherNameEng = userDetails.GrandFatherNameEng;
                result.CountryId = Convert.ToInt32(userDetails.Nationality);
                result.NationalId = userDetails.NationalId;
                result.PrimaryEmailId = userDetails.EmailAddress;
                result.PrimaryMobileNo = userDetails.Mobile;
            }
            return result;
        }

        public async Task<List<ApplicantPreferenceDto>> GetPreference(int applicationRecId, string applicationNumber)
        {
            return await (from a in _sisContext.TblAdmApplicantApplicationMasters
                          join pm in _sisContext.TblMstProgramMasters
                          on a.DegreeTypeRecId equals pm.DegreeRecId
                          where a.ApplicationNumber == applicationNumber && a.ApplicationRecId == applicationRecId
                          select new ApplicantPreferenceDto
                          {
                              ProgramRecID = pm.ProgramRecId,
                              MajorRecID = pm.MajorRecId,
                              ProgramEngName = pm.ProgramEngName,
                              ProgramLocalName = pm.ProgramLocalName,
                              ProgramShortDisplayEng = pm.ProgramShortDisplayEng,
                              ProgramShortDisplayLocal = pm.ProgramShortDisplayLocal,
                              ProgramCode = pm.ProgramCode,
                              DegreeRecId = pm.DegreeRecId.Value,
                              TermId = a.TermId,
                              AdmissionTypeRecId = a.AdmissionTypeRecId
                          }).ToListAsync();
        }

        public Task GetReviewDetails()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpsertAdditionalDetails(TblAdmApplicantAdmissionQuestion applicationQuestion, int userId)
        {

            var additionalDetails = await _sisContext.TblAdmApplicantAdmissionQuestions.FirstOrDefaultAsync(x => x.ApplicationRecId == 0 && x.QuestionDetailsRecId == 0);
            if (additionalDetails != null)
            {
                additionalDetails.QuestionDetailsRecId = Convert.ToInt32(applicationQuestion.ApplicationRecId);
                additionalDetails.LastUpdatedDateTime = DateTime.Now;
                additionalDetails.LastUpdatedBy = userId;
            }
            else
            {
                applicationQuestion.InsertedDateTime = DateTime.Now;
                applicationQuestion.InsertedBy = userId;
                await _sisContext.TblAdmApplicantAdmissionQuestions.AddRangeAsync(applicationQuestion);
            }
            await _sisContext.SaveChangesAsync();
            return true;
        }

        public Task UpSertAddressDetails(TblAdmApplicantPersonalInformation applicantPersonalInformation)
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

        public async Task UpSertPersonalDetails(TblAdmApplicantPersonalInformation applicantPersonalInformation, int userId)
        {
            var isUserExists = await _sisContext.TblAdmApplicantPersonalInformations.FirstOrDefaultAsync(x => x.UserId == applicantPersonalInformation.UserId);
            if (isUserExists != null)
            {
                isUserExists.UserId = applicantPersonalInformation.UserId;
                isUserExists.CountryId = applicantPersonalInformation.CountryId;
                isUserExists.SecondNameEng = applicantPersonalInformation.SecondNameEng;
                isUserExists.FisrtNameLocal = applicantPersonalInformation.FisrtNameLocal;
                isUserExists.SecondNameLocal = applicantPersonalInformation.SecondNameLocal;
                isUserExists.ThirdNameEng = applicantPersonalInformation.ThirdNameEng;
                isUserExists.ThirdNameLocal = applicantPersonalInformation.ThirdNameLocal;
                isUserExists.FourthNameEng = applicantPersonalInformation.FourthNameEng;
                isUserExists.FourthNameLocal = applicantPersonalInformation.FourthNameLocal;
                isUserExists.ContactEmailAddress = applicantPersonalInformation.ContactEmailAddress;
                isUserExists.ContactHomeTelephoneNumber = applicantPersonalInformation.ContactHomeTelephoneNumber;
                isUserExists.Gender = applicantPersonalInformation.Gender;
                isUserExists.CountryId = applicantPersonalInformation.CountryId;
                isUserExists.IsMobileVerified = applicantPersonalInformation.IsMobileVerified;
                isUserExists.IsEmailVerified = applicantPersonalInformation.IsEmailVerified;
                isUserExists.LastUpdatedBy = userId;
                isUserExists.LastUpdatedDateTime = DateTime.Now;
            }
            else
            {
                _sisContext.TblAdmApplicantPersonalInformations.Add(applicantPersonalInformation);
            }
            await _sisContext.SaveChangesAsync();
        }

        public async Task UpsertPreference(TblAdmApplicantPreferenceInformation applicantPreferenceInformation)
        {
            var existingPreference = await _sisContext.TblAdmApplicantPreferenceInformations.FirstAsync(x => x.ApplicationRecId == 0 && x.ProgramPreferenceRecId == 0);
            if (existingPreference != null)
            {
                existingPreference.ProgramPreferenceRecId = applicantPreferenceInformation.ProgramPreferenceRecId;
                existingPreference.ProgramPreferenceSequence = applicantPreferenceInformation.ProgramPreferenceSequence;
                existingPreference.ProgramPreferenceConfiramtionDate = DateTime.Now;
                existingPreference.ProgramPreferenceConfiramtionStatus = true;
                existingPreference.AmendBy = applicantPreferenceInformation.InsertBy;
                existingPreference.AmendDateTime = DateTime.Now;
            }
            else
            {
                applicantPreferenceInformation.InsertDateTime = DateTime.Now;
                await _sisContext.TblAdmApplicantPreferenceInformations.AddAsync(applicantPreferenceInformation);
            }
            await _sisContext.SaveChangesAsync();
        }
    }
}
