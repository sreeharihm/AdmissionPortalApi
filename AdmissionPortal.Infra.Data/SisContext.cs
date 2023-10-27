using Microsoft.EntityFrameworkCore;

namespace AdmissionPortal.Infra.Data.Models;

public partial class SisContext : DbContext
{
    public SisContext()
    {
    }

    public SisContext(DbContextOptions<SisContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblAdmAdmissionLead> TblAdmAdmissionLeads { get; set; }

    public virtual DbSet<TblAdmApplicantAdmissionCriteria> TblAdmApplicantAdmissionCriterias { get; set; }

    public virtual DbSet<TblAdmApplicantAdmissionQuestion> TblAdmApplicantAdmissionQuestions { get; set; }

    public virtual DbSet<TblAdmApplicantApplicationMaster> TblAdmApplicantApplicationMasters { get; set; }

    public virtual DbSet<TblAdmApplicantApplicationMasterDetail> TblAdmApplicantApplicationMasterDetails { get; set; }

    public virtual DbSet<TblAdmApplicantChecklist> TblAdmApplicantChecklists { get; set; }

    public virtual DbSet<TblAdmApplicantEducationalInformation> TblAdmApplicantEducationalInformations { get; set; }

    public virtual DbSet<TblAdmApplicantPersonalInformation> TblAdmApplicantPersonalInformations { get; set; }

    public virtual DbSet<TblAdmApplicantPreferenceInformation> TblAdmApplicantPreferenceInformations { get; set; }

    public virtual DbSet<TblAdmApplicantThirdPartyExamResult> TblAdmApplicantThirdPartyExamResults { get; set; }

    public virtual DbSet<TblAdmByTermAdmissionChecklist> TblAdmByTermAdmissionChecklists { get; set; }

    public virtual DbSet<TblAdmByTermAdmissionCriteria> TblAdmByTermAdmissionCriterias { get; set; }

    public virtual DbSet<TblAdmByTermAdmissionPreference> TblAdmByTermAdmissionPreferences { get; set; }

    public virtual DbSet<TblAdmByTermAdmissionQuestion> TblAdmByTermAdmissionQuestions { get; set; }

    public virtual DbSet<TblAdmByTermAdmissionSchedule> TblAdmByTermAdmissionSchedules { get; set; }

    public virtual DbSet<TblAdmDepartmentMaster> TblAdmDepartmentMasters { get; set; }

    public virtual DbSet<TblAdmMajorMaster> TblAdmMajorMasters { get; set; }

    public virtual DbSet<TblAdmMasterAdmissionChecklist> TblAdmMasterAdmissionChecklists { get; set; }

    public virtual DbSet<TblAdmMasterAdmissionCriteria> TblAdmMasterAdmissionCriterias { get; set; }

    public virtual DbSet<TblAdmMasterAdmissionCriteriaGroup> TblAdmMasterAdmissionCriteriaGroups { get; set; }

    public virtual DbSet<TblAdmMasterAdmissionCriteriaType> TblAdmMasterAdmissionCriteriaTypes { get; set; }

    public virtual DbSet<TblAdmMasterAdmissionQuestion> TblAdmMasterAdmissionQuestions { get; set; }

    public virtual DbSet<TblAdmMasterAdmissionQuestionsDetail> TblAdmMasterAdmissionQuestionsDetails { get; set; }

    public virtual DbSet<TblAdmProgramStructure> TblAdmProgramStructures { get; set; }

    public virtual DbSet<TblFiaFeeProjection> TblFiaFeeProjections { get; set; }

    public virtual DbSet<TblFiaProgramFeeStructure> TblFiaProgramFeeStructures { get; set; }

    public virtual DbSet<TblMstAddressTypeMaster> TblMstAddressTypeMasters { get; set; }

    public virtual DbSet<TblMstAdmissionTypeMaster> TblMstAdmissionTypeMasters { get; set; }

    public virtual DbSet<TblMstApplicationStatus> TblMstApplicationStatuses { get; set; }

    public virtual DbSet<TblMstAttendanceAction> TblMstAttendanceActions { get; set; }

    public virtual DbSet<TblMstAttendanceComponent> TblMstAttendanceComponents { get; set; }

    public virtual DbSet<TblMstAttendanceMethod> TblMstAttendanceMethods { get; set; }

    public virtual DbSet<TblMstAttendanceWarningRule> TblMstAttendanceWarningRules { get; set; }

    public virtual DbSet<TblMstAutoNotification> TblMstAutoNotifications { get; set; }

    public virtual DbSet<TblMstCampusMaster> TblMstCampusMasters { get; set; }

    public virtual DbSet<TblMstCheklistTypeMaster> TblMstCheklistTypeMasters { get; set; }

    public virtual DbSet<TblMstCitizensTypeMaster> TblMstCitizensTypeMasters { get; set; }

    public virtual DbSet<TblMstCity> TblMstCities { get; set; }

    public virtual DbSet<TblMstCollege> TblMstColleges { get; set; }

    public virtual DbSet<TblMstCollegeGrading> TblMstCollegeGradings { get; set; }

    public virtual DbSet<TblMstCountryMaster> TblMstCountryMasters { get; set; }

    public virtual DbSet<TblMstDegreeTypeMaster> TblMstDegreeTypeMasters { get; set; }

    public virtual DbSet<TblMstErrorMessageMaster> TblMstErrorMessageMasters { get; set; }

    public virtual DbSet<TblMstFeeTypeMaster> TblMstFeeTypeMasters { get; set; }

    public virtual DbSet<TblMstGenderMaster> TblMstGenderMasters { get; set; }

    public virtual DbSet<TblMstGradingDefintion> TblMstGradingDefintions { get; set; }

    public virtual DbSet<TblMstHighSchoolTypeMaster> TblMstHighSchoolTypeMasters { get; set; }

    public virtual DbSet<TblMstInstruction> TblMstInstructions { get; set; }

    public virtual DbSet<TblMstMajorType> TblMstMajorTypes { get; set; }

    public virtual DbSet<TblMstNotifcationsType> TblMstNotifcationsTypes { get; set; }

    public virtual DbSet<TblMstNotificationsMaster> TblMstNotificationsMasters { get; set; }

    public virtual DbSet<TblMstOrganazationCatogery> TblMstOrganazationCatogeries { get; set; }

    public virtual DbSet<TblMstOrganazationMaster> TblMstOrganazationMasters { get; set; }

    public virtual DbSet<TblMstOrganazationType> TblMstOrganazationTypes { get; set; }

    public virtual DbSet<TblMstPrefferedLanguage> TblMstPrefferedLanguages { get; set; }

    public virtual DbSet<TblMstProgramMaster> TblMstProgramMasters { get; set; }

    public virtual DbSet<TblMstProgramStudyType> TblMstProgramStudyTypes { get; set; }

    public virtual DbSet<TblMstProvince> TblMstProvinces { get; set; }

    public virtual DbSet<TblMstRecordStatus> TblMstRecordStatuses { get; set; }

    public virtual DbSet<TblMstRegistrationType> TblMstRegistrationTypes { get; set; }

    public virtual DbSet<TblMstRelationshipMaster> TblMstRelationshipMasters { get; set; }

    public virtual DbSet<TblMstReligionMaster> TblMstReligionMasters { get; set; }

    public virtual DbSet<TblMstSmsmaster> TblMstSmsmasters { get; set; }

    public virtual DbSet<TblMstStaffMaster> TblMstStaffMasters { get; set; }

    public virtual DbSet<TblMstStateMaster> TblMstStateMasters { get; set; }

    public virtual DbSet<TblMstStudentTypeMaster> TblMstStudentTypeMasters { get; set; }

    public virtual DbSet<TblMstStudyCenterMaster> TblMstStudyCenterMasters { get; set; }

    public virtual DbSet<TblMstTermsType> TblMstTermsTypes { get; set; }

    public virtual DbSet<TblMstVisaMaster> TblMstVisaMasters { get; set; }

    public virtual DbSet<TblRegAcademicYear> TblRegAcademicYears { get; set; }

    public virtual DbSet<TblRegTermMaster> TblRegTermMasters { get; set; }

    public virtual DbSet<TblSsaApplicationUser> TblSsaApplicationUsers { get; set; }

    public virtual DbSet<TblSsaCapabilityControlsMaster> TblSsaCapabilityControlsMasters { get; set; }

    public virtual DbSet<TblSsaCapabilityMaster> TblSsaCapabilityMasters { get; set; }

    public virtual DbSet<TblSsaModuleMaster> TblSsaModuleMasters { get; set; }

    public virtual DbSet<TblSsaRoleCategory> TblSsaRoleCategories { get; set; }

    public virtual DbSet<TblSsaRoleMaster> TblSsaRoleMasters { get; set; }

    public virtual DbSet<TblSsaStaffMaster> TblSsaStaffMasters { get; set; }

    public virtual DbSet<TblSsaUserRole> TblSsaUserRoles { get; set; }

    public virtual DbSet<TblSsaUserRolesCapability> TblSsaUserRolesCapabilities { get; set; }

    public virtual DbSet<TblSsaUserRolesCapabilityControl> TblSsaUserRolesCapabilityControls { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblAdmAdmissionLead>(entity =>
        {
            entity.HasKey(e => e.AdmissionLeadRecId);

            entity.ToTable("tbl_ADM_AdmissionLeads");

            entity.Property(e => e.AdmissionLeadRecId).HasColumnName("AdmissionLeadRecID");
            entity.Property(e => e.EmailId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FullName).HasMaxLength(150);
            entity.Property(e => e.InsertedDate).HasColumnType("datetime");
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NationalId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NationalID");
            entity.Property(e => e.ProgramOfIntrest)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblAdmApplicantAdmissionCriteria>(entity =>
        {
            entity.HasKey(e => e.ApplicantByTermCriteriaRecId).HasName("PK_tbl_ADM_ApplicantAdmissionCriteriasByTerm");

            entity.ToTable("tbl_ADM_Applicant_AdmissionCriterias");

            entity.Property(e => e.ApplicantByTermCriteriaRecId).HasColumnName("ApplicantByTermCriteriaRecID");
            entity.Property(e => e.CriteriaDocuments)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CriteriaMaxmum)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CriteriaMinimum)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CriteriaRemarks)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.CriteriaWeightage)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InsertedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.TermCriteriaRecId).HasColumnName("TermCriteriaRecID");

            entity.HasOne(d => d.ApplicationRec).WithMany(p => p.TblAdmApplicantAdmissionCriteria)
                .HasForeignKey(d => d.ApplicationRecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApplicantAdmissionCriteria");

            entity.HasOne(d => d.TermCriteriaRec).WithMany(p => p.TblAdmApplicantAdmissionCriteria)
                .HasForeignKey(d => d.TermCriteriaRecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TermCriteriaRecId");
        });

        modelBuilder.Entity<TblAdmApplicantAdmissionQuestion>(entity =>
        {
            entity.HasKey(e => e.ApplicaentQuestionsByTermRecId).HasName("PK_tbl_ADM_ApplicaentAdmissionQuestionsByTerm");

            entity.ToTable("tbl_ADM_Applicant_AdmissionQuestions");

            entity.Property(e => e.ApplicaentQuestionsByTermRecId).HasColumnName("ApplicaentQuestionsByTermRecID");
            entity.Property(e => e.ApplicationRecId).HasColumnName("ApplicationRecID");
            entity.Property(e => e.InsertedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.QuestionDetailsRecId).HasColumnName("QuestionDetailsRecID");
            entity.Property(e => e.QuestionsByTermRecId).HasColumnName("QuestionsByTermRecID");

            entity.HasOne(d => d.ApplicationRec).WithMany(p => p.TblAdmApplicantAdmissionQuestions)
                .HasForeignKey(d => d.ApplicationRecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApplicantAdmissionQuestions");

            entity.HasOne(d => d.QuestionsByTermRec).WithMany(p => p.TblAdmApplicantAdmissionQuestions)
                .HasForeignKey(d => d.QuestionsByTermRecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ADM_Applicant_AdmissionQuestions_tbl_ADM_ByTerm_AdmissionQuestions");
        });

        modelBuilder.Entity<TblAdmApplicantApplicationMaster>(entity =>
        {
            entity.HasKey(e => e.ApplicationRecId).HasName("PK_tbl_ADM_ApplicationMaster");

            entity.ToTable("tbl_ADM_Applicant_ApplicationMaster");

            entity.HasIndex(e => e.ApplicationNumber, "IX_tbl_ADM_ApplicationMaster").IsUnique();

            entity.Property(e => e.ApplicationRecId).HasColumnName("ApplicationRecID");
            entity.Property(e => e.AcademicYearRecId).HasColumnName("AcademicYearRecID");
            entity.Property(e => e.AdmissionFee).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AdmissionFeePaymentDate).HasColumnType("datetime");
            entity.Property(e => e.AdmissionPaymentCompletedDate).HasColumnType("datetime");
            entity.Property(e => e.AdmissionTypeRecId).HasColumnName("AdmissionTypeRecID");
            entity.Property(e => e.ApplicationNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ApplicationStatusRecId).HasColumnName("ApplicationStatusRecID");
            entity.Property(e => e.CheckListDataCompletedDate).HasColumnType("datetime");
            entity.Property(e => e.CriteriaDataCompletedDate).HasColumnType("datetime");
            entity.Property(e => e.DeclerationCompletedDate).HasColumnType("datetime");
            entity.Property(e => e.DegreeTypeRecId).HasColumnName("DegreeTypeRecID");
            entity.Property(e => e.EducationalDataCompletedDate).HasColumnType("datetime");
            entity.Property(e => e.ExamScheduledDate).HasColumnType("datetime");
            entity.Property(e => e.ExamScoreDate).HasColumnType("datetime");
            entity.Property(e => e.ExamScoreUpdatedByDate).HasColumnType("datetime");
            entity.Property(e => e.ExamScoreValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsertedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.PersonalDataCompletedDate).HasColumnType("datetime");
            entity.Property(e => e.PreferenceDataCompletedDate).HasColumnType("datetime");
            entity.Property(e => e.StudentId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("StudentID");
            entity.Property(e => e.TuitionPaymentCompletedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Vat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VAT");

            entity.HasOne(d => d.AcademicYearRec).WithMany(p => p.TblAdmApplicantApplicationMasters)
                .HasForeignKey(d => d.AcademicYearRecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AcademicYear");

            entity.HasOne(d => d.AdmissionTypeRec).WithMany(p => p.TblAdmApplicantApplicationMasters)
                .HasForeignKey(d => d.AdmissionTypeRecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdmissionType");

            entity.HasOne(d => d.ApplicationStatusRec).WithMany(p => p.TblAdmApplicantApplicationMasters)
                .HasForeignKey(d => d.ApplicationStatusRecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApplicationStatus");

            entity.HasOne(d => d.DegreeTypeRec).WithMany(p => p.TblAdmApplicantApplicationMasters)
                .HasForeignKey(d => d.DegreeTypeRecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DegreeType");

            entity.HasOne(d => d.Term).WithMany(p => p.TblAdmApplicantApplicationMasters)
                .HasForeignKey(d => d.TermId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Term");

            entity.HasOne(d => d.User).WithMany(p => p.TblAdmApplicantApplicationMasters)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ADM_Applicant_ApplicationMaster_tbl_SSA_ApplicationUsers");
        });

        modelBuilder.Entity<TblAdmApplicantApplicationMasterDetail>(entity =>
        {
            entity.HasKey(e => e.ApplicationDetailsRecId).HasName("PK_tbl_ADM_ApplicationMasterDetails");

            entity.ToTable("tbl_ADM_Applicant_ApplicationMasterDetails");

            entity.Property(e => e.ApplicationDetailsRecId).HasColumnName("ApplicationDetailsRecID");
            entity.Property(e => e.ApplicationNextStep)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ApplicationNextStepDate).HasColumnType("datetime");
            entity.Property(e => e.ApplicationRecId).HasColumnName("ApplicationRecID");
            entity.Property(e => e.ApplicationStatusRecId).HasColumnName("ApplicationStatusRecID");
            entity.Property(e => e.ApplicationStatusUpdateDate).HasColumnType("datetime");
            entity.Property(e => e.ApplicationStep)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.ApplicationStepDate).HasColumnType("datetime");
            entity.Property(e => e.InsertedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.ApplicationStatusRec).WithMany(p => p.TblAdmApplicantApplicationMasterDetails)
                .HasForeignKey(d => d.ApplicationStatusRecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ADM_Applicant_ApplicationMasterDetails_tbl_ADM_Applicant_ApplicationMaster");
        });

        modelBuilder.Entity<TblAdmApplicantChecklist>(entity =>
        {
            entity.HasKey(e => e.ApplicantChecklistByTermRecId).HasName("PK_tbl_ADM_ApplicantAdmissionChecklistByTerm");

            entity.ToTable("tbl_ADM_Applicant_Checklist");

            entity.Property(e => e.ApplicantChecklistByTermRecId).HasColumnName("ApplicantChecklistByTermRecID");
            entity.Property(e => e.ApplicationRecId).HasColumnName("ApplicationRecID");
            entity.Property(e => e.ChecklistByTermRecId).HasColumnName("ChecklistByTermRecID");
            entity.Property(e => e.InsertedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.ApplicationRec).WithMany(p => p.TblAdmApplicantChecklists)
                .HasForeignKey(d => d.ApplicationRecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApplicationMaster");

            entity.HasOne(d => d.ChecklistByTermRec).WithMany(p => p.TblAdmApplicantChecklists)
                .HasForeignKey(d => d.ChecklistByTermRecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdmissionChecklist");
        });

        modelBuilder.Entity<TblAdmApplicantEducationalInformation>(entity =>
        {
            entity.HasKey(e => e.EducationalInformationRecIdid).HasName("PK_tbl_ADM_ApplicantEducationalInformation");

            entity.ToTable("tbl_ADM_Applicant_EducationalInformation");

            entity.Property(e => e.EducationalInformationRecIdid).HasColumnName("EducationalInformationRecIDId");
            entity.Property(e => e.ApplicationRecId).HasColumnName("ApplicationRecID");
            entity.Property(e => e.CertificateType).HasMaxLength(200);
            entity.Property(e => e.CityName).HasMaxLength(50);
            entity.Property(e => e.CountryRecId).HasColumnName("CountryRecID");
            entity.Property(e => e.ExternalCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Grade)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.GradeType).HasMaxLength(50);
            entity.Property(e => e.InsertedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.ProvinceName).HasMaxLength(50);
            entity.Property(e => e.SchoolName).HasMaxLength(100);
            entity.Property(e => e.StudyCenterName).HasMaxLength(100);

            entity.HasOne(d => d.ApplicationRec).WithMany(p => p.TblAdmApplicantEducationalInformations)
                .HasForeignKey(d => d.ApplicationRecId)
                .HasConstraintName("FK_tbl_ADM_Applicant_EducationalInformation_tbl_ADM_Applicant_ApplicationMaster");

            entity.HasOne(d => d.CountryRec).WithMany(p => p.TblAdmApplicantEducationalInformations)
                .HasForeignKey(d => d.CountryRecId)
                .HasConstraintName("FK_CountryMaster");
        });

        modelBuilder.Entity<TblAdmApplicantPersonalInformation>(entity =>
        {
            entity.HasKey(e => e.PersonalInfoRecId).HasName("PK_tbl_ADM_ApplicationPersonalInformation");

            entity.ToTable("tbl_ADM_Applicant_PersonalInformation");

            entity.Property(e => e.PersonalInfoRecId).HasColumnName("PersonalInfoRecID");
            entity.Property(e => e.AlternateEmailId)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AlternateMobileNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.BorderNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ContactAddress)
                .HasMaxLength(400)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.ContactCityName)
                .HasMaxLength(150)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.ContactCountryId).HasDefaultValueSql("((0))");
            entity.Property(e => e.ContactEmailAddress)
                .HasMaxLength(150)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.ContactHomeTelephoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ContactPobox)
                .HasMaxLength(150)
                .HasDefaultValueSql("('')")
                .HasColumnName("ContactPOBox");
            entity.Property(e => e.ContactPostalCode)
                .HasMaxLength(150)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.ContactProvinceName)
                .HasMaxLength(150)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.DateofBirth).HasColumnType("date");
            entity.Property(e => e.FisrtNameEng)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FisrtNameLocal).HasMaxLength(100);
            entity.Property(e => e.FourthNameEng)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FourthNameLocal).HasMaxLength(100);
            entity.Property(e => e.Hobbies)
                .HasMaxLength(400)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.HomeIdentityNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.IdentityNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsertedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.MaritalStatus).HasDefaultValueSql("((0))");
            entity.Property(e => e.PassporPlaceOfIssueEng)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.PassporPlaceOfIssueLocal)
                .HasMaxLength(150)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.PassportExpiryDate).HasColumnType("date");
            entity.Property(e => e.PassportNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Religion).HasDefaultValueSql("((0))");
            entity.Property(e => e.SecondNameEng)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SecondNameLocal).HasMaxLength(100);
            entity.Property(e => e.StudentTypeId).HasColumnName("StudentTypeID");
            entity.Property(e => e.ThirdNameEng)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ThirdNameLocal).HasMaxLength(100);
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.TblAdmApplicantPersonalInformations)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ADM_ApplicationPersonalInformation_tbl_SSA_ApplicationUsers");
        });

        modelBuilder.Entity<TblAdmApplicantPreferenceInformation>(entity =>
        {
            entity.HasKey(e => e.ApplicationPreferenceRecId).HasName("PK_tbl_ADM_ApplicationPreferenceInformation");

            entity.ToTable("tbl_ADM_Applicant_PreferenceInformation");

            entity.Property(e => e.ApplicationPreferenceRecId).HasColumnName("ApplicationPreferenceRecID");
            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.ApplicationRecId).HasColumnName("ApplicationRecID");
            entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ProgramPreferenceConfiramtionDate).HasColumnType("datetime");

            entity.HasOne(d => d.ApplicationRec).WithMany(p => p.TblAdmApplicantPreferenceInformations)
                .HasForeignKey(d => d.ApplicationRecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ADM_Applicant_PreferenceInformation_tbl_ADM_Applicant_ApplicationMaster");
        });

        modelBuilder.Entity<TblAdmApplicantThirdPartyExamResult>(entity =>
        {
            entity.HasKey(e => e.ExamResultId).HasName("PK_tbl_ADM_ThirdPartyExamResults_TTECExamResultId");

            entity.ToTable("tbl_ADM_Applicant_ThirdPartyExamResults");

            entity.Property(e => e.Error).HasMaxLength(1000);
            entity.Property(e => e.ErrorMessage).HasMaxLength(1000);
            entity.Property(e => e.ExamCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ExamResult)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ExamResultTypeEng).HasMaxLength(100);
            entity.Property(e => e.ExamResultTypeLocal).HasMaxLength(100);
            entity.Property(e => e.ExamSpecialty).HasMaxLength(100);
            entity.Property(e => e.ExamType).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(1000);
            entity.Property(e => e.FullName).HasMaxLength(1000);
            entity.Property(e => e.InsertedDatetime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastName).HasMaxLength(1000);
            entity.Property(e => e.LastUpdatedDatetime).HasColumnType("datetime");
            entity.Property(e => e.MaxExamResult)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NationalId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Remarks).HasMaxLength(1000);
            entity.Property(e => e.SecondName).HasMaxLength(1000);
            entity.Property(e => e.ThirdName).HasMaxLength(1000);
        });

        modelBuilder.Entity<TblAdmByTermAdmissionChecklist>(entity =>
        {
            entity.HasKey(e => e.ChecklistByTermRecId);

            entity.ToTable("tbl_ADM_ByTerm_AdmissionChecklist");

            entity.Property(e => e.ChecklistByTermRecId).HasColumnName("ChecklistByTermRecID");
            entity.Property(e => e.ChecklistEngName).HasMaxLength(255);
            entity.Property(e => e.ChecklistLocalName).HasMaxLength(255);
            entity.Property(e => e.ChecklistNotesEng).HasMaxLength(255);
            entity.Property(e => e.ChecklistNotesLocal).HasMaxLength(255);
            entity.Property(e => e.ChecklistRecId).HasColumnName("ChecklistRecID");
            entity.Property(e => e.EffectiveFrom).HasColumnType("datetime");
            entity.Property(e => e.EffectiveTo).HasColumnType("datetime");
            entity.Property(e => e.GraduationCountry)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsertedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy).HasMaxLength(255);
            entity.Property(e => e.LastUpdatedDateTime).HasMaxLength(255);

            entity.HasOne(d => d.ChecklistRec).WithMany(p => p.TblAdmByTermAdmissionChecklists)
                .HasForeignKey(d => d.ChecklistRecId)
                .HasConstraintName("FK_tbl_ADM_ByTerm_AdmissionChecklist_tbl_ADM_Master_AdmissionChecklist");
        });

        modelBuilder.Entity<TblAdmByTermAdmissionCriteria>(entity =>
        {
            entity.HasKey(e => e.TermCriteriaRecId);

            entity.ToTable("tbl_ADM_ByTerm_AdmissionCriterias");

            entity.Property(e => e.TermCriteriaRecId)
                .ValueGeneratedNever()
                .HasColumnName("TermCriteriaRecID");
            entity.Property(e => e.Condition).HasMaxLength(255);
            entity.Property(e => e.CriteriaEngName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CriteriaEngRemarks)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CriteriaGroupRecId).HasColumnName("CriteriaGroupRecID");
            entity.Property(e => e.CriteriaLocalName).HasMaxLength(255);
            entity.Property(e => e.CriteriaLocalRemarks).HasMaxLength(255);
            entity.Property(e => e.CriteriaStatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CriteriaType).HasMaxLength(255);
            entity.Property(e => e.CriteriaTypeRecId).HasColumnName("CriteriaTypeRecID");
            entity.Property(e => e.CriteriasMasterRecId).HasColumnName("CriteriasMasterRecID");
            entity.Property(e => e.GraduationCountry)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsertedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.CriteriasMasterRec).WithMany(p => p.TblAdmByTermAdmissionCriteria)
                .HasForeignKey(d => d.CriteriasMasterRecId)
                .HasConstraintName("FK_CriteriaRecID");
        });

        modelBuilder.Entity<TblAdmByTermAdmissionPreference>(entity =>
        {
            entity.HasKey(e => e.ProgramPreferenceRecId).HasName("PK_tbl_ADM_AdmissionPreferenceByTerm");

            entity.ToTable("tbl_ADM_ByTerm_AdmissionPreference");

            entity.Property(e => e.AdmissionTypeRecId).HasColumnName("AdmissionTypeRecID");
            entity.Property(e => e.DegreeTypeRecId).HasColumnName("DegreeTypeRecID");
            entity.Property(e => e.InsertedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.ProgramRecId).HasColumnName("ProgramRecID");
            entity.Property(e => e.Status).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.AdmissionTypeRec).WithMany(p => p.TblAdmByTermAdmissionPreferences)
                .HasForeignKey(d => d.AdmissionTypeRecId)
                .HasConstraintName("FK_tbl_ADM_ByTerm_AdmissionPreference_tbl_MST_AdmissionTypeMaster");

            entity.HasOne(d => d.DegreeTypeRec).WithMany(p => p.TblAdmByTermAdmissionPreferences)
                .HasForeignKey(d => d.DegreeTypeRecId)
                .HasConstraintName("FK_tbl_ADM_ByTerm_AdmissionPreference_tbl_MST_DegreeTypeMaster");

            entity.HasOne(d => d.Term).WithMany(p => p.TblAdmByTermAdmissionPreferences)
                .HasForeignKey(d => d.TermId)
                .HasConstraintName("FK_tbl_ADM_ByTerm_AdmissionPreference_tbl_REG_TermMaster");
        });

        modelBuilder.Entity<TblAdmByTermAdmissionQuestion>(entity =>
        {
            entity.HasKey(e => e.QuestionsByTermRecId);

            entity.ToTable("tbl_ADM_ByTerm_AdmissionQuestions");

            entity.Property(e => e.QuestionsByTermRecId).HasColumnName("QuestionsByTermRecID");
            entity.Property(e => e.InsertedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdaetdDateTime).HasColumnType("datetime");
            entity.Property(e => e.QuestionRecId).HasColumnName("QuestionRecID");
            entity.Property(e => e.TermId).HasColumnName("TermID");

            entity.HasOne(d => d.QuestionRec).WithMany(p => p.TblAdmByTermAdmissionQuestions)
                .HasForeignKey(d => d.QuestionRecId)
                .HasConstraintName("FK_tbl_ADM_ByTerm_AdmissionQuestions_tbl_ADM_Master_AdmissionQuestions");
        });

        modelBuilder.Entity<TblAdmByTermAdmissionSchedule>(entity =>
        {
            entity.HasKey(e => e.AdmissionScheduleRecId);

            entity.ToTable("tbl_ADM_ByTerm_AdmissionSchedule");

            entity.Property(e => e.AcademicYearRecId).HasColumnName("AcademicYearRecID");
            entity.Property(e => e.AdmissionStatus)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.AdmissionTypeRecId).HasColumnName("AdmissionTypeRecID");
            entity.Property(e => e.CitizenAdmissionFee).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.CitizenAdmissionFeeVat).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.DegreeTypeRecId).HasColumnName("DegreeTypeRecID");
            entity.Property(e => e.EndDateTime).HasColumnType("datetime");
            entity.Property(e => e.ExtenssionEndDateTime).HasColumnType("datetime");
            entity.Property(e => e.FirstTuitionFeePayment).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.InsertedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdateDateTime).HasColumnType("datetime");
            entity.Property(e => e.NonCitizenAdmissionFee).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.NonCitizenAdmissionFeeVat).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ProgramRecId).HasColumnName("ProgramRecID");
            entity.Property(e => e.StartDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.AcademicYearRec).WithMany(p => p.TblAdmByTermAdmissionSchedules)
                .HasForeignKey(d => d.AcademicYearRecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ADM_ByTerm_AdmissionSchedule_tbl_REG_AcademicYear");

            entity.HasOne(d => d.AdmissionTypeRec).WithMany(p => p.TblAdmByTermAdmissionSchedules)
                .HasForeignKey(d => d.AdmissionTypeRecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ADM_ByTerm_AdmissionSchedule_tbl_MST_AdmissionTypeMaster");

            entity.HasOne(d => d.DegreeTypeRec).WithMany(p => p.TblAdmByTermAdmissionSchedules)
                .HasForeignKey(d => d.DegreeTypeRecId)
                .HasConstraintName("FK_tbl_ADM_ByTerm_AdmissionSchedule_tbl_MST_DegreeTypeMaster");

            entity.HasOne(d => d.Term).WithMany(p => p.TblAdmByTermAdmissionSchedules)
                .HasForeignKey(d => d.TermId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ADM_ByTerm_AdmissionSchedule_tbl_REG_TermMaster");
        });

        modelBuilder.Entity<TblAdmDepartmentMaster>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("PKtbl_ADM_DepartmentMaster_DepartmentId");

            entity.ToTable("tbl_ADM_DepartmentMaster");

            entity.Property(e => e.AmendDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DepartmenImage)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DepartmentCampus)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DepartmentCode)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DepartmentEngName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DepartmentLocalName)
                .HasMaxLength(100)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DepartmentShortNameEng)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.DepartmentShortNameLocal)
                .HasMaxLength(500)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TblAdmMajorMaster>(entity =>
        {
            entity.HasKey(e => e.MajorRecId);

            entity.ToTable("tbl_ADM_MajorMaster");

            entity.Property(e => e.MajorRecId).HasColumnName("MajorRecID");
            entity.Property(e => e.InsertedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.MajorEngName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MajorLocalName).HasMaxLength(100);
            entity.Property(e => e.MajorStatus)
                .IsRequired()
                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblAdmMasterAdmissionChecklist>(entity =>
        {
            entity.HasKey(e => e.ChecklistRecId);

            entity.ToTable("tbl_ADM_Master_AdmissionChecklist");

            entity.Property(e => e.ChecklistRecId).HasColumnName("ChecklistRecID");
            entity.Property(e => e.ChecklistEngName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ChecklistLoalName).HasMaxLength(50);
            entity.Property(e => e.ChecklistNotesEng)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ChecklistNotesLocal).HasMaxLength(100);
            entity.Property(e => e.ChecklistStatus)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.EffectiveFrom).HasColumnType("datetime");
            entity.Property(e => e.EffectiveTo).HasColumnType("datetime");
            entity.Property(e => e.InsertedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.CheklistTypeRec).WithMany(p => p.TblAdmMasterAdmissionChecklists)
                .HasForeignKey(d => d.CheklistTypeRecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_ADM_Master_AdmissionChecklist_tbl_MST_CheklistTypeMaster");
        });

        modelBuilder.Entity<TblAdmMasterAdmissionCriteria>(entity =>
        {
            entity.HasKey(e => e.CriteriasMasterRecId).HasName("PK_tbl_ADM_AdmissionCriteriasMaster");

            entity.ToTable("tbl_ADM_Master_AdmissionCriterias");

            entity.Property(e => e.CriteriasMasterRecId).HasColumnName("CriteriasMasterRecID");
            entity.Property(e => e.AdmissionCriteriaGroupRecId).HasColumnName("AdmissionCriteriaGroupRecID");
            entity.Property(e => e.CriteriaEngName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CriteriaEngRemarks)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.CriteriaLocalName).HasMaxLength(100);
            entity.Property(e => e.CriteriaLocalRemarks).HasMaxLength(1000);
            entity.Property(e => e.CriteriaStatus)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.EffectiveFrom).HasColumnType("datetime");
            entity.Property(e => e.EffectiveTo).HasColumnType("datetime");
            entity.Property(e => e.InsertedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.AdmissionCriteriaGroupRec).WithMany(p => p.TblAdmMasterAdmissionCriteria)
                .HasForeignKey(d => d.AdmissionCriteriaGroupRecId)
                .HasConstraintName("FK_AdmissionCriteriaGroup");
        });

        modelBuilder.Entity<TblAdmMasterAdmissionCriteriaGroup>(entity =>
        {
            entity.HasKey(e => e.AdmissionCriteriaGroupRecId).HasName("PK_tbl_ADM_AdmissionCriteriaGroup");

            entity.ToTable("tbl_ADM_Master_AdmissionCriteriaGroup");

            entity.Property(e => e.AdmissionCriteriaGroupRecId).HasColumnName("AdmissionCriteriaGroupRecID");
            entity.Property(e => e.CriteriaGroupEngName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CriteriaGroupLocalName).HasMaxLength(100);
            entity.Property(e => e.CriteriaGroupStatus)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.InsertedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblAdmMasterAdmissionCriteriaType>(entity =>
        {
            entity.HasKey(e => e.CriteriaTypeRecId).HasName("PK_tbl_MST_AdmissionCriteriaType");

            entity.ToTable("tbl_ADM_Master_AdmissionCriteriaType");

            entity.Property(e => e.CriteriaTypeRecId).HasColumnName("CriteriaTypeRecID");
            entity.Property(e => e.CriteriaTypeEngName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CriteriaTypeLocalName).HasMaxLength(100);
            entity.Property(e => e.InsertedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblAdmMasterAdmissionQuestion>(entity =>
        {
            entity.HasKey(e => e.QuestionRecId).HasName("PK_tbl_ADM_AdmissionQuestionsMaster");

            entity.ToTable("tbl_ADM_Master_AdmissionQuestions");

            entity.Property(e => e.QuestionRecId).HasColumnName("QuestionRecID");
            entity.Property(e => e.InsertedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.QuestionEngName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.QuestionLocalName).HasMaxLength(250);
            entity.Property(e => e.QuestionStatus)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.QuestionType)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblAdmMasterAdmissionQuestionsDetail>(entity =>
        {
            entity.HasKey(e => e.QuestionsDetailsRecId);

            entity.ToTable("tbl_ADM_Master_AdmissionQuestionsDetails");

            entity.Property(e => e.QuestionsDetailsRecId)
                .ValueGeneratedNever()
                .HasColumnName("QuestionsDetailsRecID");
            entity.Property(e => e.AnswearEngName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AnswearLocalName).HasMaxLength(250);
            entity.Property(e => e.AnswearStatus)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.InsertedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedBy).HasColumnName("lastUpdatedBy");
            entity.Property(e => e.LastUpdatedDateTime)
                .HasColumnType("datetime")
                .HasColumnName("lastUpdatedDateTime");
            entity.Property(e => e.QuestionRecId).HasColumnName("QuestionRecID");
            entity.Property(e => e.QuestionsDetailsOrder)
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.QuestionRec).WithMany(p => p.TblAdmMasterAdmissionQuestionsDetails)
                .HasForeignKey(d => d.QuestionRecId)
                .HasConstraintName("FK_tbl_ADM_Master_AdmissionQuestionsDetails_tbl_ADM_Master_AdmissionQuestionsDetails");
        });

        modelBuilder.Entity<TblAdmProgramStructure>(entity =>
        {
            entity.HasKey(e => e.ProgramStructureId);

            entity.ToTable("tbl_ADM_ProgramStructure");

            entity.Property(e => e.InsertedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.ProgramRecId).HasColumnName("ProgramRecID");
            entity.Property(e => e.Pslevel).HasColumnName("PSLevel");
            entity.Property(e => e.Psyear).HasColumnName("PSYear");
        });

        modelBuilder.Entity<TblFiaFeeProjection>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_FIA_FeeProjection");

            entity.Property(e => e.FinlaVatamont).HasColumnName("finlaVatamont");
            entity.Property(e => e.InsertedDateTime).HasColumnType("datetime");
            entity.Property(e => e.Issponsor)
                .HasMaxLength(255)
                .HasColumnName("ISSponsor");
            entity.Property(e => e.LastUpdatedBy).HasMaxLength(255);
            entity.Property(e => e.LastUpdatedDateTime).HasMaxLength(255);
            entity.Property(e => e.ProgramYear).HasColumnName("ProgramYEAR");
            entity.Property(e => e.RecId).HasColumnName("RecID");
            entity.Property(e => e.Status).HasMaxLength(255);
            entity.Property(e => e.StudentId).HasMaxLength(255);
            entity.Property(e => e.TermName).HasMaxLength(255);
        });

        modelBuilder.Entity<TblFiaProgramFeeStructure>(entity =>
        {
            entity.HasKey(e => e.ProgramFeeId).HasName("PK_tbl_ADM_ProgramFeeStructure");

            entity.ToTable("tbl_FIA_ProgramFeeStructure");

            entity.Property(e => e.Ayid).HasColumnName("AYId");
            entity.Property(e => e.InsertedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.ProgramRecId).HasColumnName("ProgramRecID");
            entity.Property(e => e.SemesterFee).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<TblMstAddressTypeMaster>(entity =>
        {
            entity.HasKey(e => e.AddressTypeRecId);

            entity.ToTable("tbl_MST_AddressTypeMaster");

            entity.Property(e => e.AddressTypeRecId).HasColumnName("AddressTypeRecID");
            entity.Property(e => e.AddressTypeDescriptionEngName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AddressTypeDescriptionLocalName).HasMaxLength(250);
            entity.Property(e => e.AddressTypeEngName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.AddressTypeLocalName).HasMaxLength(250);
            entity.Property(e => e.InsertedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblMstAdmissionTypeMaster>(entity =>
        {
            entity.HasKey(e => e.AdmissionTypeRecId).HasName("PK_tbl_ADM_AdmissionTypeMaster");

            entity.ToTable("tbl_MST_AdmissionTypeMaster");

            entity.Property(e => e.AdmissionTypeRecId).HasColumnName("AdmissionTypeRecID");
            entity.Property(e => e.AdmissionTypeEngName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AdmissionTypeLocalName).HasMaxLength(100);
            entity.Property(e => e.AdmissionTypeStatus)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.InsertedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblMstApplicationStatus>(entity =>
        {
            entity.HasKey(e => e.ApplicationStatusRecId);

            entity.ToTable("tbl_MST_ApplicationStatus");

            entity.Property(e => e.ApplicationStatusRecId).HasColumnName("ApplicationStatusRecID");
            entity.Property(e => e.ActionByUserRol)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ActionNameEng)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ActionNameLocal).HasMaxLength(255);
            entity.Property(e => e.ActionRequieredDays)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsertedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.NextActionOperator)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NextActionSequanceOne)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NextActionSequanceTwo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NotifyUserRol)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SendSms).HasColumnName("SendSMS");
        });

        modelBuilder.Entity<TblMstAttendanceAction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_MST_AttendanceActions");

            entity.Property(e => e.GradeClass).HasMaxLength(255);
            entity.Property(e => e.GradeCodeEng)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GradingDefintionActionEngName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GradingDefintionActionLocalName).HasMaxLength(255);
            entity.Property(e => e.GradingDefintionActionRecId).HasColumnName("GradingDefintionActionRecID");
            entity.Property(e => e.InsertDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblMstAttendanceComponent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_MST_AttendanceComponent");

            entity.Property(e => e.AttendanceComponentRecId).HasColumnName("AttendanceComponentRecID");
            entity.Property(e => e.ComponenetCode).HasMaxLength(255);
            entity.Property(e => e.ComponenetEngName).HasMaxLength(255);
            entity.Property(e => e.ComponenetLocalName).HasMaxLength(255);
            entity.Property(e => e.InsertDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblMstAttendanceMethod>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_MST_AttendanceMethod");

            entity.Property(e => e.AttendanceMethodLocalName).HasMaxLength(255);
            entity.Property(e => e.AttendanceMethodName).HasMaxLength(255);
            entity.Property(e => e.InsertDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblMstAttendanceWarningRule>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_MST_AttendanceWarningRules");

            entity.Property(e => e.Formula).HasMaxLength(255);
            entity.Property(e => e.GradeLetter).HasMaxLength(255);
            entity.Property(e => e.IncludeExecuseRequestInFormula).HasMaxLength(255);
            entity.Property(e => e.InsertDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.WarningColor).HasMaxLength(255);
        });

        modelBuilder.Entity<TblMstAutoNotification>(entity =>
        {
            entity.HasKey(e => e.AutoNotificationRecId);

            entity.ToTable("tbl_MST_AutoNotifications");

            entity.Property(e => e.ApplicationsStatusRecId).HasMaxLength(255);
            entity.Property(e => e.EmailMessageEng).IsUnicode(false);
            entity.Property(e => e.SmsmessageEng)
                .IsUnicode(false)
                .HasColumnName("SMSMessageEng");
            entity.Property(e => e.SmsmessageLocal)
                .HasMaxLength(255)
                .HasColumnName("SMSMessageLocal");
            entity.Property(e => e.WhatsappMessageEng).IsUnicode(false);
        });

        modelBuilder.Entity<TblMstCampusMaster>(entity =>
        {
            entity.HasKey(e => e.CampusRecId);

            entity.ToTable("tbl_MST_CampusMaster");

            entity.Property(e => e.CampusRecId).HasColumnName("CampusRecID");
            entity.Property(e => e.CampusAddressEng).HasMaxLength(255);
            entity.Property(e => e.CampusAddressLocal).HasMaxLength(255);
            entity.Property(e => e.CampusCode).HasMaxLength(255);
            entity.Property(e => e.CampusEngName).HasMaxLength(255);
            entity.Property(e => e.CampusLocalName).HasMaxLength(255);
            entity.Property(e => e.CampusType).HasMaxLength(255);
            entity.Property(e => e.InsertDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblMstCheklistTypeMaster>(entity =>
        {
            entity.HasKey(e => e.CheklistTypeRecId);

            entity.ToTable("tbl_MST_CheklistTypeMaster");

            entity.Property(e => e.CheklistTypeEngName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.CheklistTypeLocalName).HasMaxLength(150);
            entity.Property(e => e.InsertedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblMstCitizensTypeMaster>(entity =>
        {
            entity.HasKey(e => e.CitizensTypeRecId);

            entity.ToTable("tbl_MST_CitizensTypeMaster");

            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.CitizensTypeEngName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CitizensTypeLocalName).HasMaxLength(100);
            entity.Property(e => e.CitizensTypeStatus)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TblMstCity>(entity =>
        {
            entity.HasKey(e => e.CityId);

            entity.ToTable("tbl_MST_Cities");

            entity.Property(e => e.CityId).ValueGeneratedNever();
            entity.Property(e => e.CityName).HasMaxLength(255);
            entity.Property(e => e.CityNameLocal).HasMaxLength(255);
            entity.Property(e => e.InsertedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblMstCollege>(entity =>
        {
            entity.HasKey(e => e.CollegeRecId);

            entity.ToTable("tbl_MST_Colleges");

            entity.Property(e => e.CampusRecId).HasColumnName("CampusRecID");
            entity.Property(e => e.CollegeCareer).HasMaxLength(255);
            entity.Property(e => e.CollegeCityEngName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CollegeCityLocalName).HasMaxLength(255);
            entity.Property(e => e.CollegeCode).HasMaxLength(255);
            entity.Property(e => e.CollegeEngName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CollegeLocalName).HasMaxLength(255);
            entity.Property(e => e.CollegeLocallanguage).HasMaxLength(255);
            entity.Property(e => e.CollegeType).HasMaxLength(255);
            entity.Property(e => e.InsertDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.CampusRec).WithMany(p => p.TblMstColleges)
                .HasForeignKey(d => d.CampusRecId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_MST_Colleges_tbl_MST_CampusMaster");
        });

        modelBuilder.Entity<TblMstCollegeGrading>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_MST_CollegeGrading");

            entity.Property(e => e.AmendBy).HasMaxLength(255);
            entity.Property(e => e.AmendDateTime).HasMaxLength(255);
            entity.Property(e => e.GradeEngName).HasMaxLength(255);
            entity.Property(e => e.GradeLocalName).HasMaxLength(255);
            entity.Property(e => e.InsertBy).HasMaxLength(255);
            entity.Property(e => e.InsertDateTime).HasMaxLength(255);
            entity.Property(e => e.InsertDateTime1).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblMstCountryMaster>(entity =>
        {
            entity.HasKey(e => e.CountryRecId);

            entity.ToTable("tbl_MST_CountryMaster");

            entity.Property(e => e.CountryRecId).HasColumnName("CountryRecID");
            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.CountryCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CountryIdstartsNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CountryIDStartsNo");
            entity.Property(e => e.CountryName).HasMaxLength(255);
            entity.Property(e => e.CountryNameLocal).HasMaxLength(255);
            entity.Property(e => e.Idpattern)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("IDPattern");
            entity.Property(e => e.InsertDateTime).HasColumnType("datetime");
            entity.Property(e => e.Moecode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("MOECODE");
            entity.Property(e => e.NationalityEngName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NationalityLocalName).HasMaxLength(255);
        });

        modelBuilder.Entity<TblMstDegreeTypeMaster>(entity =>
        {
            entity.HasKey(e => e.DegreeTypeRecId).HasName("PK_tbl_ADM_DegreeTypeMaster");

            entity.ToTable("tbl_MST_DegreeTypeMaster");

            entity.Property(e => e.DegreeTypeRecId).HasColumnName("DegreeTypeRecID");
            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.DegreeTypeCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DegreeTypeEngDescription)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.DegreeTypeEngName).HasMaxLength(100);
            entity.Property(e => e.DegreeTypeLocalName).HasMaxLength(100);
            entity.Property(e => e.DegreeTypePreRequisites)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.DegreeTypelocalDescription).HasMaxLength(500);
            entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Mohecode)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MOHECode");
        });

        modelBuilder.Entity<TblMstErrorMessageMaster>(entity =>
        {
            entity.HasKey(e => e.ErrorMessageRecId);

            entity.ToTable("tbl_MST_ErrorMessageMaster");

            entity.HasIndex(e => e.ErrorMessageCode, "IX_tbl_MST_ErrorMessageMasterErrorMessageCode");

            entity.Property(e => e.ErrorMessageRecId).HasColumnName("ErrorMessageRecID");
            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.ErrorMessageCode)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ErrorMessageEng)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ErrorMessageLocalName).HasMaxLength(500);
            entity.Property(e => e.ErrorMessageStatus)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TblMstFeeTypeMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_MST_FeeTypeMaster");

            entity.Property(e => e.FeeTypeTitle)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FeeTypeTitleLocal).HasMaxLength(255);
            entity.Property(e => e.InsertedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblMstGenderMaster>(entity =>
        {
            entity.HasKey(e => e.GenderRecId);

            entity.ToTable("tbl_MST_GenderMaster");

            entity.Property(e => e.GenderRecId).HasColumnName("GenderRecID");
            entity.Property(e => e.GenderName).HasMaxLength(100);
            entity.Property(e => e.InsertedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .IsRequired()
                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblMstGradingDefintion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_MST_GradingDefintion");

            entity.Property(e => e.CourseGradeEngName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CourseGradeLocalName).HasMaxLength(255);
            entity.Property(e => e.GradeClass).HasMaxLength(255);
            entity.Property(e => e.GradeCodeEng)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GradeCodeLocal).HasMaxLength(255);
            entity.Property(e => e.InsertDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblMstHighSchoolTypeMaster>(entity =>
        {
            entity.HasKey(e => e.HighSchoolTypeRecId).HasName("PK_tbl_ADM_HighSchoolTypeMaster");

            entity.ToTable("tbl_MST_HighSchoolTypeMaster");

            entity.Property(e => e.HighSchoolTypeRecId).HasColumnName("HighSchoolTypeRecID");
            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.HighSchoolTypeEnName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HighSchoolTypeLocalName).HasMaxLength(200);
            entity.Property(e => e.HighSchoolTypeStatus)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TblMstInstruction>(entity =>
        {
            entity.HasKey(e => e.InstructionsRecId);

            entity.ToTable("tbl_MST_Instructions");

            entity.Property(e => e.InstructionsRecId).ValueGeneratedNever();
            entity.Property(e => e.InsertedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InstructionsEng).IsUnicode(false);
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblMstMajorType>(entity =>
        {
            entity.HasKey(e => e.MajorTypeRecId);

            entity.ToTable("tbl_MST_MajorType");

            entity.Property(e => e.MajorTypeRecId).HasColumnName("MajorTypeRecID");
            entity.Property(e => e.InsertDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.MajorTypeEngName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MajorTypeLocalName).HasMaxLength(255);
        });

        modelBuilder.Entity<TblMstNotifcationsType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_MST_NotifcationsType");

            entity.Property(e => e.Color)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.InsertedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdaetdDateTime).HasColumnType("datetime");
            entity.Property(e => e.NotificationTypeId).HasColumnName("NotificationTypeID");
            entity.Property(e => e.TypeNameEng)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TypeNameLocal).HasMaxLength(255);
        });

        modelBuilder.Entity<TblMstNotificationsMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_MST_NotificationsMaster");

            entity.Property(e => e.ContentEng)
                .HasMaxLength(2500)
                .IsUnicode(false);
            entity.Property(e => e.ContentLocal).HasMaxLength(2500);
            entity.Property(e => e.InsertedDateTime).HasColumnType("datetime");
            entity.Property(e => e.NotificationId).HasColumnName("NotificationID");
            entity.Property(e => e.NotificationTypeId).HasColumnName("NotificationTypeID");
            entity.Property(e => e.ReadDateTime).HasColumnType("datetime");
            entity.Property(e => e.SentDateTime).HasColumnType("datetime");
            entity.Property(e => e.SubjectEng)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SubjectLocal).HasMaxLength(255);
        });

        modelBuilder.Entity<TblMstOrganazationCatogery>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_MST_OrganazationCatogery");

            entity.Property(e => e.CareerTypeEngName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CareerTypeLocalName).HasMaxLength(255);
            entity.Property(e => e.InsertDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.OrganazationCatogeryRecId).HasColumnName("OrganazationCatogeryRecID");
        });

        modelBuilder.Entity<TblMstOrganazationMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_MST_OrganazationMaster");

            entity.Property(e => e.InsertDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.OrganazationCatogeryRecId).HasColumnName("OrganazationCatogeryRecID");
            entity.Property(e => e.OrganizationCodeEng).HasMaxLength(255);
            entity.Property(e => e.OrganizationCodeLocal)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationEngName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.OrganizationLocalName).HasMaxLength(255);
            entity.Property(e => e.OrganizationRecId).HasColumnName("OrganizationRecID");
        });

        modelBuilder.Entity<TblMstOrganazationType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_MST_OrganazationType");

            entity.Property(e => e.InsertDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.OrganazationTypeEngName).HasMaxLength(255);
            entity.Property(e => e.OrganazationTypeLocalName).HasMaxLength(255);
            entity.Property(e => e.RecId).HasColumnName("RecID ");
        });

        modelBuilder.Entity<TblMstPrefferedLanguage>(entity =>
        {
            entity.HasKey(e => e.PrefferedLanguageRecId);

            entity.ToTable("tbl_MST_PrefferedLanguage");

            entity.Property(e => e.PrefferedLanguageRecId).HasColumnName("PrefferedLanguageRecID");
            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PrefferedLanguageEngName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.PrefferedLanguageLocalName).HasMaxLength(150);
            entity.Property(e => e.PrefferedLanguageStatus)
                .IsRequired()
                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblMstProgramMaster>(entity =>
        {
            entity.HasKey(e => e.ProgramRecId);

            entity.ToTable("tbl_MST_ProgramMaster");

            entity.Property(e => e.ProgramRecId).HasColumnName("ProgramRecID");
            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.CampusRecId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CampusRecID");
            entity.Property(e => e.DegreeRecId).HasColumnName("DegreeRecID");
            entity.Property(e => e.ExternaMajorCode).HasMaxLength(50);
            entity.Property(e => e.ExternaSascedl).HasColumnName("ExternaSASCEDL");
            entity.Property(e => e.ExternaSascedp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExternaSASCEDP");
            entity.Property(e => e.ExternaStudyTypeCode).HasMaxLength(50);
            entity.Property(e => e.ExternalCollegeCode).HasMaxLength(50);
            entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MajorId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MajorID");
            entity.Property(e => e.MajorRecId).HasColumnName("MajorRecID");
            entity.Property(e => e.ProgramCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProgramColor).HasMaxLength(200);
            entity.Property(e => e.ProgramDurationInRebatYears)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProgramDurationInSemesters)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProgramDurationInYears)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProgramEngName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProgramFodid).HasColumnName("ProgramFODId");
            entity.Property(e => e.ProgramLocalName).HasMaxLength(100);
            entity.Property(e => e.ProgramShortDisplayEng)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ProgramShortDisplayLocal).HasMaxLength(100);
            entity.Property(e => e.ProgramStatus)
                .IsRequired()
                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblMstProgramStudyType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_MST_ProgramStudyType");

            entity.Property(e => e.Indicator)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.InsertDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.ProgramStudyTypeIndicator)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ProgramStudyTypeLocalName).HasMaxLength(255);
            entity.Property(e => e.ProgramStudyTypeRecId).HasColumnName("ProgramStudyTypeRecID");
        });

        modelBuilder.Entity<TblMstProvince>(entity =>
        {
            entity.HasKey(e => e.ProvinceId).HasName("PK_tbl_MST_Province$");

            entity.ToTable("tbl_MST_Province");

            entity.Property(e => e.ProvinceId).ValueGeneratedNever();
            entity.Property(e => e.InsertedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.ProvinceName).HasMaxLength(255);
            entity.Property(e => e.ProvinceNameLocal).HasMaxLength(255);
        });

        modelBuilder.Entity<TblMstRecordStatus>(entity =>
        {
            entity.HasKey(e => e.RecordStatusRecId);

            entity.ToTable("tbl_MST_RecordStatus");

            entity.Property(e => e.RecordStatusRecId).HasColumnName("RecordStatusRecID");
            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RecordStatusEngName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RecordStatusLocalName).HasMaxLength(50);
        });

        modelBuilder.Entity<TblMstRegistrationType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_MST_RegistrationType");

            entity.Property(e => e.InsertDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.RegistrationEngNameType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.RegistrationLocalNameType).HasMaxLength(255);
            entity.Property(e => e.RegistrationTypeRecId).HasColumnName("RegistrationTypeRecID");
        });

        modelBuilder.Entity<TblMstRelationshipMaster>(entity =>
        {
            entity.HasKey(e => e.RelationShipRecId);

            entity.ToTable("tbl_MST_RelationshipMaster");

            entity.Property(e => e.RelationShipRecId).HasColumnName("RelationShipRecID");
            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RelationShipCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RelationShipEngName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RelationShipLocalName).HasMaxLength(50);
            entity.Property(e => e.RelationShipStatus)
                .IsRequired()
                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblMstReligionMaster>(entity =>
        {
            entity.HasKey(e => e.MinstryCode);

            entity.ToTable("tbl_MST_ReligionMaster");

            entity.Property(e => e.MinstryCode)
                .ValueGeneratedNever()
                .HasColumnName("Minstry_Code");
            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.ArabicDescription)
                .HasMaxLength(255)
                .HasColumnName("Arabic_Description");
            entity.Property(e => e.EnglishDescription)
                .HasMaxLength(255)
                .HasColumnName("English_Description");
            entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ReligionStatus)
                .IsRequired()
                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblMstSmsmaster>(entity =>
        {
            entity.HasKey(e => e.SmsRecId);

            entity.ToTable("tbl_MST_SMSMaster");

            entity.Property(e => e.SmsRecId).HasColumnName("SmsRecID");
            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.ApplicationStatusTypeRecId).HasColumnName("ApplicationStatusTypeRecID");
            entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SmsengText)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("SMSEngText");
            entity.Property(e => e.SmslocalText).HasColumnName("SMSLocalText");
        });

        modelBuilder.Entity<TblMstStaffMaster>(entity =>
        {
            entity.HasKey(e => e.StaffId);

            entity.ToTable("tbl_MST_StaffMaster");

            entity.Property(e => e.AcademicRankCode)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.AppointmentTypeCode)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.BirthPlaceCode)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CollegeCode)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CollegeEmailAddress).HasMaxLength(100);
            entity.Property(e => e.DateOfBirth).HasColumnType("date");
            entity.Property(e => e.Employeelocation)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.EndWorkingDate).HasColumnType("date");
            entity.Property(e => e.Fodid).HasColumnName("FODId");
            entity.Property(e => e.FunctionalTasks)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("functionalTasks");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.GrandFatherName).HasMaxLength(50);
            entity.Property(e => e.HiringDate).HasColumnType("date");
            entity.Property(e => e.HomeTelePhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HrCategory)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("HR_Category");
            entity.Property(e => e.Iban)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IBAN");
            entity.Property(e => e.Inaddress)
                .HasMaxLength(100)
                .HasColumnName("INAddress");
            entity.Property(e => e.IncityId).HasColumnName("INCityId");
            entity.Property(e => e.IncountryId).HasColumnName("INCountryId");
            entity.Property(e => e.InprovinceId).HasColumnName("INProvinceId");
            entity.Property(e => e.InsertDateTime).HasColumnType("datetime");
            entity.Property(e => e.InzipCode).HasColumnName("INZipCode");
            entity.Property(e => e.IsPartOfStudentCommittee).HasDefaultValueSql("((0))");
            entity.Property(e => e.ItsupportGroupId).HasColumnName("ITSupportGroupId");
            entity.Property(e => e.JobType)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.JoiningDate).HasColumnType("date");
            entity.Property(e => e.Maaddress)
                .HasMaxLength(100)
                .HasColumnName("MAAddress");
            entity.Property(e => e.MacityId).HasColumnName("MACityId");
            entity.Property(e => e.MacountryId).HasColumnName("MACountryId");
            entity.Property(e => e.MajorCode)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MaprovinceId).HasColumnName("MAProvinceId");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.MazipCode).HasColumnName("MAZipCode");
            entity.Property(e => e.MinorCode)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name1).HasMaxLength(50);
            entity.Property(e => e.Name2).HasMaxLength(50);
            entity.Property(e => e.Name3).HasMaxLength(50);
            entity.Property(e => e.NationalId).HasMaxLength(50);
            entity.Property(e => e.NationalIdExpiryDate).HasColumnType("date");
            entity.Property(e => e.NationalIdIssueDate).HasColumnType("date");
            entity.Property(e => e.NationalIdIssuePlace).HasMaxLength(50);
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.OfficeLocation).HasMaxLength(500);
            entity.Property(e => e.OfficeTelephone).HasMaxLength(500);
            entity.Property(e => e.PersonalEmailAddress).HasMaxLength(100);
            entity.Property(e => e.PlaceOfBirth).HasMaxLength(50);
            entity.Property(e => e.PostalAddress)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Prefix).HasMaxLength(50);
            entity.Property(e => e.Profession)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.ProfilePicFileName).HasMaxLength(50);
            entity.Property(e => e.ProfilePicPath)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Religion).HasMaxLength(50);
            entity.Property(e => e.RoleNameEnglish)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SpecialNeedCode)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.StartWorkingDate)
                .HasColumnType("date")
                .HasColumnName("StartWorkingDAte");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WorkTelephoneExtentionNumber)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.WorkTelephoneNumber)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.ZipCode)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblMstStateMaster>(entity =>
        {
            entity.HasKey(e => e.StateRecId);

            entity.ToTable("tbl_MST_StateMaster");

            entity.Property(e => e.StateRecId).HasColumnName("StateRecID");
            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.CountryRecId).HasColumnName("CountryRecID");
            entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.StateCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StateName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StateNameLocal).HasMaxLength(50);
            entity.Property(e => e.StateStatus)
                .IsRequired()
                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblMstStudentTypeMaster>(entity =>
        {
            entity.HasKey(e => e.StudentTypeRecId).HasName("PK_tbl_ADM_StudentTypeMaster");

            entity.ToTable("tbl_MST_StudentTypeMaster");

            entity.Property(e => e.StudentTypeRecId).HasColumnName("StudentTypeRecID");
            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NextStudentTypeRecId).HasColumnName("NextStudentTypeRecID");
            entity.Property(e => e.StudentTypeCode).HasMaxLength(50);
            entity.Property(e => e.StudentTypeEngName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudentTypeLocalName).HasMaxLength(50);
            entity.Property(e => e.StudentTypeStatus)
                .IsRequired()
                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblMstStudyCenterMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_MST_StudyCenterMaster$");

            entity.Property(e => e.CityRecId).HasColumnName("CityRecID");
            entity.Property(e => e.InsertedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.StudyCenterDescEng)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.StudyCenterDescLocal).HasMaxLength(255);
            entity.Property(e => e.StudyCenterEngName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.StudyCenterExternalCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StudyCenterLocalName).HasMaxLength(255);
            entity.Property(e => e.StudyCenterType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblMstTermsType>(entity =>
        {
            entity.HasKey(e => e.TermTypeRecId);

            entity.ToTable("tbl_MST_TermsType");

            entity.Property(e => e.TermTypeRecId)
                .ValueGeneratedNever()
                .HasColumnName("TermTypeRecID");
            entity.Property(e => e.InsertDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.TermTypeEngName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TermTypeLocalName).HasMaxLength(255);
        });

        modelBuilder.Entity<TblMstVisaMaster>(entity =>
        {
            entity.HasKey(e => e.VisaTypeRecId);

            entity.ToTable("tbl_MST_VisaMaster");

            entity.Property(e => e.VisaTypeRecId).HasColumnName("VisaTypeRecID");
            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.VisaTypeCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.VisaTypeEngName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VisaTypeLocalName).HasMaxLength(100);
            entity.Property(e => e.VisaTypeStatus)
                .IsRequired()
                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblRegAcademicYear>(entity =>
        {
            entity.HasKey(e => e.AcademicYearRecId).HasName("PK_tbl_ADM_AcademicYear");

            entity.ToTable("tbl_REG_AcademicYear");

            entity.HasIndex(e => new { e.AystartYear, e.AyendYear, e.Aystatus }, "IX_tbl_ADM_AcademicYearStartendYearStatus");

            entity.Property(e => e.AcademicYearRecId).HasColumnName("AcademicYearRecID");
            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.AyendDate)
                .HasColumnType("date")
                .HasColumnName("AYEndDate");
            entity.Property(e => e.AyendYear).HasColumnName("AYEndYear");
            entity.Property(e => e.AyendYear1Local)
                .HasMaxLength(10)
                .HasColumnName("AYEndYear1Local");
            entity.Property(e => e.AystartDate)
                .HasColumnType("date")
                .HasColumnName("AYStartDate");
            entity.Property(e => e.AystartYear).HasColumnName("AYStartYear");
            entity.Property(e => e.AystartYearLocal)
                .HasMaxLength(10)
                .HasColumnName("AYStartYearLocal");
            entity.Property(e => e.Aystatus)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("AYStatus");
            entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsAyeventCopied).HasColumnName("IsAYEventCopied");
        });

        modelBuilder.Entity<TblRegTermMaster>(entity =>
        {
            entity.HasKey(e => e.TermId);

            entity.ToTable("tbl_REG_TermMaster");

            entity.Property(e => e.TermId).ValueGeneratedNever();
            entity.Property(e => e.AmendDateAndTimeTime).HasColumnType("datetime");
            entity.Property(e => e.AttendacneFormula)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CalendarEventPublisheDateAndTime).HasColumnType("datetime");
            entity.Property(e => e.ClassesEndDateAndTime).HasColumnType("datetime");
            entity.Property(e => e.ClassesStartDateAndTime).HasColumnType("datetime");
            entity.Property(e => e.Crncapacity).HasColumnName("CRNCapacity");
            entity.Property(e => e.FinalExamEndDateAndTime).HasColumnType("datetime");
            entity.Property(e => e.FinalExamStartDateAndTime).HasColumnType("datetime");
            entity.Property(e => e.FinalGradeEntryEndtDateAndTime).HasColumnType("datetime");
            entity.Property(e => e.FinalGradeEntryStartDateAndTime).HasColumnType("datetime");
            entity.Property(e => e.GradePublishingDateAndTime).HasColumnType("datetime");
            entity.Property(e => e.GradeSubmissionendEndDateAndTime).HasColumnType("datetime");
            entity.Property(e => e.GradeSubmissionendStartDateAndTime).HasColumnType("datetime");
            entity.Property(e => e.InsertDateAndTimeTime).HasColumnType("datetime");
            entity.Property(e => e.IsDhlpublished).HasColumnName("IsDHLPublished");
            entity.Property(e => e.IsDngradesPublished).HasColumnName("IsDNGradesPublished");
            entity.Property(e => e.IsTermExcludeFromCgpa).HasColumnName("IsTermExcludeFromCGPA");
            entity.Property(e => e.MidTermSubmissionEndDateAndTime).HasColumnType("datetime");
            entity.Property(e => e.MidTermSubmissionStarDateAndTime).HasColumnType("datetime");
            entity.Property(e => e.MidtermEntryFromDateAndTime).HasColumnType("datetime");
            entity.Property(e => e.MidtermEntryToDateAndTime).HasColumnType("datetime");
            entity.Property(e => e.OtherPreFinalGradeEntryEndDateAndTime).HasColumnType("datetime");
            entity.Property(e => e.OtherPreFinalGradeEntryStartDateAndTime).HasColumnType("datetime");
            entity.Property(e => e.TermEndDateAndTime).HasColumnType("datetime");
            entity.Property(e => e.TermLocalName).HasMaxLength(255);
            entity.Property(e => e.TermName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TermStartDateAndTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblSsaApplicationUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_tbl_SSA_ApplicationUser");

            entity.ToTable("tbl_SSA_ApplicationUsers");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.AltranateUserName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress).HasMaxLength(200);
            entity.Property(e => e.FatherNameEng)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FatherNameLocal).HasMaxLength(255);
            entity.Property(e => e.FirstNameEng)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FirstNameLocal).HasMaxLength(255);
            entity.Property(e => e.GrandFatherNameEng)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.GrandFatherNameLocal).HasMaxLength(255);
            entity.Property(e => e.InsertedDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LastNameEng)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastNameLocal).HasMaxLength(255);
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.Mobile).HasMaxLength(40);
            entity.Property(e => e.NationalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NationalID");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Prefix)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProfilePic).HasColumnType("image");
            entity.Property(e => e.ProfilePin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ProfilePIN");
            entity.Property(e => e.ProfilePinexpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("ProfilePINExpiryDate");
            entity.Property(e => e.ProfilePinupdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("ProfilePINUpdatedDate");
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.UserPassword).HasMaxLength(256);
            entity.Property(e => e.UserType)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSsaCapabilityControlsMaster>(entity =>
        {
            entity.HasKey(e => e.CapabilityControlsRecId);

            entity.ToTable("tbl_SSA_CapabilityControlsMaster");

            entity.Property(e => e.CapabilityControlsRecId).ValueGeneratedNever();
            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.CapabilityControlsControlName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CapabilityControlsDescEng)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CapabilityControlsDescLocal).HasMaxLength(50);
            entity.Property(e => e.CapabilityControlsName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CapabilityControlsPhysicalPath)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CapabilityControlsRelativePath)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CapabilityControlsStatus).HasDefaultValueSql("((1))");
            entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.CapabilityRec).WithMany(p => p.TblSsaCapabilityControlsMasters)
                .HasForeignKey(d => d.CapabilityRecId)
                .HasConstraintName("FK_tbl_SSA_CapabilityControlsMaster_tbl_SSA_CapabilityMaster");
        });

        modelBuilder.Entity<TblSsaCapabilityMaster>(entity =>
        {
            entity.HasKey(e => e.CapabilityRecId);

            entity.ToTable("tbl_SSA_CapabilityMaster");

            entity.Property(e => e.CapabilityRecId).ValueGeneratedNever();
            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.CapabilityControlName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CapabilityDescEng)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CapabilityDescLocal).HasMaxLength(50);
            entity.Property(e => e.CapabilityName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CapabilityPhysicalPath)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CapabilityRelativePath)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CapabilityStatus).HasDefaultValueSql("((1))");
            entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.ModuleRec).WithMany(p => p.TblSsaCapabilityMasters)
                .HasForeignKey(d => d.ModuleRecId)
                .HasConstraintName("FK_tbl_SSA_CapabilityMaster_tbl_SSA_ModuleMaster");
        });

        modelBuilder.Entity<TblSsaModuleMaster>(entity =>
        {
            entity.HasKey(e => e.ModuleRecId);

            entity.ToTable("tbl_SSA_ModuleMaster");

            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModuleControlName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModuleDescEng)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModuleDescLocal).HasMaxLength(50);
            entity.Property(e => e.ModuleName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ModulePhysicalPath)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModuleRelativePath)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ModuleStatus).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TblSsaRoleCategory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tbl_SSA_RoleCategory");

            entity.Property(e => e.InsertedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.RoleCategoryId).ValueGeneratedOnAdd();
            entity.Property(e => e.RoleCategoryName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TblSsaRoleMaster>(entity =>
        {
            entity.HasKey(e => e.RoleRecId);

            entity.ToTable("tbl_SSA_RoleMaster");

            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsOtpreqForLogin).HasColumnName("IsOTPReqForLogin");
            entity.Property(e => e.RoleDescEnglish)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RoleDescLocal).HasMaxLength(100);
            entity.Property(e => e.RoleNameEnglish)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RoleNameLocal).HasMaxLength(50);
        });

        modelBuilder.Entity<TblSsaStaffMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tbl_SSA_StaffMaster");

            entity.Property(e => e.AcademicRankCode).HasMaxLength(255);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.EmployeeId).HasMaxLength(255);
            entity.Property(e => e.HoDid)
                .HasMaxLength(255)
                .HasColumnName("HoDId");
            entity.Property(e => e.HomeAddress).HasMaxLength(255);
            entity.Property(e => e.HomeTelePhoneNumber).HasMaxLength(255);
            entity.Property(e => e.HomeZipCode).HasMaxLength(255);
            entity.Property(e => e.InsertedDateTime).HasColumnType("datetime");
            entity.Property(e => e.IsSpecialNeeds).HasMaxLength(255);
            entity.Property(e => e.LastUpdatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.LocalAddress).HasMaxLength(255);
            entity.Property(e => e.LocalZipCode).HasMaxLength(255);
            entity.Property(e => e.OfficeLocation).HasMaxLength(255);
            entity.Property(e => e.OfficeTelephone).HasMaxLength(255);
            entity.Property(e => e.PersonalEmailAddress)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PlaceOfBirth).HasMaxLength(255);
            entity.Property(e => e.Profession).HasMaxLength(255);
            entity.Property(e => e.ProgramtId).HasMaxLength(255);
            entity.Property(e => e.RoleName).HasMaxLength(255);
            entity.Property(e => e.SpecialNeed).HasMaxLength(255);
            entity.Property(e => e.StaffDepartmentId).HasMaxLength(255);
            entity.Property(e => e.StaffInGoogleMeet).HasMaxLength(255);
        });

        modelBuilder.Entity<TblSsaUserRole>(entity =>
        {
            entity.HasKey(e => new { e.RoleId, e.UserId }).HasName("PK_tbl_SSA_UserRole_Mapping");

            entity.ToTable("tbl_SSA_UserRoles");

            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.InsertDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.Role).WithMany(p => p.TblSsaUserRoles)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_SSA_UserRole_Mapping_tbl_SSA_RoleMaster");

            entity.HasOne(d => d.User).WithMany(p => p.TblSsaUserRoles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tbl_SSA_UserRole_Mapping_tbl_SSA_ApplicationUsers");
        });

        modelBuilder.Entity<TblSsaUserRolesCapability>(entity =>
        {
            entity.HasKey(e => e.UserRolesCapabilityRecId).HasName("PK_tbl_SSA_UserRolesCapability2");

            entity.ToTable("tbl_SSA_UserRolesCapability");

            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.InsertDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.CapabilityRec).WithMany(p => p.TblSsaUserRolesCapabilities)
                .HasForeignKey(d => d.CapabilityRecId)
                .HasConstraintName("FK_tbl_SSA_UserRolesCapability_tbl_SSA_CapabilityMaster");

            entity.HasOne(d => d.RoleRec).WithMany(p => p.TblSsaUserRolesCapabilities)
                .HasForeignKey(d => d.RoleRecId)
                .HasConstraintName("FK_tbl_SSA_UserRolesCapability_tbl_SSA_RoleMaster");
        });

        modelBuilder.Entity<TblSsaUserRolesCapabilityControl>(entity =>
        {
            entity.HasKey(e => e.UserRoleCapabilityControlRecId);

            entity.ToTable("tbl_SSA_UserRolesCapabilityControls");

            entity.Property(e => e.AmendDateTime).HasColumnType("datetime");
            entity.Property(e => e.InsertDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.CapabilityControlsRec).WithMany(p => p.TblSsaUserRolesCapabilityControls)
                .HasForeignKey(d => d.CapabilityControlsRecId)
                .HasConstraintName("FK_tbl_SSA_UserRolesCapabilityControls_tbl_SSA_CapabilityControlsMaster");

            entity.HasOne(d => d.UserRolesCapabilityRec).WithMany(p => p.TblSsaUserRolesCapabilityControls)
                .HasForeignKey(d => d.UserRolesCapabilityRecId)
                .HasConstraintName("FK_tbl_SSA_UserRolesCapabilityControls_tbl_SSA_UserRolesCapability");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
