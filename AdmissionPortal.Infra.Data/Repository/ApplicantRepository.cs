using AdmissionPortal.Domain.Dto;
using AdmissionPortal.Infra.Data.Interface;
using AdmissionPortal.Infra.Data.Models;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Bcpg;

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
            applicantApplicationMaster.InsertedBy = applicantApplicationMaster.UserId;
            applicantApplicationMaster.InsertedDateTime = DateTime.Now;
            _sisContext.Add(applicantApplicationMaster);
            await _sisContext.SaveChangesAsync();
            applicant.ApplicationRecId = applicantApplicationMaster.ApplicationRecId;
            applicant.ApplicationNumber = applicantApplicationMaster.ApplicationNumber;
            applicant.Message = "Application created successfully";
            await UpsertApplicationMasterDetails(applicant.ApplicationRecId, "PersonalDetails", 2, applicantApplicationMaster.InsertedBy);
            return applicant;
        }
        public async Task UpsertApplicationMaster(int applicationRecId, string stage, int userId)
        {
            var exist = await _sisContext.TblAdmApplicantApplicationMasters.FirstOrDefaultAsync(x => x.ApplicationRecId == applicationRecId);
            if (exist != null)
            {
                if (stage.Equals("PersonalDataCompleted"))
                {
                    exist.PersonalDataCompleted = true;
                    exist.PersonalDataCompletedDate = DateTime.Now;
                }
                exist.LastUpdatedDateTime = DateTime.Now;
                exist.LastUpdatedBy = userId;
            }
            await _sisContext.SaveChangesAsync();
        }

        public async Task UpsertApplicationMasterDetails(int applicationRecId, string nextStep, int status, int userId)
        {
            var exist = await _sisContext.TblAdmApplicantApplicationMasterDetails.FirstOrDefaultAsync(x => x.ApplicationRecId == applicationRecId);
            if (exist != null)
            {
                exist.ApplicationNextStep = nextStep;
                exist.ApplicationStatusUpdateDate = DateTime.Now;
                exist.LastUpdatedBy = userId;
                exist.LastUpdatedDateTime = DateTime.Now;
            }
            else
            {
                var model = new TblAdmApplicantApplicationMasterDetail();
                model.ApplicationRecId = applicationRecId;
                model.ApplicationStatusRecId = status;
                model.ApplicationStatusUpdateDate = DateTime.Now;
                model.ApplicationNextStepDate = DateTime.Now;
                model.ApplicationNextStep = nextStep;
                model.InsertedBy = userId;
                model.InsertedDateTime = DateTime.Now;
                await _sisContext.TblAdmApplicantApplicationMasterDetails.AddAsync(model);
            }
            await _sisContext.SaveChangesAsync();
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

        public async Task<ApplicantAddressDto> GetAddressDetails(int applicationRecId, string applicationNumber)
        {
            ApplicantAddressDto dto = new ApplicantAddressDto();
            dto = await (from asm in _sisContext.TblAdmApplicantApplicationMasters
                         join ap in _sisContext.TblAdmApplicantPersonalInformations
                             on asm.UserId equals ap.UserId
                         where asm.ApplicationRecId == applicationRecId && asm.ApplicationNumber == applicationNumber
                         select new ApplicantAddressDto
                         {
                             ContactAddress = ap.ContactAddress,
                             ContactCityName = ap.ContactCityName,
                             ContactCountryId = ap.ContactCountryId.HasValue ? ap.ContactCountryId.Value : 0,
                             ContactPobox = ap.ContactPobox,
                             ContactPostalCode = ap.ContactPostalCode,
                             ContactProvinceName = ap.ContactProvinceName,
                             ContactHomeTelephoneNumber = ap.ContactHomeTelephoneNumber,
                             PermanentAddress = ap.PermanentAddress,
                             PermanentCityName = ap.PermanentCityName,
                             PermanentCountryId = ap.PermanentCountryId.HasValue ? ap.PermanentCountryId.Value : 0,
                             PermanentHomeTelephoneNumber = ap.PermanentHomeTelephoneNumber,
                             PermanentPobox = ap.PermanentPobox,
                             PermanentPostalCode = ap.PermanentPostalCode,
                             PermanentProvinceName = ap.PermanentProvinceName
                         }).FirstOrDefaultAsync();
            return dto;
        }

        public async Task<List<AdmissionCriteriaDto>> GetAdmissionCriteria(int applicationRecId, string applicationNumber)
        {
            return await (from asm in _sisContext.TblAdmApplicantApplicationMasters
                          join ac in _sisContext.TblAdmByTermAdmissionCriterias
                          on asm.AdmissionTypeRecId equals ac.AdmissionScheduleRecId
                          where asm.ApplicationRecId == applicationRecId && asm.ApplicationNumber == applicationNumber
                          select new AdmissionCriteriaDto
                          {
                              CriteriaLocalName = ac.CriteriaLocalName,
                              CriteriaTypeRecId = ac.CriteriaTypeRecId.Value,
                              CriteriaType = ac.CriteriaType,
                              CriteriaEngName = ac.CriteriaEngName,
                              CriteriaMinimum = ac.CriteriaMinimum.Value,
                              CriteriaMaxmum = ac.CriteriaMaxmum.Value,
                              CriteriaWeightage = ac.CriteriaWeightage.Value,
                              CriteriaGroupRecId = ac.CriteriaGroupRecId.Value,
                              CriteriaGender = ac.CriteriaGender.Value,
                              CriteriaForCitizen = ac.CriteriaForCitizen.Value,
                              Condition = ac.Condition,
                              CriteriaForNonCitizen = ac.CriteriaForNonCitizen.Value,
                              CriteriaLocalRemarks = ac.CriteriaLocalRemarks,
                              CriteriaEngRemarks = ac.CriteriaEngRemarks
                          }
                       ).ToListAsync();

        }

        public Task GetApplicationDetails()
        {
            throw new NotImplementedException();
        }

        public Task GetEducationDetails()
        {
            throw new NotImplementedException();
        }

        public async Task<List<InstructionsDto>> GetInstructions(string instructionType)
        {
            var result = new List<InstructionsDto>();
            result.AddRange(await (from i in _sisContext.TblMstInstructions
                                   where i.InstructionsType == instructionType
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
                var countryId = _sisContext.TblMstCountryMasters.FirstOrDefault(m => m.CountryName == userDetails.Nationality).CountryRecId;
                result.CountryId = countryId;
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

        public async Task UpSertAddressDetails(int userId, TblAdmApplicantPersonalInformation applicantPersonalInformation)
        {
            var personalInformationExist = await _sisContext.TblAdmApplicantPersonalInformations.FirstAsync(x => x.UserId == userId);
            if (personalInformationExist != null)
            {
                personalInformationExist.LastUpdatedDateTime = DateTime.Now;
                personalInformationExist.LastUpdatedBy = userId;
                personalInformationExist.ContactAddress = applicantPersonalInformation.ContactAddress;
                personalInformationExist.ContactCityName = applicantPersonalInformation.ContactCityName;
                personalInformationExist.ContactCountryId = applicantPersonalInformation.ContactCountryId;
                personalInformationExist.ContactPobox = applicantPersonalInformation.ContactPobox;
                personalInformationExist.ContactPostalCode = applicantPersonalInformation.ContactPostalCode;
                personalInformationExist.ContactProvinceName = applicantPersonalInformation.ContactProvinceName;
                personalInformationExist.ContactHomeTelephoneNumber = applicantPersonalInformation.ContactHomeTelephoneNumber;
                personalInformationExist.PermanentAddress = applicantPersonalInformation.PermanentAddress;
                personalInformationExist.PermanentCityName = applicantPersonalInformation.PermanentCityName;
                personalInformationExist.PermanentCountryId = applicantPersonalInformation.PermanentCountryId;
                personalInformationExist.PermanentHomeTelephoneNumber = applicantPersonalInformation.PermanentHomeTelephoneNumber;
                personalInformationExist.PermanentPobox = applicantPersonalInformation.PermanentPobox;
                personalInformationExist.PermanentPostalCode = applicantPersonalInformation.PermanentPostalCode;
                personalInformationExist.PermanentProvinceName = applicantPersonalInformation.PermanentProvinceName;
                personalInformationExist.LastUpdatedBy = userId;
                personalInformationExist.LastUpdatedDateTime = DateTime.Now;
            }
            else
            {
                applicantPersonalInformation.InsertedDateTime = DateTime.Now;
                await _sisContext.TblAdmApplicantPersonalInformations.AddAsync(applicantPersonalInformation);
            }
            await _sisContext.SaveChangesAsync();
        }

        public async Task UpsertAdmissionCriteria(TblAdmApplicantAdmissionCriteria applicantAdmissionCriteria, int userId)
        {
            var criteriaExists = await _sisContext.TblAdmApplicantAdmissionCriterias.FirstOrDefaultAsync(x => x.ApplicationRecId == applicantAdmissionCriteria.ApplicationRecId);
            if (criteriaExists != null)
            {
                criteriaExists.LastUpdatedDateTime = DateTime.Now;
                criteriaExists.LastUpdatedBy = userId;
            }
            else
            {
                applicantAdmissionCriteria.InsertedDateTime = DateTime.Now;
                await _sisContext.TblAdmApplicantAdmissionCriterias.AddAsync(applicantAdmissionCriteria);

            }
            await _sisContext.SaveChangesAsync();
        }


        public async Task UpSertPersonalDetails(TblAdmApplicantPersonalInformation applicantPersonalInformation, int userId, int applicationRecId)
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
            await UpsertApplicationMaster(applicationRecId, "PersonalDataCompleted", userId);

            await _sisContext.SaveChangesAsync();
            await UpsertApplicationMasterDetails(applicationRecId, "Address Detail", 4,applicantPersonalInformation.UserId);
        }

        public async Task UpsertPreference(TblAdmApplicantPreferenceInformation applicantPreferenceInformation)
        {
            var existingPreference = await _sisContext.TblAdmApplicantPreferenceInformations.FirstOrDefaultAsync(x => x.ApplicationRecId == 0 && x.ProgramPreferenceRecId == 0);
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

        public async Task<List<ApplicantCheckList>> GetAdmissionCheckList(int applicationRecId, string applicationNumber, int userId)
        {
            return await (from asm in _sisContext.TblAdmApplicantApplicationMasters
                          join ac in _sisContext.TblAdmByTermAdmissionChecklists
                          on asm.AcademicYearRecId equals ac.AdmissionScheduleRecId
                          join apm in _sisContext.TblAdmApplicantPersonalInformations
                          on asm.ApplicationRecId equals userId
                          where
                          asm.ApplicationRecId == applicationRecId &&
                          asm.ApplicationNumber == applicationNumber &&
                          apm.Gender == ac.ChecklistGender
                          select new ApplicantCheckList
                          {
                              ChecklistByTermRecId = ac.ChecklistByTermRecId,
                              ChecklistRecId = ac.ChecklistRecId.Value,
                              ChecklistEngName = ac.ChecklistEngName,
                              ChecklistLocalName = ac.ChecklistLocalName,
                              ChecklistNotesEng = ac.ChecklistNotesEng,
                              ChecklistNotesLocal = ac.ChecklistNotesLocal,
                              ChecklistIsForLocals = ac.ChecklistIsForLocals.Value,
                              ChecklistIsForNonLocals = ac.ChecklistIsForNonLocals.Value,
                              DisplayOrder = ac.DisplayOrder.Value,
                              IsLocal = apm.CountryId == 156
                          }
            ).ToListAsync();
        }

        public async Task UpsertAdmissionCheckList(TblAdmApplicantChecklist applicantChecklist, int userId)
        {
            var isCheckListExisit = await _sisContext.TblAdmApplicantChecklists.FirstOrDefaultAsync(x => x.ApplicationRecId == applicantChecklist.ApplicationRecId && x.ChecklistByTermRecId == applicantChecklist.ChecklistByTermRecId);
            if (isCheckListExisit != null)
            {
                isCheckListExisit.ChecklistAttachments = applicantChecklist.ChecklistAttachments;
                isCheckListExisit.DisplayOrder = applicantChecklist.DisplayOrder;
                isCheckListExisit.ChecklistStatus = applicantChecklist.ChecklistStatus;
                isCheckListExisit.LastUpdatedBy = userId;
                isCheckListExisit.LastUpdatedDateTime = DateTime.UtcNow;
            }
            else
            {
                applicantChecklist.InsertedBy = userId;
                applicantChecklist.InsertedDateTime = DateTime.UtcNow;
                await _sisContext.TblAdmApplicantChecklists.AddAsync(applicantChecklist);
            }
            await _sisContext.SaveChangesAsync();
        }

        public async Task UpsertEducationDetials(TblAdmApplicantEducationalInformation educationInformation, int userId)
        {
            var isEducationExisit = await _sisContext.TblAdmApplicantEducationalInformations.FirstOrDefaultAsync(x => x.ApplicationRecId == educationInformation.ApplicationRecId && x.CertificateType == educationInformation.CertificateType);
            if (isEducationExisit != null)
            {
                isEducationExisit.ExternalCode = educationInformation.ExternalCode;
                isEducationExisit.CityName = educationInformation.CityName;
                isEducationExisit.CountryRecId = educationInformation.CountryRecId;
                isEducationExisit.SchoolName = educationInformation.SchoolName;
                isEducationExisit.StudyCenterName = educationInformation?.StudyCenterName;
                isEducationExisit.GradeType = educationInformation?.GradeType;
                isEducationExisit.GraduationYear = educationInformation?.GraduationYear;
                isEducationExisit.ProvinceName = educationInformation?.ProvinceName;
                isEducationExisit.LastUpdatedBy = userId;
                isEducationExisit.LastUpdatedDateTime = DateTime.Now;
            }
            else
            {
                educationInformation.InsertedBy = userId;
                educationInformation.InsertedDateTime = DateTime.Now;
                await _sisContext.AddAsync(educationInformation);
            }
            await _sisContext.SaveChangesAsync();
        }
    }
}
