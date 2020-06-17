using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class CoreDbContext : DbContext
    {
        public CoreDbContext()
        {
        }

        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<Amtquestion> Amtquestion { get; set; }
        public virtual DbSet<ApiaccessKey> ApiaccessKey { get; set; }
        public virtual DbSet<Apimonitor> Apimonitor { get; set; }
        public virtual DbSet<Apiorder> Apiorder { get; set; }
        public virtual DbSet<ApiorderAllergy> ApiorderAllergy { get; set; }
        public virtual DbSet<ApiorderDiagnosis> ApiorderDiagnosis { get; set; }
        public virtual DbSet<ApiorderMedication> ApiorderMedication { get; set; }
        public virtual DbSet<ApiorderTask> ApiorderTask { get; set; }
        public virtual DbSet<Apnsnotification> Apnsnotification { get; set; }
        public virtual DbSet<AuditActivity> AuditActivity { get; set; }
        public virtual DbSet<AuditAmtquestion> AuditAmtquestion { get; set; }
        public virtual DbSet<AuditApiaccessKey> AuditApiaccessKey { get; set; }
        public virtual DbSet<AuditApimonitor> AuditApimonitor { get; set; }
        public virtual DbSet<AuditApiorder> AuditApiorder { get; set; }
        public virtual DbSet<AuditApiorderAllergy> AuditApiorderAllergy { get; set; }
        public virtual DbSet<AuditApiorderDiagnosis> AuditApiorderDiagnosis { get; set; }
        public virtual DbSet<AuditApiorderMedication> AuditApiorderMedication { get; set; }
        public virtual DbSet<AuditApiorderTask> AuditApiorderTask { get; set; }
        public virtual DbSet<AuditApnsnotification> AuditApnsnotification { get; set; }
        public virtual DbSet<AuditBillingInvoice> AuditBillingInvoice { get; set; }
        public virtual DbSet<AuditBillingInvoiceConsumable> AuditBillingInvoiceConsumable { get; set; }
        public virtual DbSet<AuditBillingInvoiceService> AuditBillingInvoiceService { get; set; }
        public virtual DbSet<AuditBillingPackage> AuditBillingPackage { get; set; }
        public virtual DbSet<AuditBillingPackageInformation> AuditBillingPackageInformation { get; set; }
        public virtual DbSet<AuditBillingPackageRequest> AuditBillingPackageRequest { get; set; }
        public virtual DbSet<AuditBillingProposal> AuditBillingProposal { get; set; }
        public virtual DbSet<AuditBillingProposalService> AuditBillingProposalService { get; set; }
        public virtual DbSet<AuditBillingService> AuditBillingService { get; set; }
        public virtual DbSet<AuditBranch> AuditBranch { get; set; }
        public virtual DbSet<AuditCarePlan> AuditCarePlan { get; set; }
        public virtual DbSet<AuditCarePlanDetail> AuditCarePlanDetail { get; set; }
        public virtual DbSet<AuditCarePlanStatus> AuditCarePlanStatus { get; set; }
        public virtual DbSet<AuditCarePlanSub> AuditCarePlanSub { get; set; }
        public virtual DbSet<AuditCarePlanSubActivity> AuditCarePlanSubActivity { get; set; }
        public virtual DbSet<AuditCarePlanSubCpgoals> AuditCarePlanSubCpgoals { get; set; }
        public virtual DbSet<AuditCarePlanSubGoal> AuditCarePlanSubGoal { get; set; }
        public virtual DbSet<AuditCarePlanSubIntervention> AuditCarePlanSubIntervention { get; set; }
        public virtual DbSet<AuditCarePlanSubProblemList> AuditCarePlanSubProblemList { get; set; }
        public virtual DbSet<AuditCarePlanSubProblemListGoal> AuditCarePlanSubProblemListGoal { get; set; }
        public virtual DbSet<AuditCareReport> AuditCareReport { get; set; }
        public virtual DbSet<AuditCareReportConfig> AuditCareReportConfig { get; set; }
        public virtual DbSet<AuditCareReportRehabilitation> AuditCareReportRehabilitation { get; set; }
        public virtual DbSet<AuditCareReportSocialSupport> AuditCareReportSocialSupport { get; set; }
        public virtual DbSet<AuditCareReportSystemInfo> AuditCareReportSystemInfo { get; set; }
        public virtual DbSet<AuditChat> AuditChat { get; set; }
        public virtual DbSet<AuditCode> AuditCode { get; set; }
        public virtual DbSet<AuditCodeType> AuditCodeType { get; set; }
        public virtual DbSet<AuditCpgoals> AuditCpgoals { get; set; }
        public virtual DbSet<AuditDiagnosis> AuditDiagnosis { get; set; }
        public virtual DbSet<AuditDischargeSummaryReport> AuditDischargeSummaryReport { get; set; }
        public virtual DbSet<AuditDischargeSummaryReportAttachment> AuditDischargeSummaryReportAttachment { get; set; }
        public virtual DbSet<AuditDisease> AuditDisease { get; set; }
        public virtual DbSet<AuditDiseaseInfo> AuditDiseaseInfo { get; set; }
        public virtual DbSet<AuditDiseaseSubInfo> AuditDiseaseSubInfo { get; set; }
        public virtual DbSet<AuditDiseaseVitalSignType> AuditDiseaseVitalSignType { get; set; }
        public virtual DbSet<AuditEbasdepquestion> AuditEbasdepquestion { get; set; }
        public virtual DbSet<AuditEnquiry> AuditEnquiry { get; set; }
        public virtual DbSet<AuditEnquiryAttachment> AuditEnquiryAttachment { get; set; }
        public virtual DbSet<AuditEnquiryConfig> AuditEnquiryConfig { get; set; }
        public virtual DbSet<AuditEnquiryEscPerson> AuditEnquiryEscPerson { get; set; }
        public virtual DbSet<AuditEnquiryLanguage> AuditEnquiryLanguage { get; set; }
        public virtual DbSet<AuditEnquiryScm> AuditEnquiryScm { get; set; }
        public virtual DbSet<AuditEnquiryServicesRequired> AuditEnquiryServicesRequired { get; set; }
        public virtual DbSet<AuditEvent> AuditEvent { get; set; }
        public virtual DbSet<AuditEventUser> AuditEventUser { get; set; }
        public virtual DbSet<AuditEventUserLog> AuditEventUserLog { get; set; }
        public virtual DbSet<AuditExternalDoctor> AuditExternalDoctor { get; set; }
        public virtual DbSet<AuditGroup> AuditGroup { get; set; }
        public virtual DbSet<AuditGroupRole> AuditGroupRole { get; set; }
        public virtual DbSet<AuditIcawoundCare> AuditIcawoundCare { get; set; }
        public virtual DbSet<AuditInitialCareAssessment> AuditInitialCareAssessment { get; set; }
        public virtual DbSet<AuditInitialCareAssessmentAttachment> AuditInitialCareAssessmentAttachment { get; set; }
        public virtual DbSet<AuditInitialCareAssessmentSpecialInstruction> AuditInitialCareAssessmentSpecialInstruction { get; set; }
        public virtual DbSet<AuditInitialCareAssessmentVitalSign> AuditInitialCareAssessmentVitalSign { get; set; }
        public virtual DbSet<AuditIntervention> AuditIntervention { get; set; }
        public virtual DbSet<AuditItem> AuditItem { get; set; }
        public virtual DbSet<AuditItemStock> AuditItemStock { get; set; }
        public virtual DbSet<AuditLoginDevice> AuditLoginDevice { get; set; }
        public virtual DbSet<AuditMailSettings> AuditMailSettings { get; set; }
        public virtual DbSet<AuditMedicationVitalSignType> AuditMedicationVitalSignType { get; set; }
        public virtual DbSet<AuditMultiDisciplinaryMeeting> AuditMultiDisciplinaryMeeting { get; set; }
        public virtual DbSet<AuditMultiDisciplinaryMeetingDetail> AuditMultiDisciplinaryMeetingDetail { get; set; }
        public virtual DbSet<AuditNotificationChat> AuditNotificationChat { get; set; }
        public virtual DbSet<AuditNotificationEvent> AuditNotificationEvent { get; set; }
        public virtual DbSet<AuditNotificationMessageTemplates> AuditNotificationMessageTemplates { get; set; }
        public virtual DbSet<AuditNotificationTask> AuditNotificationTask { get; set; }
        public virtual DbSet<AuditNotificationVitalSignDetails> AuditNotificationVitalSignDetails { get; set; }
        public virtual DbSet<AuditNotifications> AuditNotifications { get; set; }
        public virtual DbSet<AuditNutritionTask> AuditNutritionTask { get; set; }
        public virtual DbSet<AuditNutritionTaskReference> AuditNutritionTaskReference { get; set; }
        public virtual DbSet<AuditOtp> AuditOtp { get; set; }
        public virtual DbSet<AuditPackage> AuditPackage { get; set; }
        public virtual DbSet<AuditPatient> AuditPatient { get; set; }
        public virtual DbSet<AuditPatientAccessLine> AuditPatientAccessLine { get; set; }
        public virtual DbSet<AuditPatientAdditionalInfo> AuditPatientAdditionalInfo { get; set; }
        public virtual DbSet<AuditPatientAmt> AuditPatientAmt { get; set; }
        public virtual DbSet<AuditPatientAmtanswer> AuditPatientAmtanswer { get; set; }
        public virtual DbSet<AuditPatientAttachment> AuditPatientAttachment { get; set; }
        public virtual DbSet<AuditPatientBradenScale> AuditPatientBradenScale { get; set; }
        public virtual DbSet<AuditPatientClinician> AuditPatientClinician { get; set; }
        public virtual DbSet<AuditPatientDrugAllergy> AuditPatientDrugAllergy { get; set; }
        public virtual DbSet<AuditPatientEbasdep> AuditPatientEbasdep { get; set; }
        public virtual DbSet<AuditPatientEbasdepanswer> AuditPatientEbasdepanswer { get; set; }
        public virtual DbSet<AuditPatientFamilyHistory> AuditPatientFamilyHistory { get; set; }
        public virtual DbSet<AuditPatientGcs> AuditPatientGcs { get; set; }
        public virtual DbSet<AuditPatientImmunisation> AuditPatientImmunisation { get; set; }
        public virtual DbSet<AuditPatientLanguage> AuditPatientLanguage { get; set; }
        public virtual DbSet<AuditPatientMbi> AuditPatientMbi { get; set; }
        public virtual DbSet<AuditPatientMedicalHistory> AuditPatientMedicalHistory { get; set; }
        public virtual DbSet<AuditPatientMedication> AuditPatientMedication { get; set; }
        public virtual DbSet<AuditPatientMedicationConsume> AuditPatientMedicationConsume { get; set; }
        public virtual DbSet<AuditPatientMedicationConsumeAttachment> AuditPatientMedicationConsumeAttachment { get; set; }
        public virtual DbSet<AuditPatientMedicationSupply> AuditPatientMedicationSupply { get; set; }
        public virtual DbSet<AuditPatientMfs> AuditPatientMfs { get; set; }
        public virtual DbSet<AuditPatientMmse> AuditPatientMmse { get; set; }
        public virtual DbSet<AuditPatientNutrition> AuditPatientNutrition { get; set; }
        public virtual DbSet<AuditPatientOtherAllergy> AuditPatientOtherAllergy { get; set; }
        public virtual DbSet<AuditPatientPackage> AuditPatientPackage { get; set; }
        public virtual DbSet<AuditPatientProfile> AuditPatientProfile { get; set; }
        public virtual DbSet<AuditPatientRaf> AuditPatientRaf { get; set; }
        public virtual DbSet<AuditPatientReferral> AuditPatientReferral { get; set; }
        public virtual DbSet<AuditPatientReferralService> AuditPatientReferralService { get; set; }
        public virtual DbSet<AuditPatientSocialSupport> AuditPatientSocialSupport { get; set; }
        public virtual DbSet<AuditPatientSpecialIndicator> AuditPatientSpecialIndicator { get; set; }
        public virtual DbSet<AuditPatientWound> AuditPatientWound { get; set; }
        public virtual DbSet<AuditPatientWoundVisit> AuditPatientWoundVisit { get; set; }
        public virtual DbSet<AuditPatientWoundVisitAppearance> AuditPatientWoundVisitAppearance { get; set; }
        public virtual DbSet<AuditPatientWoundVisitCleansingItem> AuditPatientWoundVisitCleansingItem { get; set; }
        public virtual DbSet<AuditPatientWoundVisitClinician> AuditPatientWoundVisitClinician { get; set; }
        public virtual DbSet<AuditPatientWoundVisitTreatment> AuditPatientWoundVisitTreatment { get; set; }
        public virtual DbSet<AuditPatientWoundVisitTreatmentList> AuditPatientWoundVisitTreatmentList { get; set; }
        public virtual DbSet<AuditPatientWoundVisitTreatmentObjectives> AuditPatientWoundVisitTreatmentObjectives { get; set; }
        public virtual DbSet<AuditProblemList> AuditProblemList { get; set; }
        public virtual DbSet<AuditProblemListGoal> AuditProblemListGoal { get; set; }
        public virtual DbSet<AuditReceipt> AuditReceipt { get; set; }
        public virtual DbSet<AuditReceiptForInvoice> AuditReceiptForInvoice { get; set; }
        public virtual DbSet<AuditRegisteredDevice> AuditRegisteredDevice { get; set; }
        public virtual DbSet<AuditResidentAssessmentCategory> AuditResidentAssessmentCategory { get; set; }
        public virtual DbSet<AuditRole> AuditRole { get; set; }
        public virtual DbSet<AuditScheduledTasks> AuditScheduledTasks { get; set; }
        public virtual DbSet<AuditServiceForBilling> AuditServiceForBilling { get; set; }
        public virtual DbSet<AuditServiceForBillingCost> AuditServiceForBillingCost { get; set; }
        public virtual DbSet<AuditServiceSkillset> AuditServiceSkillset { get; set; }
        public virtual DbSet<AuditSyncPatientLog> AuditSyncPatientLog { get; set; }
        public virtual DbSet<AuditSyncWoundLog> AuditSyncWoundLog { get; set; }
        public virtual DbSet<AuditSyncWoundVisitLog> AuditSyncWoundVisitLog { get; set; }
        public virtual DbSet<AuditSysConfig> AuditSysConfig { get; set; }
        public virtual DbSet<AuditSystemForDisease> AuditSystemForDisease { get; set; }
        public virtual DbSet<AuditTask> AuditTask { get; set; }
        public virtual DbSet<AuditTaskFileAttachment> AuditTaskFileAttachment { get; set; }
        public virtual DbSet<AuditTaskServicesRequired> AuditTaskServicesRequired { get; set; }
        public virtual DbSet<AuditTaskSpecificDate> AuditTaskSpecificDate { get; set; }
        public virtual DbSet<AuditTaskUser> AuditTaskUser { get; set; }
        public virtual DbSet<AuditTaskUserLog> AuditTaskUserLog { get; set; }
        public virtual DbSet<AuditTaskUserLogAttachment> AuditTaskUserLogAttachment { get; set; }
        public virtual DbSet<AuditTdWoundAssessmentFactor> AuditTdWoundAssessmentFactor { get; set; }
        public virtual DbSet<AuditTeleconsultationRecording> AuditTeleconsultationRecording { get; set; }
        public virtual DbSet<AuditTeleconsultationReport> AuditTeleconsultationReport { get; set; }
        public virtual DbSet<AuditThresholds> AuditThresholds { get; set; }
        public virtual DbSet<AuditTrail> AuditTrail { get; set; }
        public virtual DbSet<AuditTreatmentListItem> AuditTreatmentListItem { get; set; }
        public virtual DbSet<AuditTreatmentTol> AuditTreatmentTol { get; set; }
        public virtual DbSet<AuditTypes> AuditTypes { get; set; }
        public virtual DbSet<AuditUserAddress> AuditUserAddress { get; set; }
        public virtual DbSet<AuditUserBranch> AuditUserBranch { get; set; }
        public virtual DbSet<AuditUserCategory> AuditUserCategory { get; set; }
        public virtual DbSet<AuditUserCategoryRole> AuditUserCategoryRole { get; set; }
        public virtual DbSet<AuditUserLanguage> AuditUserLanguage { get; set; }
        public virtual DbSet<AuditUserOrganization> AuditUserOrganization { get; set; }
        public virtual DbSet<AuditUserRole> AuditUserRole { get; set; }
        public virtual DbSet<AuditUserSkillset> AuditUserSkillset { get; set; }
        public virtual DbSet<AuditUserType> AuditUserType { get; set; }
        public virtual DbSet<AuditUserUserType> AuditUserUserType { get; set; }
        public virtual DbSet<AuditUsers> AuditUsers { get; set; }
        public virtual DbSet<AuditVitalSignDetails> AuditVitalSignDetails { get; set; }
        public virtual DbSet<AuditVitalSignRelationships> AuditVitalSignRelationships { get; set; }
        public virtual DbSet<AuditVitalSignTypeThreshold> AuditVitalSignTypeThreshold { get; set; }
        public virtual DbSet<AuditVitalSignTypes> AuditVitalSignTypes { get; set; }
        public virtual DbSet<AuditVitalSigns> AuditVitalSigns { get; set; }
        public virtual DbSet<BillingInvoice> BillingInvoice { get; set; }
        public virtual DbSet<BillingInvoiceConsumable> BillingInvoiceConsumable { get; set; }
        public virtual DbSet<BillingInvoiceService> BillingInvoiceService { get; set; }
        public virtual DbSet<BillingPackage> BillingPackage { get; set; }
        public virtual DbSet<BillingPackageInformation> BillingPackageInformation { get; set; }
        public virtual DbSet<BillingPackageRequest> BillingPackageRequest { get; set; }
        public virtual DbSet<BillingProposal> BillingProposal { get; set; }
        public virtual DbSet<BillingProposalService> BillingProposalService { get; set; }
        public virtual DbSet<BillingService> BillingService { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<CarePlan> CarePlan { get; set; }
        public virtual DbSet<CarePlanDetail> CarePlanDetail { get; set; }
        public virtual DbSet<CarePlanStatus> CarePlanStatus { get; set; }
        public virtual DbSet<CarePlanSub> CarePlanSub { get; set; }
        public virtual DbSet<CarePlanSubActivity> CarePlanSubActivity { get; set; }
        public virtual DbSet<CarePlanSubCpgoals> CarePlanSubCpgoals { get; set; }
        public virtual DbSet<CarePlanSubGoal> CarePlanSubGoal { get; set; }
        public virtual DbSet<CarePlanSubIntervention> CarePlanSubIntervention { get; set; }
        public virtual DbSet<CarePlanSubProblemList> CarePlanSubProblemList { get; set; }
        public virtual DbSet<CarePlanSubProblemListGoal> CarePlanSubProblemListGoal { get; set; }
        public virtual DbSet<CareReport> CareReport { get; set; }
        public virtual DbSet<CareReportConfig> CareReportConfig { get; set; }
        public virtual DbSet<CareReportRehabilitation> CareReportRehabilitation { get; set; }
        public virtual DbSet<CareReportSocialSupport> CareReportSocialSupport { get; set; }
        public virtual DbSet<CareReportSystemInfo> CareReportSystemInfo { get; set; }
        public virtual DbSet<Chat> Chat { get; set; }
        public virtual DbSet<Code> Code { get; set; }
        public virtual DbSet<CodeType> CodeType { get; set; }
        public virtual DbSet<Cpgoals> Cpgoals { get; set; }
        public virtual DbSet<Diagnosis> Diagnosis { get; set; }
        public virtual DbSet<DischargeSummaryReport> DischargeSummaryReport { get; set; }
        public virtual DbSet<DischargeSummaryReportAttachment> DischargeSummaryReportAttachment { get; set; }
        public virtual DbSet<Disease> Disease { get; set; }
        public virtual DbSet<DiseaseInfo> DiseaseInfo { get; set; }
        public virtual DbSet<DiseaseSubInfo> DiseaseSubInfo { get; set; }
        public virtual DbSet<DiseaseVitalSignType> DiseaseVitalSignType { get; set; }
        public virtual DbSet<Ebasdepquestion> Ebasdepquestion { get; set; }
        public virtual DbSet<EmailLog> EmailLog { get; set; }
        public virtual DbSet<Enquiry> Enquiry { get; set; }
        public virtual DbSet<EnquiryAttachment> EnquiryAttachment { get; set; }
        public virtual DbSet<EnquiryConfig> EnquiryConfig { get; set; }
        public virtual DbSet<EnquiryEscPerson> EnquiryEscPerson { get; set; }
        public virtual DbSet<EnquiryLanguage> EnquiryLanguage { get; set; }
        public virtual DbSet<EnquiryScm> EnquiryScm { get; set; }
        public virtual DbSet<EnquiryServicesRequired> EnquiryServicesRequired { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<EventUser> EventUser { get; set; }
        public virtual DbSet<EventUserLog> EventUserLog { get; set; }
        public virtual DbSet<ExternalDoctor> ExternalDoctor { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<GroupRole> GroupRole { get; set; }
        public virtual DbSet<IcawoundCare> IcawoundCare { get; set; }
        public virtual DbSet<InitialCareAssessment> InitialCareAssessment { get; set; }
        public virtual DbSet<InitialCareAssessmentAttachment> InitialCareAssessmentAttachment { get; set; }
        public virtual DbSet<InitialCareAssessmentSpecialInstruction> InitialCareAssessmentSpecialInstruction { get; set; }
        public virtual DbSet<InitialCareAssessmentVitalSign> InitialCareAssessmentVitalSign { get; set; }
        public virtual DbSet<Intervention> Intervention { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<ItemStock> ItemStock { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<LoginDevice> LoginDevice { get; set; }
        public virtual DbSet<MailSettings> MailSettings { get; set; }
        public virtual DbSet<MedicationVitalSignType> MedicationVitalSignType { get; set; }
        public virtual DbSet<MultiDisciplinaryMeeting> MultiDisciplinaryMeeting { get; set; }
        public virtual DbSet<MultiDisciplinaryMeetingDetail> MultiDisciplinaryMeetingDetail { get; set; }
        public virtual DbSet<NotificationChat> NotificationChat { get; set; }
        public virtual DbSet<NotificationEvent> NotificationEvent { get; set; }
        public virtual DbSet<NotificationMessageTemplates> NotificationMessageTemplates { get; set; }
        public virtual DbSet<NotificationTask> NotificationTask { get; set; }
        public virtual DbSet<NotificationVitalSignDetails> NotificationVitalSignDetails { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<NutritionTask> NutritionTask { get; set; }
        public virtual DbSet<NutritionTaskReference> NutritionTaskReference { get; set; }
        public virtual DbSet<Otp> Otp { get; set; }
        public virtual DbSet<Package> Package { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PatientAccessLine> PatientAccessLine { get; set; }
        public virtual DbSet<PatientAdditionalInfo> PatientAdditionalInfo { get; set; }
        public virtual DbSet<PatientAmt> PatientAmt { get; set; }
        public virtual DbSet<PatientAmtanswer> PatientAmtanswer { get; set; }
        public virtual DbSet<PatientAttachment> PatientAttachment { get; set; }
        public virtual DbSet<PatientBradenScale> PatientBradenScale { get; set; }
        public virtual DbSet<PatientClinician> PatientClinician { get; set; }
        public virtual DbSet<PatientDrugAllergy> PatientDrugAllergy { get; set; }
        public virtual DbSet<PatientEbasdep> PatientEbasdep { get; set; }
        public virtual DbSet<PatientEbasdepanswer> PatientEbasdepanswer { get; set; }
        public virtual DbSet<PatientFamilyHistory> PatientFamilyHistory { get; set; }
        public virtual DbSet<PatientGcs> PatientGcs { get; set; }
        public virtual DbSet<PatientImmunisation> PatientImmunisation { get; set; }
        public virtual DbSet<PatientLanguage> PatientLanguage { get; set; }
        public virtual DbSet<PatientMbi> PatientMbi { get; set; }
        public virtual DbSet<PatientMedicalHistory> PatientMedicalHistory { get; set; }
        public virtual DbSet<PatientMedication> PatientMedication { get; set; }
        public virtual DbSet<PatientMedicationConsume> PatientMedicationConsume { get; set; }
        public virtual DbSet<PatientMedicationConsumeAttachment> PatientMedicationConsumeAttachment { get; set; }
        public virtual DbSet<PatientMedicationSupply> PatientMedicationSupply { get; set; }
        public virtual DbSet<PatientMfs> PatientMfs { get; set; }
        public virtual DbSet<PatientMmse> PatientMmse { get; set; }
        public virtual DbSet<PatientNutrition> PatientNutrition { get; set; }
        public virtual DbSet<PatientOtherAllergy> PatientOtherAllergy { get; set; }
        public virtual DbSet<PatientPackage> PatientPackage { get; set; }
        public virtual DbSet<PatientProfile> PatientProfile { get; set; }
        public virtual DbSet<PatientRaf> PatientRaf { get; set; }
        public virtual DbSet<PatientReferral> PatientReferral { get; set; }
        public virtual DbSet<PatientReferralService> PatientReferralService { get; set; }
        public virtual DbSet<PatientSocialSupport> PatientSocialSupport { get; set; }
        public virtual DbSet<PatientSpecialIndicator> PatientSpecialIndicator { get; set; }
        public virtual DbSet<PatientWound> PatientWound { get; set; }
        public virtual DbSet<PatientWoundVisit> PatientWoundVisit { get; set; }
        public virtual DbSet<PatientWoundVisitAppearance> PatientWoundVisitAppearance { get; set; }
        public virtual DbSet<PatientWoundVisitCleansingItem> PatientWoundVisitCleansingItem { get; set; }
        public virtual DbSet<PatientWoundVisitClinician> PatientWoundVisitClinician { get; set; }
        public virtual DbSet<PatientWoundVisitTreatment> PatientWoundVisitTreatment { get; set; }
        public virtual DbSet<PatientWoundVisitTreatmentList> PatientWoundVisitTreatmentList { get; set; }
        public virtual DbSet<PatientWoundVisitTreatmentObjectives> PatientWoundVisitTreatmentObjectives { get; set; }
        public virtual DbSet<ProblemList> ProblemList { get; set; }
        public virtual DbSet<ProblemListGoal> ProblemListGoal { get; set; }
        public virtual DbSet<Receipt> Receipt { get; set; }
        public virtual DbSet<ReceiptForInvoice> ReceiptForInvoice { get; set; }
        public virtual DbSet<RecentView> RecentView { get; set; }
        public virtual DbSet<RegisteredDevice> RegisteredDevice { get; set; }
        public virtual DbSet<ResidentAssessmentCategory> ResidentAssessmentCategory { get; set; }
        public virtual DbSet<Resource> Resource { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<ScheduledTasks> ScheduledTasks { get; set; }
        public virtual DbSet<ServiceForBilling> ServiceForBilling { get; set; }
        public virtual DbSet<ServiceForBillingCost> ServiceForBillingCost { get; set; }
        public virtual DbSet<ServiceSkillset> ServiceSkillset { get; set; }
        public virtual DbSet<SyncPatientLog> SyncPatientLog { get; set; }
        public virtual DbSet<SyncWoundLog> SyncWoundLog { get; set; }
        public virtual DbSet<SyncWoundVisitLog> SyncWoundVisitLog { get; set; }
        public virtual DbSet<SysConfig> SysConfig { get; set; }
        public virtual DbSet<SystemForDisease> SystemForDisease { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<TaskFileAttachment> TaskFileAttachment { get; set; }
        public virtual DbSet<TaskServicesRequired> TaskServicesRequired { get; set; }
        public virtual DbSet<TaskSpecificDate> TaskSpecificDate { get; set; }
        public virtual DbSet<TaskUser> TaskUser { get; set; }
        public virtual DbSet<TaskUserLog> TaskUserLog { get; set; }
        public virtual DbSet<TaskUserLogAttachment> TaskUserLogAttachment { get; set; }
        public virtual DbSet<TdWoundAssessmentFactor> TdWoundAssessmentFactor { get; set; }
        public virtual DbSet<TeleconsultationRecording> TeleconsultationRecording { get; set; }
        public virtual DbSet<TeleconsultationReport> TeleconsultationReport { get; set; }
        public virtual DbSet<Thresholds> Thresholds { get; set; }
        public virtual DbSet<TreatmentListItem> TreatmentListItem { get; set; }
        public virtual DbSet<TreatmentTol> TreatmentTol { get; set; }
        public virtual DbSet<Types> Types { get; set; }
        public virtual DbSet<UserAddress> UserAddress { get; set; }
        public virtual DbSet<UserBranch> UserBranch { get; set; }
        public virtual DbSet<UserCategory> UserCategory { get; set; }
        public virtual DbSet<UserCategoryRole> UserCategoryRole { get; set; }
        public virtual DbSet<UserLanguage> UserLanguage { get; set; }
        public virtual DbSet<UserOrganization> UserOrganization { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<UserSkillset> UserSkillset { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<UserUserType> UserUserType { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Uuidlog> Uuidlog { get; set; }
        public virtual DbSet<VitalSignDetails> VitalSignDetails { get; set; }
        public virtual DbSet<VitalSignRelationships> VitalSignRelationships { get; set; }
        public virtual DbSet<VitalSignTypeThreshold> VitalSignTypeThreshold { get; set; }
        public virtual DbSet<VitalSignTypes> VitalSignTypes { get; set; }
        public virtual DbSet<VitalSigns> VitalSigns { get; set; }
        public virtual DbSet<VwAssessmentDue> VwAssessmentDue { get; set; }
        public virtual DbSet<VwCarePlanSetup> VwCarePlanSetup { get; set; }
        public virtual DbSet<VwCarePlanSystemDisease> VwCarePlanSystemDisease { get; set; }
        public virtual DbSet<VwDoctors> VwDoctors { get; set; }
        public virtual DbSet<VwFalangaScores> VwFalangaScores { get; set; }
        public virtual DbSet<VwPatientAllLatestVitalSigns> VwPatientAllLatestVitalSigns { get; set; }
        public virtual DbSet<VwPatientBilling> VwPatientBilling { get; set; }
        public virtual DbSet<VwPatientDisease> VwPatientDisease { get; set; }
        public virtual DbSet<VwPatientLatestVitalSigns> VwPatientLatestVitalSigns { get; set; }
        public virtual DbSet<VwPatientWoundImageDownload> VwPatientWoundImageDownload { get; set; }
        public virtual DbSet<VwPushScores> VwPushScores { get; set; }
        public virtual DbSet<VwTeleconsultation> VwTeleconsultation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=ULTP_521;Database=DEV_CARES_C4WX1;Persist Security Info=True;User Id=sa;Password=synerzip;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasOne(d => d.DiseaseIdFkNavigation)
                    .WithMany(p => p.Activity)
                    .HasForeignKey(d => d.DiseaseIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Activity_Disease");

                entity.HasOne(d => d.ProblemListIdFkNavigation)
                    .WithMany(p => p.Activity)
                    .HasForeignKey(d => d.ProblemListIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Activity_ProblemList");
            });

            modelBuilder.Entity<ApiaccessKey>(entity =>
            {
                entity.HasIndex(e => e.TokenCode)
                    .HasName("idx_APIAccessKey2");

                entity.HasIndex(e => new { e.TokenCode, e.ExpiryDate })
                    .HasName("idx_APIAccessKey1");

                entity.HasIndex(e => new { e.TokenCode, e.ExpiryDate, e.CreatedDate })
                    .HasName("idx_APIAccessKey3");

                entity.HasOne(d => d.TokenCodeNavigation)
                    .WithMany(p => p.ApiaccessKey)
                    .HasForeignKey(d => d.TokenCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APIAccessKey_TokenCode");
            });

            modelBuilder.Entity<Apimonitor>(entity =>
            {
                entity.HasKey(e => e.MonitorId)
                    .HasName("PK_MonitorID");

                entity.Property(e => e.Uuid).IsFixedLength();
            });

            modelBuilder.Entity<ApiorderAllergy>(entity =>
            {
                entity.HasOne(d => d.ApiorderIdFkNavigation)
                    .WithMany(p => p.ApiorderAllergy)
                    .HasForeignKey(d => d.ApiorderIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APIOrderAllergy_APIOrder");
            });

            modelBuilder.Entity<ApiorderDiagnosis>(entity =>
            {
                entity.HasOne(d => d.ApiorderIdFkNavigation)
                    .WithMany(p => p.ApiorderDiagnosis)
                    .HasForeignKey(d => d.ApiorderIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APIOrderDiagnosis_APIOrder");
            });

            modelBuilder.Entity<ApiorderMedication>(entity =>
            {
                entity.HasOne(d => d.ApiorderIdFkNavigation)
                    .WithMany(p => p.ApiorderMedication)
                    .HasForeignKey(d => d.ApiorderIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APIOrderMedication_APIOrder");
            });

            modelBuilder.Entity<ApiorderTask>(entity =>
            {
                entity.HasOne(d => d.ApiorderIdFkNavigation)
                    .WithMany(p => p.ApiorderTask)
                    .HasForeignKey(d => d.ApiorderIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_APIOrderTask_APIOrder");
            });

            modelBuilder.Entity<AuditActivity>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditAmtquestion>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditApiaccessKey>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditApimonitor>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Uuid).IsFixedLength();
            });

            modelBuilder.Entity<AuditApiorder>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditApiorderAllergy>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditApiorderDiagnosis>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditApiorderMedication>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditApiorderTask>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditApnsnotification>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditBillingInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<AuditBillingInvoiceConsumable>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditBillingInvoiceService>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditBillingPackage>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Status).IsFixedLength();

                entity.Property(e => e.Type).IsFixedLength();
            });

            modelBuilder.Entity<AuditBillingPackageInformation>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditBillingPackageRequest>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.BillingPostalCode).IsFixedLength();
            });

            modelBuilder.Entity<AuditBillingProposal>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.ProposalType).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<AuditBillingProposalService>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditBillingService>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<AuditBranch>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<AuditCarePlan>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditCarePlanDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditCarePlanStatus>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.CarePlanStatus).IsUnicode(false);
            });

            modelBuilder.Entity<AuditCarePlanSub>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditCarePlanSubActivity>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditCarePlanSubCpgoals>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditCarePlanSubGoal>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditCarePlanSubIntervention>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditCarePlanSubProblemList>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditCarePlanSubProblemListGoal>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditCareReport>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Environment).IsUnicode(false);

                entity.Property(e => e.PersonalHygiene).IsUnicode(false);

                entity.Property(e => e.SectionRequireInput).IsUnicode(false);

                entity.Property(e => e.SectionRequired).IsUnicode(false);

                entity.Property(e => e.SectionStatus).IsUnicode(false);

                entity.Property(e => e.SkinAndWoundCare).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<AuditCareReportConfig>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.SectionAccess).IsUnicode(false);
            });

            modelBuilder.Entity<AuditCareReportRehabilitation>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditCareReportSocialSupport>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditCareReportSystemInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditChat>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AttachmentPhysical).IsUnicode(false);

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditCode>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.CurrencyCodeA).IsUnicode(false);

                entity.Property(e => e.CurrencyCodeN).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<AuditCodeType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditCpgoals>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditDiagnosis>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditDischargeSummaryReport>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<AuditDischargeSummaryReportAttachment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Physical).IsUnicode(false);
            });

            modelBuilder.Entity<AuditDisease>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditDiseaseInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditDiseaseSubInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditDiseaseVitalSignType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditEbasdepquestion>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditEnquiry>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<AuditEnquiryAttachment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Physical).IsUnicode(false);
            });

            modelBuilder.Entity<AuditEnquiryConfig>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditEnquiryEscPerson>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditEnquiryLanguage>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditEnquiryScm>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditEnquiryServicesRequired>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditEvent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditEventUser>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditEventUserLog>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditExternalDoctor>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditGroup>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditGroupRole>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditIcawoundCare>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditInitialCareAssessment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.SectionStatus).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<AuditInitialCareAssessmentAttachment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Physical).IsUnicode(false);
            });

            modelBuilder.Entity<AuditInitialCareAssessmentSpecialInstruction>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditInitialCareAssessmentVitalSign>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditIntervention>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditItem>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditItemStock>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditLoginDevice>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditMailSettings>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditMedicationVitalSignType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditMultiDisciplinaryMeeting>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditMultiDisciplinaryMeetingDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditNotificationChat>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditNotificationEvent>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditNotificationMessageTemplates>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditNotificationTask>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditNotificationVitalSignDetails>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditNotifications>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditNutritionTask>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AfterImage).IsUnicode(false);

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.BeforeImage).IsUnicode(false);
            });

            modelBuilder.Entity<AuditNutritionTaskReference>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.ReferenceImage).IsUnicode(false);
            });

            modelBuilder.Entity<AuditOtp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPackage>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PackageDetails).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatient>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.GenogramPicture).IsUnicode(false);

                entity.Property(e => e.IdentificationAttachmentPhysical).IsUnicode(false);

                entity.Property(e => e.MailForFamilyNotification1).IsUnicode(false);

                entity.Property(e => e.MailForFamilyNotification2).IsUnicode(false);

                entity.Property(e => e.MailForVitalAlert1).IsUnicode(false);

                entity.Property(e => e.MailForVitalAlert2).IsUnicode(false);

                entity.Property(e => e.MailForVitalAlert3).IsUnicode(false);

                entity.Property(e => e.Occupation).IsUnicode(false);

                entity.Property(e => e.PaymentMode).IsUnicode(false);

                entity.Property(e => e.Photo).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientAccessLine>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientAdditionalInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientAmt>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientAmtanswer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientAttachment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Physical).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientBradenScale>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientClinician>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientDrugAllergy>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientEbasdep>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientEbasdepanswer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientFamilyHistory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientGcs>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientImmunisation>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientLanguage>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientMbi>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientMedicalHistory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientMedication>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientMedicationConsume>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientMedicationConsumeAttachment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Physical).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientMedicationSupply>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientMfs>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientMmse>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientNutrition>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientOtherAllergy>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientPackage>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientProfile>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientRaf>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientReferral>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientReferralService>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientSocialSupport>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientSpecialIndicator>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientWound>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientWoundVisit>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.ImageUpload).IsUnicode(false);

                entity.Property(e => e.IsDraft).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModelJpg).IsUnicode(false);

                entity.Property(e => e.ModelMtl).IsUnicode(false);

                entity.Property(e => e.ModelObj).IsUnicode(false);

                entity.Property(e => e.TcAnnotatedImage).IsUnicode(false);

                entity.Property(e => e.TcOriginalImage).IsUnicode(false);

                entity.Property(e => e.TcWoundBedImage).IsUnicode(false);

                entity.Property(e => e.ToComments).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientWoundVisitAppearance>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientWoundVisitCleansingItem>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientWoundVisitClinician>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientWoundVisitTreatment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientWoundVisitTreatmentList>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditPatientWoundVisitTreatmentObjectives>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditProblemList>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditProblemListGoal>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditReceipt>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditReceiptForInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditRegisteredDevice>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditResidentAssessmentCategory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditRole>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditScheduledTasks>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditServiceForBilling>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditServiceForBillingCost>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditServiceSkillset>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditSyncPatientLog>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditSyncWoundLog>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditSyncWoundVisitLog>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditSysConfig>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.ConfigName).IsUnicode(false);
            });

            modelBuilder.Entity<AuditSystemForDisease>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditTask>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.ReferenceType).IsUnicode(false);
            });

            modelBuilder.Entity<AuditTaskFileAttachment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.FileName).IsUnicode(false);
            });

            modelBuilder.Entity<AuditTaskServicesRequired>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditTaskSpecificDate>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditTaskUser>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.UserType).IsUnicode(false);
            });

            modelBuilder.Entity<AuditTaskUserLog>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<AuditTaskUserLogAttachment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.FileName).IsUnicode(false);
            });

            modelBuilder.Entity<AuditTdWoundAssessmentFactor>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditTeleconsultationRecording>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Sid)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AuditTeleconsultationReport>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<AuditThresholds>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditTrail>(entity =>
            {
                entity.Property(e => e.AuditAction).HasDefaultValueSql("('')");

                entity.Property(e => e.Ipaddress).IsUnicode(false);

                entity.HasOne(d => d.CreatedByFkNavigation)
                    .WithMany(p => p.AuditTrail)
                    .HasForeignKey(d => d.CreatedByFk)
                    .HasConstraintName("FK_AuditTrail_Users");
            });

            modelBuilder.Entity<AuditTreatmentListItem>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditTreatmentTol>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditTypes>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditUserAddress>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditUserBranch>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditUserCategory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditUserCategoryRole>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditUserLanguage>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditUserOrganization>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditUserRole>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditUserSkillset>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditUserType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditUserUserType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditUsers>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);

                entity.Property(e => e.Photo).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<AuditVitalSignDetails>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditVitalSignRelationships>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditVitalSignTypeThreshold>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditVitalSignTypes>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<AuditVitalSigns>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AuditAction).IsUnicode(false);
            });

            modelBuilder.Entity<BillingInvoice>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.CareReportIdFkNavigation)
                    .WithMany(p => p.BillingInvoice)
                    .HasForeignKey(d => d.CareReportIdFk)
                    .HasConstraintName("FK_BillingInvoice_CareReport");

                entity.HasOne(d => d.CreatedByFkNavigation)
                    .WithMany(p => p.BillingInvoiceCreatedByFkNavigation)
                    .HasForeignKey(d => d.CreatedByFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingInvoice_Users");

                entity.HasOne(d => d.CurrencyIdFkNavigation)
                    .WithMany(p => p.BillingInvoice)
                    .HasForeignKey(d => d.CurrencyIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingInvoice_Code");

                entity.HasOne(d => d.ModifiedByFkNavigation)
                    .WithMany(p => p.BillingInvoiceModifiedByFkNavigation)
                    .HasForeignKey(d => d.ModifiedByFk)
                    .HasConstraintName("FK_BillingInvoice_Users1");

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.BillingInvoice)
                    .HasForeignKey(d => d.PatientIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingInvoice_Patient");
            });

            modelBuilder.Entity<BillingInvoiceConsumable>(entity =>
            {
                entity.HasOne(d => d.BillingInvoiceIdFkNavigation)
                    .WithMany(p => p.BillingInvoiceConsumable)
                    .HasForeignKey(d => d.BillingInvoiceIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingInvoiceConsumable_BillingInvoice");

                entity.HasOne(d => d.ItemIdFkNavigation)
                    .WithMany(p => p.BillingInvoiceConsumable)
                    .HasForeignKey(d => d.ItemIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingInvoiceConsumable_Item");
            });

            modelBuilder.Entity<BillingInvoiceService>(entity =>
            {
                entity.HasOne(d => d.BillingInvoiceIdFkNavigation)
                    .WithMany(p => p.BillingInvoiceService)
                    .HasForeignKey(d => d.BillingInvoiceIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingInvoiceService_BillingInvoice");

                entity.HasOne(d => d.ProposalIdFkNavigation)
                    .WithMany(p => p.BillingInvoiceService)
                    .HasForeignKey(d => d.ProposalIdFk)
                    .HasConstraintName("FK_BillingInvoiceService_BillingProposal");

                entity.HasOne(d => d.ServiceIdFkNavigation)
                    .WithMany(p => p.BillingInvoiceService)
                    .HasForeignKey(d => d.ServiceIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingInvoiceService_ServiceForBilling");
            });

            modelBuilder.Entity<BillingPackage>(entity =>
            {
                entity.Property(e => e.Status).IsFixedLength();

                entity.Property(e => e.Type).IsFixedLength();

                entity.HasOne(d => d.BillingService)
                    .WithMany(p => p.BillingPackage)
                    .HasForeignKey(d => d.BillingServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingPackage_BillingService");
            });

            modelBuilder.Entity<BillingPackageInformation>(entity =>
            {
                entity.HasKey(e => new { e.BillingPackageId, e.BillingServiceId });
            });

            modelBuilder.Entity<BillingPackageRequest>(entity =>
            {
                entity.HasKey(e => e.PackageRequestId)
                    .HasName("PK_PackageRequestID");

                entity.Property(e => e.BillingPostalCode).IsFixedLength();

                entity.Property(e => e.DiscountAmt).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.DiscountPercentage).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalPackageAmount).HasDefaultValueSql("((0.00))");
            });

            modelBuilder.Entity<BillingProposal>(entity =>
            {
                entity.Property(e => e.ProposalType).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.CreatedByFkNavigation)
                    .WithMany(p => p.BillingProposalCreatedByFkNavigation)
                    .HasForeignKey(d => d.CreatedByFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingProposal_Users");

                entity.HasOne(d => d.CurrencyIdFkNavigation)
                    .WithMany(p => p.BillingProposal)
                    .HasForeignKey(d => d.CurrencyIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingProposal_Code");

                entity.HasOne(d => d.ModifiedByFkNavigation)
                    .WithMany(p => p.BillingProposalModifiedByFkNavigation)
                    .HasForeignKey(d => d.ModifiedByFk)
                    .HasConstraintName("FK_BillingProposal_Users1");

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.BillingProposal)
                    .HasForeignKey(d => d.PatientIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingProposal_Patient");
            });

            modelBuilder.Entity<BillingProposalService>(entity =>
            {
                entity.HasOne(d => d.BillingProposalIdFkNavigation)
                    .WithMany(p => p.BillingProposalService)
                    .HasForeignKey(d => d.BillingProposalIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingProposalService_BillingProposal");

                entity.HasOne(d => d.ServiceIdFkNavigation)
                    .WithMany(p => p.BillingProposalService)
                    .HasForeignKey(d => d.ServiceIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingProposalService_ServiceForBilling");
            });

            modelBuilder.Entity<BillingService>(entity =>
            {
                entity.HasKey(e => e.ServiceId)
                    .HasName("PK_ServiceID");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.CategoryIdFkNavigation)
                    .WithMany(p => p.BillingService)
                    .HasForeignKey(d => d.CategoryIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillingService_Code");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.CurrencyIdFkNavigation)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.CurrencyIdFk)
                    .HasConstraintName("FK_Branch_Code");
            });

            modelBuilder.Entity<CarePlan>(entity =>
            {
                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CarePlanStatusIdFkNavigation)
                    .WithMany(p => p.CarePlan)
                    .HasForeignKey(d => d.CarePlanStatusIdFk)
                    .HasConstraintName("FK_CarePlan_CarePlanStatus");

                entity.HasOne(d => d.DiagnosisIdFkNavigation)
                    .WithMany(p => p.CarePlan)
                    .HasForeignKey(d => d.DiagnosisIdFk)
                    .HasConstraintName("FK_CarePlan_Diagnosis");

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.CarePlan)
                    .HasForeignKey(d => d.PatientIdFk)
                    .HasConstraintName("FK_CarePlan_Patient");
            });

            modelBuilder.Entity<CarePlanDetail>(entity =>
            {
                entity.HasOne(d => d.CarePlanSubIdFkNavigation)
                    .WithMany(p => p.CarePlanDetail)
                    .HasForeignKey(d => d.CarePlanSubIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarePlanDetail_CarePlanSub");

                entity.HasOne(d => d.DiseaseIdFkNavigation)
                    .WithMany(p => p.CarePlanDetail)
                    .HasForeignKey(d => d.DiseaseIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarePlanDetail_DiseaseForDisease");

                entity.HasOne(d => d.SystemIdFkNavigation)
                    .WithMany(p => p.CarePlanDetail)
                    .HasForeignKey(d => d.SystemIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarePlanDetail_SystemForDisease");
            });

            modelBuilder.Entity<CarePlanStatus>(entity =>
            {
                entity.Property(e => e.CarePlanStatusId).ValueGeneratedNever();

                entity.Property(e => e.CarePlanStatus1).IsUnicode(false);
            });

            modelBuilder.Entity<CarePlanSub>(entity =>
            {
                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CarePlanIdFkNavigation)
                    .WithMany(p => p.CarePlanSub)
                    .HasForeignKey(d => d.CarePlanIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarePlanSub_CarePlan");
            });

            modelBuilder.Entity<CarePlanSubActivity>(entity =>
            {
                entity.HasKey(e => new { e.CarePlanSubIdFk, e.ActivityIdFk });

                entity.HasOne(d => d.ActivityIdFkNavigation)
                    .WithMany(p => p.CarePlanSubActivity)
                    .HasForeignKey(d => d.ActivityIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarePlanSubActivity_Activity");

                entity.HasOne(d => d.CarePlanSubIdFkNavigation)
                    .WithMany(p => p.CarePlanSubActivity)
                    .HasForeignKey(d => d.CarePlanSubIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarePlanSubActivity_CarePlanSub");
            });

            modelBuilder.Entity<CarePlanSubCpgoals>(entity =>
            {
                entity.HasKey(e => new { e.CarePlanSubIdFk, e.CpgoalsIdFk });

                entity.HasOne(d => d.CarePlanSubIdFkNavigation)
                    .WithMany(p => p.CarePlanSubCpgoals)
                    .HasForeignKey(d => d.CarePlanSubIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarePlanSubCPGoals_CarePlanSub");

                entity.HasOne(d => d.CpgoalsIdFkNavigation)
                    .WithMany(p => p.CarePlanSubCpgoals)
                    .HasForeignKey(d => d.CpgoalsIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarePlanSubCPGoals_CPGoals");
            });

            modelBuilder.Entity<CarePlanSubGoal>(entity =>
            {
                entity.HasOne(d => d.CarePlanSubIdFkNavigation)
                    .WithMany(p => p.CarePlanSubGoal)
                    .HasForeignKey(d => d.CarePlanSubIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarePlanSubGoal_CarePlanSub");

                entity.HasOne(d => d.DiseaseIdFkNavigation)
                    .WithMany(p => p.CarePlanSubGoal)
                    .HasForeignKey(d => d.DiseaseIdFk)
                    .HasConstraintName("FK_CarePlanSubGoal_Disease");
            });

            modelBuilder.Entity<CarePlanSubIntervention>(entity =>
            {
                entity.HasKey(e => new { e.CarePlanSubIdFk, e.InterventionIdFk });

                entity.HasOne(d => d.CarePlanSubIdFkNavigation)
                    .WithMany(p => p.CarePlanSubIntervention)
                    .HasForeignKey(d => d.CarePlanSubIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarePlanSubIntervention_CarePlanSub");

                entity.HasOne(d => d.InterventionIdFkNavigation)
                    .WithMany(p => p.CarePlanSubIntervention)
                    .HasForeignKey(d => d.InterventionIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarePlanSubIntervention_Intervention");
            });

            modelBuilder.Entity<CarePlanSubProblemList>(entity =>
            {
                entity.HasOne(d => d.CarePlanSubIdFkNavigation)
                    .WithMany(p => p.CarePlanSubProblemList)
                    .HasForeignKey(d => d.CarePlanSubIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarePlanSubProblemList_CarePlanSub");

                entity.HasOne(d => d.ProblemListIdFkNavigation)
                    .WithMany(p => p.CarePlanSubProblemList)
                    .HasForeignKey(d => d.ProblemListIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarePlanSubProblemList_ProblemList");
            });

            modelBuilder.Entity<CarePlanSubProblemListGoal>(entity =>
            {
                entity.HasOne(d => d.CarePlanSubProblemListIdFkNavigation)
                    .WithMany(p => p.CarePlanSubProblemListGoal)
                    .HasForeignKey(d => d.CarePlanSubProblemListIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarePlanSubProblemListGoal_CarePlanSubProblemList");

                entity.HasOne(d => d.Operator)
                    .WithMany(p => p.CarePlanSubProblemListGoalOperator)
                    .HasForeignKey(d => d.OperatorId)
                    .HasConstraintName("FK_CarePlanSubProblemListGoal_Operator");

                entity.HasOne(d => d.ProblemListGoalIdFkNavigation)
                    .WithMany(p => p.CarePlanSubProblemListGoal)
                    .HasForeignKey(d => d.ProblemListGoalIdFk)
                    .HasConstraintName("FK_CarePlanSubProblemListGoal_ProblemListGoal");

                entity.HasOne(d => d.ScoreType)
                    .WithMany(p => p.CarePlanSubProblemListGoalScoreType)
                    .HasForeignKey(d => d.ScoreTypeId)
                    .HasConstraintName("FK_CarePlanSubProblemListGoal_ScoreType");
            });

            modelBuilder.Entity<CareReport>(entity =>
            {
                entity.Property(e => e.Environment).IsUnicode(false);

                entity.Property(e => e.PersonalHygiene).IsUnicode(false);

                entity.Property(e => e.SectionRequireInput).IsUnicode(false);

                entity.Property(e => e.SectionRequired).IsUnicode(false);

                entity.Property(e => e.SectionStatus).IsUnicode(false);

                entity.Property(e => e.SkinAndWoundCare).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.AirwayBreathingIdFkNavigation)
                    .WithMany(p => p.CareReportAirwayBreathingIdFkNavigation)
                    .HasForeignKey(d => d.AirwayBreathingIdFk)
                    .HasConstraintName("FK_CareReport_Code1");

                entity.HasOne(d => d.BladderCareIdFkNavigation)
                    .WithMany(p => p.CareReportBladderCareIdFkNavigation)
                    .HasForeignKey(d => d.BladderCareIdFk)
                    .HasConstraintName("FK_CareReport_Code15");

                entity.HasOne(d => d.BowelCareIdFkNavigation)
                    .WithMany(p => p.CareReportBowelCareIdFkNavigation)
                    .HasForeignKey(d => d.BowelCareIdFk)
                    .HasConstraintName("FK_CareReport_Code14");

                entity.HasOne(d => d.CapillaryRefillIdFkNavigation)
                    .WithMany(p => p.CareReportCapillaryRefillIdFkNavigation)
                    .HasForeignKey(d => d.CapillaryRefillIdFk)
                    .HasConstraintName("FK_CareReport_Code7");

                entity.HasOne(d => d.CarePlanIdFkNavigation)
                    .WithMany(p => p.CareReport)
                    .HasForeignKey(d => d.CarePlanIdFk)
                    .HasConstraintName("FK_CareReport_CarePlan");

                entity.HasOne(d => d.CareReportIdFkNavigation)
                    .WithMany(p => p.InverseCareReportIdFkNavigation)
                    .HasForeignKey(d => d.CareReportIdFk)
                    .HasConstraintName("FK_CareReport_CareReport");

                entity.HasOne(d => d.CareReportRehabilitationIdFkNavigation)
                    .WithMany(p => p.CareReport)
                    .HasForeignKey(d => d.CareReportRehabilitationIdFk)
                    .HasConstraintName("FK_CareReport_CareReportRehabilitation");

                entity.HasOne(d => d.CareReportSystemInfoIdFkNavigation)
                    .WithMany(p => p.CareReport)
                    .HasForeignKey(d => d.CareReportSystemInfoIdFk)
                    .HasConstraintName("FK_CareReport_CareReportSystemInfo");

                entity.HasOne(d => d.CirculationIdFkNavigation)
                    .WithMany(p => p.CareReportCirculationIdFkNavigation)
                    .HasForeignKey(d => d.CirculationIdFk)
                    .HasConstraintName("FK_CareReport_Code4");

                entity.HasOne(d => d.CoughIdFkNavigation)
                    .WithMany(p => p.CareReportCoughIdFkNavigation)
                    .HasForeignKey(d => d.CoughIdFk)
                    .HasConstraintName("FK_CareReport_Code2");

                entity.HasOne(d => d.DiapersIdFkNavigation)
                    .WithMany(p => p.CareReportDiapersIdFkNavigation)
                    .HasForeignKey(d => d.DiapersIdFk)
                    .HasConstraintName("FK_CareReport_Code16");

                entity.HasOne(d => d.LipsIdFkNavigation)
                    .WithMany(p => p.CareReportLipsIdFkNavigation)
                    .HasForeignKey(d => d.LipsIdFk)
                    .HasConstraintName("FK_CareReport_Code6");

                entity.HasOne(d => d.LowerEyelidsIdFkNavigation)
                    .WithMany(p => p.CareReportLowerEyelidsIdFkNavigation)
                    .HasForeignKey(d => d.LowerEyelidsIdFk)
                    .HasConstraintName("FK_CareReport_Code5");

                entity.HasOne(d => d.O2aidIdFkNavigation)
                    .WithMany(p => p.CareReportO2aidIdFkNavigation)
                    .HasForeignKey(d => d.O2aidIdFk)
                    .HasConstraintName("FK_CareReport_Code3");

                entity.HasOne(d => d.PainDescriptionIdFkNavigation)
                    .WithMany(p => p.CareReportPainDescriptionIdFkNavigation)
                    .HasForeignKey(d => d.PainDescriptionIdFk)
                    .HasConstraintName("FK_CareReport_Code");

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.CareReport)
                    .HasForeignKey(d => d.PatientIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CareReport_Patient");

                entity.HasOne(d => d.PatientNutritionIdFkNavigation)
                    .WithMany(p => p.CareReport)
                    .HasForeignKey(d => d.PatientNutritionIdFk)
                    .HasConstraintName("FK_CareReport_PatientNutrition");

                entity.HasOne(d => d.PeripheralPulsesPedalIdFkNavigation)
                    .WithMany(p => p.CareReportPeripheralPulsesPedalIdFkNavigation)
                    .HasForeignKey(d => d.PeripheralPulsesPedalIdFk)
                    .HasConstraintName("FK_CareReport_Code9");

                entity.HasOne(d => d.PeripheralPulsesRadialIdFkNavigation)
                    .WithMany(p => p.CareReportPeripheralPulsesRadialIdFkNavigation)
                    .HasForeignKey(d => d.PeripheralPulsesRadialIdFk)
                    .HasConstraintName("FK_CareReport_Code8");

                entity.HasOne(d => d.SleepRestIdFkNavigation)
                    .WithMany(p => p.CareReportSleepRestIdFkNavigation)
                    .HasForeignKey(d => d.SleepRestIdFk)
                    .HasConstraintName("FK_CareReport_Code10");

                entity.HasOne(d => d.TemperatureIdFkNavigation)
                    .WithMany(p => p.CareReportTemperatureIdFkNavigation)
                    .HasForeignKey(d => d.TemperatureIdFk)
                    .HasConstraintName("FK_CareReport_Code11");

                entity.HasOne(d => d.VisitedByFkNavigation)
                    .WithMany(p => p.CareReport)
                    .HasForeignKey(d => d.VisitedByFk)
                    .HasConstraintName("FK_CareReport_Users");

                entity.HasOne(d => d.VitalSignIdFkNavigation)
                    .WithMany(p => p.CareReport)
                    .HasForeignKey(d => d.VitalSignIdFk)
                    .HasConstraintName("FK_CareReport_VitalSigns");
            });

            modelBuilder.Entity<CareReportConfig>(entity =>
            {
                entity.Property(e => e.SectionAccess).IsUnicode(false);

                entity.HasOne(d => d.UserTypeIdFkNavigation)
                    .WithMany(p => p.CareReportConfig)
                    .HasForeignKey(d => d.UserTypeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CareReportConfig_UserType");
            });

            modelBuilder.Entity<CareReportSocialSupport>(entity =>
            {
                entity.HasOne(d => d.CareReportIdFkNavigation)
                    .WithMany(p => p.CareReportSocialSupport)
                    .HasForeignKey(d => d.CareReportIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CareReportSocialSupport_CareReport");

                entity.HasOne(d => d.PatientSocialSupportIdFkNavigation)
                    .WithMany(p => p.CareReportSocialSupport)
                    .HasForeignKey(d => d.PatientSocialSupportIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CareReportSocialSupport_PatientSocialSupport");
            });

            modelBuilder.Entity<CareReportSystemInfo>(entity =>
            {
                entity.HasOne(d => d.KeyPerson1UserIdFkNavigation)
                    .WithMany(p => p.CareReportSystemInfoKeyPerson1UserIdFkNavigation)
                    .HasForeignKey(d => d.KeyPerson1UserIdFk)
                    .HasConstraintName("FK_CareReportSystemInfo_Users1");

                entity.HasOne(d => d.KeyPerson2UserIdFkNavigation)
                    .WithMany(p => p.CareReportSystemInfoKeyPerson2UserIdFkNavigation)
                    .HasForeignKey(d => d.KeyPerson2UserIdFk)
                    .HasConstraintName("FK_CareReportSystemInfo_Users2");

                entity.HasOne(d => d.PrimaryDoctorUserIdFkNavigation)
                    .WithMany(p => p.CareReportSystemInfoPrimaryDoctorUserIdFkNavigation)
                    .HasForeignKey(d => d.PrimaryDoctorUserIdFk)
                    .HasConstraintName("FK_CareReportSystemInfo_PatientClinician1");

                entity.HasOne(d => d.SecondaryDoctorUserIdFkNavigation)
                    .WithMany(p => p.CareReportSystemInfoSecondaryDoctorUserIdFkNavigation)
                    .HasForeignKey(d => d.SecondaryDoctorUserIdFk)
                    .HasConstraintName("FK_CareReportSystemInfo_PatientClinician2");
            });

            modelBuilder.Entity<Chat>(entity =>
            {
                entity.Property(e => e.AttachmentPhysical).IsUnicode(false);

                entity.HasOne(d => d.CreatedByFkNavigation)
                    .WithMany(p => p.Chat)
                    .HasForeignKey(d => d.CreatedByFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chat_Users");

                entity.HasOne(d => d.ParentIdFkNavigation)
                    .WithMany(p => p.InverseParentIdFkNavigation)
                    .HasForeignKey(d => d.ParentIdFk)
                    .HasConstraintName("FK_Chat_Chat1");

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.Chat)
                    .HasForeignKey(d => d.PatientIdFk)
                    .HasConstraintName("FK_Chat_Patient1");
            });

            modelBuilder.Entity<Code>(entity =>
            {
                entity.Property(e => e.CurrencyCodeA).IsUnicode(false);

                entity.Property(e => e.CurrencyCodeN).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.CodeTypeIdFkNavigation)
                    .WithMany(p => p.Code)
                    .HasForeignKey(d => d.CodeTypeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Code_CodeType");

                entity.HasOne(d => d.MedicationGroupIdFkNavigation)
                    .WithMany(p => p.InverseMedicationGroupIdFkNavigation)
                    .HasForeignKey(d => d.MedicationGroupIdFk)
                    .HasConstraintName("FK_Code_Code");
            });

            modelBuilder.Entity<Cpgoals>(entity =>
            {
                entity.HasOne(d => d.DiseaseIdFkNavigation)
                    .WithMany(p => p.Cpgoals)
                    .HasForeignKey(d => d.DiseaseIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CPGoals_Disease");
            });

            modelBuilder.Entity<DischargeSummaryReport>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<DischargeSummaryReportAttachment>(entity =>
            {
                entity.Property(e => e.Physical).IsUnicode(false);

                entity.HasOne(d => d.DischargeSummaryReportIdFkNavigation)
                    .WithMany(p => p.DischargeSummaryReportAttachment)
                    .HasForeignKey(d => d.DischargeSummaryReportIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DischargeSummaryReportAttachment_DischargeSummaryReport");
            });

            modelBuilder.Entity<Disease>(entity =>
            {
                entity.HasOne(d => d.SystemIdFkNavigation)
                    .WithMany(p => p.Disease)
                    .HasForeignKey(d => d.SystemIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Disease_SystemForDisease");
            });

            modelBuilder.Entity<DiseaseInfo>(entity =>
            {
                entity.HasOne(d => d.DiseaseIdFkNavigation)
                    .WithMany(p => p.DiseaseInfo)
                    .HasForeignKey(d => d.DiseaseIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiseaseInfo_Disease");
            });

            modelBuilder.Entity<DiseaseSubInfo>(entity =>
            {
                entity.HasOne(d => d.DiseaseIdFkNavigation)
                    .WithMany(p => p.DiseaseSubInfo)
                    .HasForeignKey(d => d.DiseaseIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiseaseSubInfo_Disease");
            });

            modelBuilder.Entity<DiseaseVitalSignType>(entity =>
            {
                entity.HasOne(d => d.DiseaseIdFkNavigation)
                    .WithMany(p => p.DiseaseVitalSignType)
                    .HasForeignKey(d => d.DiseaseIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiseaseVitalSignType_Disease");

                entity.HasOne(d => d.VitalSignTypeIdFkNavigation)
                    .WithMany(p => p.DiseaseVitalSignType)
                    .HasForeignKey(d => d.VitalSignTypeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiseaseVitalSignType_VitalSignTypes");
            });

            modelBuilder.Entity<Enquiry>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.CareManagerAssignedIdFkNavigation)
                    .WithMany(p => p.Enquiry)
                    .HasForeignKey(d => d.CareManagerAssignedIdFk)
                    .HasConstraintName("FK_Enquiry_Users");

                entity.HasOne(d => d.CaregiverAtHomeIdFkNavigation)
                    .WithMany(p => p.EnquiryCaregiverAtHomeIdFkNavigation)
                    .HasForeignKey(d => d.CaregiverAtHomeIdFk)
                    .HasConstraintName("FK_Enquiry_CaregiverAtHome");

                entity.HasOne(d => d.EnquirySourceIdFkNavigation)
                    .WithMany(p => p.EnquiryEnquirySourceIdFkNavigation)
                    .HasForeignKey(d => d.EnquirySourceIdFk)
                    .HasConstraintName("FK_Enquiry_Source");

                entity.HasOne(d => d.GenderIdFkNavigation)
                    .WithMany(p => p.EnquiryGenderIdFkNavigation)
                    .HasForeignKey(d => d.GenderIdFk)
                    .HasConstraintName("FK_Enquiry_Gender");

                entity.HasOne(d => d.PreferredLanguageIdFkNavigation)
                    .WithMany(p => p.EnquiryPreferredLanguageIdFkNavigation)
                    .HasForeignKey(d => d.PreferredLanguageIdFk)
                    .HasConstraintName("FK_Enquiry_PreferredLanguage");

                entity.HasOne(d => d.RaceIdFkNavigation)
                    .WithMany(p => p.EnquiryRaceIdFkNavigation)
                    .HasForeignKey(d => d.RaceIdFk)
                    .HasConstraintName("FK_Enquiry_Race");

                entity.HasOne(d => d.ServicesRequiredIdFkNavigation)
                    .WithMany(p => p.EnquiryServicesRequiredIdFkNavigation)
                    .HasForeignKey(d => d.ServicesRequiredIdFk)
                    .HasConstraintName("FK_Enquiry_ServicesRequired");

                entity.HasOne(d => d.UserOrganizationIdFkNavigation)
                    .WithMany(p => p.EnquiryUserOrganizationIdFkNavigation)
                    .HasForeignKey(d => d.UserOrganizationIdFk)
                    .HasConstraintName("FK_Enquiry_Organization");
            });

            modelBuilder.Entity<EnquiryAttachment>(entity =>
            {
                entity.Property(e => e.Physical).IsUnicode(false);

                entity.HasOne(d => d.EnquiryIdFkNavigation)
                    .WithMany(p => p.EnquiryAttachment)
                    .HasForeignKey(d => d.EnquiryIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquiryAttachment_Enquiry");
            });

            modelBuilder.Entity<EnquiryConfig>(entity =>
            {
                entity.HasOne(d => d.EscalatingPersonIdFkNavigation)
                    .WithMany(p => p.EnquiryConfigEscalatingPersonIdFkNavigation)
                    .HasForeignKey(d => d.EscalatingPersonIdFk)
                    .HasConstraintName("FK_EnquiryConfig_Users_EscPersonID");

                entity.HasOne(d => d.ScmidFkNavigation)
                    .WithMany(p => p.EnquiryConfigScmidFkNavigation)
                    .HasForeignKey(d => d.ScmidFk)
                    .HasConstraintName("FK_EnquiryConfig_Users_SCMID");
            });

            modelBuilder.Entity<EnquiryEscPerson>(entity =>
            {
                entity.HasKey(e => new { e.EnquiryConfigId, e.UserIdFk });

                entity.HasOne(d => d.EnquiryConfig)
                    .WithMany(p => p.EnquiryEscPerson)
                    .HasForeignKey(d => d.EnquiryConfigId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquiryEscPerson_EnquiryConfig");

                entity.HasOne(d => d.UserIdFkNavigation)
                    .WithMany(p => p.EnquiryEscPerson)
                    .HasForeignKey(d => d.UserIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquiryEscPerson_Users");
            });

            modelBuilder.Entity<EnquiryLanguage>(entity =>
            {
                entity.HasKey(e => new { e.EnquiryIdFk, e.CodeIdFk });

                entity.HasOne(d => d.CodeIdFkNavigation)
                    .WithMany(p => p.EnquiryLanguage)
                    .HasForeignKey(d => d.CodeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquiryLanguage_Code");

                entity.HasOne(d => d.EnquiryIdFkNavigation)
                    .WithMany(p => p.EnquiryLanguage)
                    .HasForeignKey(d => d.EnquiryIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquiryLanguage_Enquiry");
            });

            modelBuilder.Entity<EnquiryScm>(entity =>
            {
                entity.HasKey(e => new { e.EnquiryConfigIdFk, e.UserIdFk });

                entity.HasOne(d => d.EnquiryConfigIdFkNavigation)
                    .WithMany(p => p.EnquiryScm)
                    .HasForeignKey(d => d.EnquiryConfigIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquirySCM_EnquiryConfig");

                entity.HasOne(d => d.UserIdFkNavigation)
                    .WithMany(p => p.EnquiryScm)
                    .HasForeignKey(d => d.UserIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquirySCM_Users");
            });

            modelBuilder.Entity<EnquiryServicesRequired>(entity =>
            {
                entity.HasKey(e => new { e.EnquiryIdFk, e.CodeIdFk });

                entity.HasOne(d => d.CodeIdFkNavigation)
                    .WithMany(p => p.EnquiryServicesRequired)
                    .HasForeignKey(d => d.CodeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquiryServicesRequired_Code");

                entity.HasOne(d => d.EnquiryIdFkNavigation)
                    .WithMany(p => p.EnquiryServicesRequired)
                    .HasForeignKey(d => d.EnquiryIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnquiryServicesRequired_Enquiry");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasOne(d => d.CreatedByFkNavigation)
                    .WithMany(p => p.Event)
                    .HasForeignKey(d => d.CreatedByFk)
                    .HasConstraintName("FK_Event_Users");

                entity.HasOne(d => d.EventTypeIdFkNavigation)
                    .WithMany(p => p.EventEventTypeIdFkNavigation)
                    .HasForeignKey(d => d.EventTypeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_Code1");

                entity.HasOne(d => d.PeriodTypeIdFkNavigation)
                    .WithMany(p => p.EventPeriodTypeIdFkNavigation)
                    .HasForeignKey(d => d.PeriodTypeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Event_Code2");
            });

            modelBuilder.Entity<EventUser>(entity =>
            {
                entity.HasOne(d => d.EventIdFkNavigation)
                    .WithMany(p => p.EventUser)
                    .HasForeignKey(d => d.EventIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventUser_Event");

                entity.HasOne(d => d.UserIdFkNavigation)
                    .WithMany(p => p.EventUser)
                    .HasForeignKey(d => d.UserIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventUser_Users");
            });

            modelBuilder.Entity<EventUserLog>(entity =>
            {
                entity.HasOne(d => d.EventIdFkNavigation)
                    .WithMany(p => p.EventUserLog)
                    .HasForeignKey(d => d.EventIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventUserLog_Event");

                entity.HasOne(d => d.UserIdFkNavigation)
                    .WithMany(p => p.EventUserLog)
                    .HasForeignKey(d => d.UserIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventUserLog_Users");
            });

            modelBuilder.Entity<ExternalDoctor>(entity =>
            {
                entity.HasOne(d => d.ClinicianTypeIdFkNavigation)
                    .WithMany(p => p.ExternalDoctor)
                    .HasForeignKey(d => d.ClinicianTypeIdFk)
                    .HasConstraintName("FK_ExternalDoctor_UserType");
            });

            modelBuilder.Entity<GroupRole>(entity =>
            {
                entity.HasKey(e => new { e.GroupIdFk, e.RoleIdFk });

                entity.Property(e => e.Role).HasDefaultValueSql("('')");

                entity.HasOne(d => d.GroupIdFkNavigation)
                    .WithMany(p => p.GroupRole)
                    .HasForeignKey(d => d.GroupIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupRole_Group");

                entity.HasOne(d => d.RoleIdFkNavigation)
                    .WithMany(p => p.GroupRole)
                    .HasForeignKey(d => d.RoleIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupRole_Role");
            });

            modelBuilder.Entity<IcawoundCare>(entity =>
            {
                entity.HasKey(e => new { e.InitialCareAssessmentIdFk, e.CodeIdFk });

                entity.HasOne(d => d.CodeIdFkNavigation)
                    .WithMany(p => p.IcawoundCare)
                    .HasForeignKey(d => d.CodeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ICAWoundCare_Code");

                entity.HasOne(d => d.InitialCareAssessmentIdFkNavigation)
                    .WithMany(p => p.IcawoundCare)
                    .HasForeignKey(d => d.InitialCareAssessmentIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ICAWoundCare_InitialCareAssessment");
            });

            modelBuilder.Entity<InitialCareAssessment>(entity =>
            {
                entity.Property(e => e.SectionStatus).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.PatientAdditionalInfoIdFkNavigation)
                    .WithMany(p => p.InitialCareAssessment)
                    .HasForeignKey(d => d.PatientAdditionalInfoIdFk)
                    .HasConstraintName("FK_InitialCareAssessment_PatientAdditionalInfo");

                entity.HasOne(d => d.PatientMbiidFkNavigation)
                    .WithMany(p => p.InitialCareAssessment)
                    .HasForeignKey(d => d.PatientMbiidFk)
                    .HasConstraintName("FK_InitialCareAssessment_PatientMBI");

                entity.HasOne(d => d.PatientMedicationIdFkNavigation)
                    .WithMany(p => p.InitialCareAssessment)
                    .HasForeignKey(d => d.PatientMedicationIdFk)
                    .HasConstraintName("FK_InitialCareAssessment_PatientMedication");

                entity.HasOne(d => d.PatientMfsidFkNavigation)
                    .WithMany(p => p.InitialCareAssessment)
                    .HasForeignKey(d => d.PatientMfsidFk)
                    .HasConstraintName("FK_InitialCareAssessment_PatientMFS");

                entity.HasOne(d => d.PatientNutritionIdFkNavigation)
                    .WithMany(p => p.InitialCareAssessment)
                    .HasForeignKey(d => d.PatientNutritionIdFk)
                    .HasConstraintName("FK_InitialCareAssessment_PatientNutrition");

                entity.HasOne(d => d.PatientProfileIdFkNavigation)
                    .WithMany(p => p.InitialCareAssessment)
                    .HasForeignKey(d => d.PatientProfileIdFk)
                    .HasConstraintName("FK_InitialCareAssessment_PatientProfile");

                entity.HasOne(d => d.PatientRafidFkNavigation)
                    .WithMany(p => p.InitialCareAssessment)
                    .HasForeignKey(d => d.PatientRafidFk)
                    .HasConstraintName("FK_InitialCareAssessment_PatientRAF");

                entity.HasOne(d => d.PatientReferralIdFkNavigation)
                    .WithMany(p => p.InitialCareAssessment)
                    .HasForeignKey(d => d.PatientReferralIdFk)
                    .HasConstraintName("FK_InitialCareAssessment_PatientReferral");

                entity.HasOne(d => d.VitalSignIdFkNavigation)
                    .WithMany(p => p.InitialCareAssessment)
                    .HasForeignKey(d => d.VitalSignIdFk)
                    .HasConstraintName("FK_InitialCareAssessment_VitalSigns");
            });

            modelBuilder.Entity<InitialCareAssessmentAttachment>(entity =>
            {
                entity.Property(e => e.Physical).IsUnicode(false);

                entity.HasOne(d => d.InitialCareAssessmentIdFkNavigation)
                    .WithMany(p => p.InitialCareAssessmentAttachment)
                    .HasForeignKey(d => d.InitialCareAssessmentIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InitialCareAssessmentAttachment_InitialCareAssessment");
            });

            modelBuilder.Entity<InitialCareAssessmentSpecialInstruction>(entity =>
            {
                entity.HasOne(d => d.InitialCareAssessmentIdFkNavigation)
                    .WithMany(p => p.InitialCareAssessmentSpecialInstruction)
                    .HasForeignKey(d => d.InitialCareAssessmentIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InitialCareAssessmentSpecialInstruction_InitialCareAssessment");
            });

            modelBuilder.Entity<InitialCareAssessmentVitalSign>(entity =>
            {
                entity.HasKey(e => new { e.InitialCareAssessmentIdFk, e.VitalSignIdFk });
            });

            modelBuilder.Entity<Intervention>(entity =>
            {
                entity.HasOne(d => d.DiseaseIdFkNavigation)
                    .WithMany(p => p.Intervention)
                    .HasForeignKey(d => d.DiseaseIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Intervention_Disease");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasOne(d => d.CategoryIdFkNavigation)
                    .WithMany(p => p.ItemCategoryIdFkNavigation)
                    .HasForeignKey(d => d.CategoryIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Code");

                entity.HasOne(d => d.ItemUnitIdFkNavigation)
                    .WithMany(p => p.ItemItemUnitIdFkNavigation)
                    .HasForeignKey(d => d.ItemUnitIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Item_Code1");
            });

            modelBuilder.Entity<ItemStock>(entity =>
            {
                entity.HasOne(d => d.ItemIdFkNavigation)
                    .WithMany(p => p.ItemStock)
                    .HasForeignKey(d => d.ItemIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemStock_Item");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.Property(e => e.FullName).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<MailSettings>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<MedicationVitalSignType>(entity =>
            {
                entity.HasOne(d => d.MedicationIdFkNavigation)
                    .WithMany(p => p.MedicationVitalSignType)
                    .HasForeignKey(d => d.MedicationIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicationVitalSignType_Code");

                entity.HasOne(d => d.VitalSignTypeIdFkNavigation)
                    .WithMany(p => p.MedicationVitalSignType)
                    .HasForeignKey(d => d.VitalSignTypeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicationVitalSignType_VitalSignTypes");
            });

            modelBuilder.Entity<MultiDisciplinaryMeeting>(entity =>
            {
                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.MultiDisciplinaryMeeting)
                    .HasForeignKey(d => d.PatientIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MultiDisciplinaryMeeting_Patient");
            });

            modelBuilder.Entity<MultiDisciplinaryMeetingDetail>(entity =>
            {
                entity.HasOne(d => d.MultiDisciplinaryMeetingIdFkNavigation)
                    .WithMany(p => p.MultiDisciplinaryMeetingDetail)
                    .HasForeignKey(d => d.MultiDisciplinaryMeetingIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MultiDisciplinaryMeetingDetail_MultiDisciplinaryMeeting");
            });

            modelBuilder.Entity<NotificationChat>(entity =>
            {
                entity.HasOne(d => d.ChatIdFkNavigation)
                    .WithMany(p => p.NotificationChat)
                    .HasForeignKey(d => d.ChatIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationChat_Chat");

                entity.HasOne(d => d.NotificationIdFkNavigation)
                    .WithMany(p => p.NotificationChat)
                    .HasForeignKey(d => d.NotificationIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationChat_Notifications");
            });

            modelBuilder.Entity<NotificationEvent>(entity =>
            {
                entity.HasOne(d => d.EventIdFkNavigation)
                    .WithMany(p => p.NotificationEvent)
                    .HasForeignKey(d => d.EventIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationEvent_Event");

                entity.HasOne(d => d.NotificationIdFkNavigation)
                    .WithMany(p => p.NotificationEvent)
                    .HasForeignKey(d => d.NotificationIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationEvent_Notifications");
            });

            modelBuilder.Entity<NotificationMessageTemplates>(entity =>
            {
                entity.HasIndex(e => e.NotificationgroupCode)
                    .HasName("idx_NotificationMessageTemplates1");

                entity.HasOne(d => d.NotificationgroupCodeNavigation)
                    .WithMany(p => p.NotificationMessageTemplates)
                    .HasForeignKey(d => d.NotificationgroupCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_NotificationMessageTemplates_notificationgroupCode");
            });

            modelBuilder.Entity<NotificationTask>(entity =>
            {
                entity.HasOne(d => d.NotificationIdFkNavigation)
                    .WithMany(p => p.NotificationTask)
                    .HasForeignKey(d => d.NotificationIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationTask_Notifications");

                entity.HasOne(d => d.TaskIdFkNavigation)
                    .WithMany(p => p.NotificationTask)
                    .HasForeignKey(d => d.TaskIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationTask_Task");
            });

            modelBuilder.Entity<NotificationVitalSignDetails>(entity =>
            {
                entity.HasIndex(e => new { e.NotificationId, e.VitalSignDetailId })
                    .HasName("idx_NotificationVitalSignDetails1");

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.NotificationVitalSignDetails)
                    .HasForeignKey(d => d.NotificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_NotificationVitalSignDetails_notificationId");

                entity.HasOne(d => d.VitalSignDetail)
                    .WithMany(p => p.NotificationVitalSignDetails)
                    .HasForeignKey(d => d.VitalSignDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotificationVitalSignDetails_VitalSignDetails");
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.HasIndex(e => e.IsRead)
                    .HasName("idx_Notifications2");

                entity.HasIndex(e => e.UserId)
                    .HasName("idx_Notifications3");

                entity.HasIndex(e => new { e.UserId, e.IsRead })
                    .HasName("idx_Notifications1");

                entity.HasOne(d => d.NotificationTypeCodeNavigation)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.NotificationTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Notifications_notificationTypeCode");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Notifications_userId");
            });

            modelBuilder.Entity<NutritionTask>(entity =>
            {
                entity.Property(e => e.AfterImage).IsUnicode(false);

                entity.Property(e => e.BeforeImage).IsUnicode(false);

                entity.HasOne(d => d.ActionTypeIdFkNavigation)
                    .WithMany(p => p.NutritionTask)
                    .HasForeignKey(d => d.ActionTypeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutritionTask_Code");

                entity.HasOne(d => d.AmountReferenceIdFkNavigation)
                    .WithMany(p => p.NutritionTaskAmountReferenceIdFkNavigation)
                    .HasForeignKey(d => d.AmountReferenceIdFk)
                    .HasConstraintName("FK_NutritionTask_NutritionTaskReference2");

                entity.HasOne(d => d.ColorReferenceIdFkNavigation)
                    .WithMany(p => p.NutritionTaskColorReferenceIdFkNavigation)
                    .HasForeignKey(d => d.ColorReferenceIdFk)
                    .HasConstraintName("FK_NutritionTask_NutritionTaskReference3");

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.NutritionTask)
                    .HasForeignKey(d => d.PatientIdFk)
                    .HasConstraintName("FK_NutritionTask_Patient");

                entity.HasOne(d => d.TypeReferenceIdFkNavigation)
                    .WithMany(p => p.NutritionTaskTypeReferenceIdFkNavigation)
                    .HasForeignKey(d => d.TypeReferenceIdFk)
                    .HasConstraintName("FK_NutritionTask_NutritionTaskReference1");
            });

            modelBuilder.Entity<NutritionTaskReference>(entity =>
            {
                entity.Property(e => e.ReferenceImage).IsUnicode(false);

                entity.HasOne(d => d.CodeIdFkNavigation)
                    .WithMany(p => p.NutritionTaskReference)
                    .HasForeignKey(d => d.CodeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NutritionTaskReference_Code");
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.Property(e => e.PackageDetails).IsUnicode(false);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.GenogramPicture).IsUnicode(false);

                entity.Property(e => e.IdentificationAttachmentPhysical).IsUnicode(false);

                entity.Property(e => e.MailForFamilyNotification1).IsUnicode(false);

                entity.Property(e => e.MailForFamilyNotification2).IsUnicode(false);

                entity.Property(e => e.MailForVitalAlert1).IsUnicode(false);

                entity.Property(e => e.MailForVitalAlert2).IsUnicode(false);

                entity.Property(e => e.MailForVitalAlert3).IsUnicode(false);

                entity.Property(e => e.Occupation).IsUnicode(false);

                entity.Property(e => e.PaymentMode).IsUnicode(false);

                entity.Property(e => e.Photo).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.BloodTypeIdFkNavigation)
                    .WithMany(p => p.PatientBloodTypeIdFkNavigation)
                    .HasForeignKey(d => d.BloodTypeIdFk)
                    .HasConstraintName("FK_Patient_Code2");

                entity.HasOne(d => d.GenderIdFkNavigation)
                    .WithMany(p => p.PatientGenderIdFkNavigation)
                    .HasForeignKey(d => d.GenderIdFk)
                    .HasConstraintName("FK_Patient_Code1");

                entity.HasOne(d => d.MaritalStatusIdFkNavigation)
                    .WithMany(p => p.PatientMaritalStatusIdFkNavigation)
                    .HasForeignKey(d => d.MaritalStatusIdFk)
                    .HasConstraintName("FK_Patient_Code4");

                entity.HasOne(d => d.PatientAdditionalInfoIdFkNavigation)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.PatientAdditionalInfoIdFk)
                    .HasConstraintName("FK_Patient_PatientAdditionalInfo");

                entity.HasOne(d => d.PatientMedicationIdFkNavigation)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.PatientMedicationIdFk)
                    .HasConstraintName("FK_Patient_PatientMedication");

                entity.HasOne(d => d.PatientProfileIdFkNavigation)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.PatientProfileIdFk)
                    .HasConstraintName("FK_Patient_PatientProfile");

                entity.HasOne(d => d.PatientReferralByIdFkNavigation)
                    .WithMany(p => p.PatientPatientReferralByIdFkNavigation)
                    .HasForeignKey(d => d.PatientReferralByIdFk)
                    .HasConstraintName("FK_Patient_Code7");

                entity.HasOne(d => d.PatientReferralIdFkNavigation)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.PatientReferralIdFk)
                    .HasConstraintName("FK_Patient_PatientReferral");

                entity.HasOne(d => d.PatientTypeIdFkNavigation)
                    .WithMany(p => p.PatientPatientTypeIdFkNavigation)
                    .HasForeignKey(d => d.PatientTypeIdFk)
                    .HasConstraintName("FK_Patient_Code");

                entity.HasOne(d => d.RaceIdFkNavigation)
                    .WithMany(p => p.PatientRaceIdFkNavigation)
                    .HasForeignKey(d => d.RaceIdFk)
                    .HasConstraintName("FK_Patient_Code6");

                entity.HasOne(d => d.ReligionIdFkNavigation)
                    .WithMany(p => p.PatientReligionIdFkNavigation)
                    .HasForeignKey(d => d.ReligionIdFk)
                    .HasConstraintName("FK_Patient_Code5");

                entity.HasOne(d => d.ResidentTypeIdFkNavigation)
                    .WithMany(p => p.PatientResidentTypeIdFkNavigation)
                    .HasForeignKey(d => d.ResidentTypeIdFk)
                    .HasConstraintName("FK_Patient_Code3");
            });

            modelBuilder.Entity<PatientAccessLine>(entity =>
            {
                entity.HasOne(d => d.CareReportIdFkNavigation)
                    .WithMany(p => p.PatientAccessLine)
                    .HasForeignKey(d => d.CareReportIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientAccessLine_CareReport");
            });

            modelBuilder.Entity<PatientAmt>(entity =>
            {
                entity.HasOne(d => d.CareReportIdFkNavigation)
                    .WithMany(p => p.PatientAmt)
                    .HasForeignKey(d => d.CareReportIdFk)
                    .HasConstraintName("FK_PatientAMT_CareReport");

                entity.HasOne(d => d.InitialCareAssessmentIdFkNavigation)
                    .WithMany(p => p.PatientAmt)
                    .HasForeignKey(d => d.InitialCareAssessmentIdFk)
                    .HasConstraintName("FK_PatientAMT_InitialCareAssessment");

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.PatientAmt)
                    .HasForeignKey(d => d.PatientIdFk)
                    .HasConstraintName("FK_PatientAMT_Patient");

                entity.HasOne(d => d.VitalSignDetailIdFkNavigation)
                    .WithMany(p => p.PatientAmt)
                    .HasForeignKey(d => d.VitalSignDetailIdFk)
                    .HasConstraintName("FK_PatientAMT_VitalSignDetails");
            });

            modelBuilder.Entity<PatientAmtanswer>(entity =>
            {
                entity.HasKey(e => new { e.PatientAmtidFk, e.AmtquestionIdFk });

                entity.HasOne(d => d.AmtquestionIdFkNavigation)
                    .WithMany(p => p.PatientAmtanswer)
                    .HasForeignKey(d => d.AmtquestionIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientAMTAnswer_AMTQuestion");

                entity.HasOne(d => d.PatientAmtidFkNavigation)
                    .WithMany(p => p.PatientAmtanswer)
                    .HasForeignKey(d => d.PatientAmtidFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientAMTAnswer_PatientAMT");
            });

            modelBuilder.Entity<PatientAttachment>(entity =>
            {
                entity.Property(e => e.Physical).IsUnicode(false);

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.PatientAttachment)
                    .HasForeignKey(d => d.PatientIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientAttachment_Patient");
            });

            modelBuilder.Entity<PatientBradenScale>(entity =>
            {
                entity.Property(e => e.Type).IsUnicode(false);

                entity.HasOne(d => d.VitalSignDetailIdFkNavigation)
                    .WithMany(p => p.PatientBradenScale)
                    .HasForeignKey(d => d.VitalSignDetailIdFk)
                    .HasConstraintName("FK_PatientBradenScale_VitalSignDetails");
            });

            modelBuilder.Entity<PatientClinician>(entity =>
            {
                entity.HasOne(d => d.DiseaseIdFkNavigation)
                    .WithMany(p => p.PatientClinician)
                    .HasForeignKey(d => d.DiseaseIdFk)
                    .HasConstraintName("FK_PatientClinician_Disease");

                entity.HasOne(d => d.DiseaseSubInfoIdFkNavigation)
                    .WithMany(p => p.PatientClinician)
                    .HasForeignKey(d => d.DiseaseSubInfoIdFk)
                    .HasConstraintName("FK_PatientClinician_DiseaseSubInfo");

                entity.HasOne(d => d.ExternalDoctorIdFkNavigation)
                    .WithMany(p => p.PatientClinician)
                    .HasForeignKey(d => d.ExternalDoctorIdFk)
                    .HasConstraintName("FK_PatientClinician_ExternalDoctor");

                entity.HasOne(d => d.InitialCareAssessmentIdFkNavigation)
                    .WithMany(p => p.PatientClinician)
                    .HasForeignKey(d => d.InitialCareAssessmentIdFk)
                    .HasConstraintName("FK_PatientClinician_InitialCareAssessment");

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.PatientClinician)
                    .HasForeignKey(d => d.PatientIdFk)
                    .HasConstraintName("FK_PatientClinician_Patient");

                entity.HasOne(d => d.UserIdFkNavigation)
                    .WithMany(p => p.PatientClinician)
                    .HasForeignKey(d => d.UserIdFk)
                    .HasConstraintName("FK_PatientClinician_Users");
            });

            modelBuilder.Entity<PatientDrugAllergy>(entity =>
            {
                entity.HasKey(e => e.DrugAllergyId)
                    .HasName("PK_PatientDrugAllery");

                entity.HasOne(d => d.InitialCareAssessmentIdFkNavigation)
                    .WithMany(p => p.PatientDrugAllergy)
                    .HasForeignKey(d => d.InitialCareAssessmentIdFk)
                    .HasConstraintName("FK_PatientDrugAllery_InitialCareAssessment");

                entity.HasOne(d => d.MedicationIdFkNavigation)
                    .WithMany(p => p.PatientDrugAllergyMedicationIdFkNavigation)
                    .HasForeignKey(d => d.MedicationIdFk)
                    .HasConstraintName("FK_PatientDrugAllergy_Code1");

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.PatientDrugAllergy)
                    .HasForeignKey(d => d.PatientIdFk)
                    .HasConstraintName("FK_PatientDrugAllery_Patient");

                entity.HasOne(d => d.ReactionIdFkNavigation)
                    .WithMany(p => p.PatientDrugAllergyReactionIdFkNavigation)
                    .HasForeignKey(d => d.ReactionIdFk)
                    .HasConstraintName("FK_PatientDrugAllergy_Code");

                entity.HasOne(d => d.ReferIdFkNavigation)
                    .WithMany(p => p.InverseReferIdFkNavigation)
                    .HasForeignKey(d => d.ReferIdFk)
                    .HasConstraintName("FK_PatientDrugAllergy_PatientDrugAllergy");
            });

            modelBuilder.Entity<PatientEbasdep>(entity =>
            {
                entity.HasOne(d => d.CareReportIdFkNavigation)
                    .WithMany(p => p.PatientEbasdep)
                    .HasForeignKey(d => d.CareReportIdFk)
                    .HasConstraintName("FK_PatientEBASDEP_CareReport");

                entity.HasOne(d => d.InitialCareAssessmentIdFkNavigation)
                    .WithMany(p => p.PatientEbasdep)
                    .HasForeignKey(d => d.InitialCareAssessmentIdFk)
                    .HasConstraintName("FK_PatientEBASDEP_InitialCareAssessment");

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.PatientEbasdep)
                    .HasForeignKey(d => d.PatientIdFk)
                    .HasConstraintName("FK_PatientEBASDEP_Patient");

                entity.HasOne(d => d.VitalSignDetailIdFkNavigation)
                    .WithMany(p => p.PatientEbasdep)
                    .HasForeignKey(d => d.VitalSignDetailIdFk)
                    .HasConstraintName("FK_PatientEBASDEP_VitalSignDetails");
            });

            modelBuilder.Entity<PatientEbasdepanswer>(entity =>
            {
                entity.HasKey(e => new { e.PatientEbasdepidFk, e.EbasdepquestionIdFk });

                entity.HasOne(d => d.EbasdepquestionIdFkNavigation)
                    .WithMany(p => p.PatientEbasdepanswer)
                    .HasForeignKey(d => d.EbasdepquestionIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientEBASDEPAnswer_EBASDEPQuestion");

                entity.HasOne(d => d.PatientEbasdepidFkNavigation)
                    .WithMany(p => p.PatientEbasdepanswer)
                    .HasForeignKey(d => d.PatientEbasdepidFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientEBASDEPAnswer_PatientEBASDEP");
            });

            modelBuilder.Entity<PatientFamilyHistory>(entity =>
            {
                entity.HasOne(d => d.DiseaseIdFkNavigation)
                    .WithMany(p => p.PatientFamilyHistory)
                    .HasForeignKey(d => d.DiseaseIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientFamilyHistory_Disease");

                entity.HasOne(d => d.DiseaseSubInfoIdFkNavigation)
                    .WithMany(p => p.PatientFamilyHistory)
                    .HasForeignKey(d => d.DiseaseSubInfoIdFk)
                    .HasConstraintName("FK_PatientFamilyHistory_DiseaseSubInfo");

                entity.HasOne(d => d.InitialCareAssessmentIdFkNavigation)
                    .WithMany(p => p.PatientFamilyHistory)
                    .HasForeignKey(d => d.InitialCareAssessmentIdFk)
                    .HasConstraintName("FK_PatientFamilyHistory_InitialCareAssessment");

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.PatientFamilyHistory)
                    .HasForeignKey(d => d.PatientIdFk)
                    .HasConstraintName("FK_PatientFamilyHistory_Patient");
            });

            modelBuilder.Entity<PatientGcs>(entity =>
            {
                entity.Property(e => e.Type).IsUnicode(false);

                entity.HasOne(d => d.VitalSignDetailIdFkNavigation)
                    .WithMany(p => p.PatientGcs)
                    .HasForeignKey(d => d.VitalSignDetailIdFk)
                    .HasConstraintName("FK_PatientGCS_VitalSignDetails");
            });

            modelBuilder.Entity<PatientImmunisation>(entity =>
            {
                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.PatientImmunisation)
                    .HasForeignKey(d => d.PatientIdFk)
                    .HasConstraintName("FK_PatientImmunisation_Patient");
            });

            modelBuilder.Entity<PatientLanguage>(entity =>
            {
                entity.HasKey(e => new { e.PatientIdFk, e.CodeIdFk });

                entity.HasOne(d => d.CodeIdFkNavigation)
                    .WithMany(p => p.PatientLanguage)
                    .HasForeignKey(d => d.CodeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientLanguage_Code");

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.PatientLanguage)
                    .HasForeignKey(d => d.PatientIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientLanguage_Patient");
            });

            modelBuilder.Entity<PatientMbi>(entity =>
            {
                entity.Property(e => e.Type).IsUnicode(false);

                entity.HasOne(d => d.VitalSignDetailIdFkNavigation)
                    .WithMany(p => p.PatientMbi)
                    .HasForeignKey(d => d.VitalSignDetailIdFk)
                    .HasConstraintName("FK_PatientMBI_VitalSignDetails");
            });

            modelBuilder.Entity<PatientMedicalHistory>(entity =>
            {
                entity.HasOne(d => d.ClinicianIdFkNavigation)
                    .WithMany(p => p.PatientMedicalHistory)
                    .HasForeignKey(d => d.ClinicianIdFk)
                    .HasConstraintName("FK_PatientMedicalHistory_PatientClinician");

                entity.HasOne(d => d.MedicalStatusIdFkNavigation)
                    .WithMany(p => p.PatientMedicalHistory)
                    .HasForeignKey(d => d.MedicalStatusIdFk)
                    .HasConstraintName("FK_PatientMedicalHistory_Status");

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.PatientMedicalHistory)
                    .HasForeignKey(d => d.PatientIdFk)
                    .HasConstraintName("FK_PatientMedicalHistory_Patient");
            });

            modelBuilder.Entity<PatientMedicationConsume>(entity =>
            {
                entity.HasOne(d => d.AcutePrnindicationIdFkNavigation)
                    .WithMany(p => p.PatientMedicationConsumeAcutePrnindicationIdFkNavigation)
                    .HasForeignKey(d => d.AcutePrnindicationIdFk)
                    .HasConstraintName("FK_PatientMedicationConsume_Code3");

                entity.HasOne(d => d.ChronicDiseaseIdFkNavigation)
                    .WithMany(p => p.PatientMedicationConsume)
                    .HasForeignKey(d => d.ChronicDiseaseIdFk)
                    .HasConstraintName("FK_PatientMedicationConsume_Disease");

                entity.HasOne(d => d.ChronicDiseaseSubInfoIdFkNavigation)
                    .WithMany(p => p.PatientMedicationConsume)
                    .HasForeignKey(d => d.ChronicDiseaseSubInfoIdFk)
                    .HasConstraintName("FK_PatientMedicationConsume_DiseaseSubInfo");

                entity.HasOne(d => d.DosageIdFkNavigation)
                    .WithMany(p => p.PatientMedicationConsumeDosageIdFkNavigation)
                    .HasForeignKey(d => d.DosageIdFk)
                    .HasConstraintName("FK_PatientMedicationConsume_Code1");

                entity.HasOne(d => d.FrequencyIdFkNavigation)
                    .WithMany(p => p.PatientMedicationConsumeFrequencyIdFkNavigation)
                    .HasForeignKey(d => d.FrequencyIdFk)
                    .HasConstraintName("FK_PatientMedicationConsume_Code2");

                entity.HasOne(d => d.InstructedBy2IdFkNavigation)
                    .WithMany(p => p.PatientMedicationConsumeInstructedBy2IdFkNavigation)
                    .HasForeignKey(d => d.InstructedBy2IdFk)
                    .HasConstraintName("FK_PatientMedicationConsume_InstructedBy2ID_FK");

                entity.HasOne(d => d.InstructedByIdFkNavigation)
                    .WithMany(p => p.PatientMedicationConsumeInstructedByIdFkNavigation)
                    .HasForeignKey(d => d.InstructedByIdFk)
                    .HasConstraintName("FK_PatientMedicationConsume_InstructedByID_FK");

                entity.HasOne(d => d.MedicationIdFkNavigation)
                    .WithMany(p => p.PatientMedicationConsumeMedicationIdFkNavigation)
                    .HasForeignKey(d => d.MedicationIdFk)
                    .HasConstraintName("FK_PatientMedicationConsume_Code4");

                entity.HasOne(d => d.PatientMedicationIdFkNavigation)
                    .WithMany(p => p.PatientMedicationConsume)
                    .HasForeignKey(d => d.PatientMedicationIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientMedicationConsume_PatientMedication");

                entity.HasOne(d => d.ReferIdFkNavigation)
                    .WithMany(p => p.InverseReferIdFkNavigation)
                    .HasForeignKey(d => d.ReferIdFk)
                    .HasConstraintName("FK_PatientMedicationConsume_PatientMedicationConsume");

                entity.HasOne(d => d.RouteIdFkNavigation)
                    .WithMany(p => p.PatientMedicationConsumeRouteIdFkNavigation)
                    .HasForeignKey(d => d.RouteIdFk)
                    .HasConstraintName("FK_PatientMedicationConsume_Code");
            });

            modelBuilder.Entity<PatientMedicationConsumeAttachment>(entity =>
            {
                entity.Property(e => e.Physical).IsUnicode(false);

                entity.HasOne(d => d.PatientMedicationConsumeIdFkNavigation)
                    .WithMany(p => p.PatientMedicationConsumeAttachment)
                    .HasForeignKey(d => d.PatientMedicationConsumeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientMedicationConsumeAttachment_PatientMedicationConsume");
            });

            modelBuilder.Entity<PatientMedicationSupply>(entity =>
            {
                entity.HasKey(e => new { e.PatientMedicationIdFk, e.SupplyIdFk });

                entity.HasOne(d => d.PatientMedicationIdFkNavigation)
                    .WithMany(p => p.PatientMedicationSupply)
                    .HasForeignKey(d => d.PatientMedicationIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientMedicationSupply_PatientMedication");

                entity.HasOne(d => d.SupplyIdFkNavigation)
                    .WithMany(p => p.PatientMedicationSupply)
                    .HasForeignKey(d => d.SupplyIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientMedicationSupply_Code");
            });

            modelBuilder.Entity<PatientMfs>(entity =>
            {
                entity.Property(e => e.Type).IsUnicode(false);

                entity.HasOne(d => d.VitalSignDetailIdFkNavigation)
                    .WithMany(p => p.PatientMfs)
                    .HasForeignKey(d => d.VitalSignDetailIdFk)
                    .HasConstraintName("FK_PatientMFS_VitalSignDetails");
            });

            modelBuilder.Entity<PatientMmse>(entity =>
            {
                entity.Property(e => e.Type).IsUnicode(false);

                entity.HasOne(d => d.VitalSignDetailIdFkNavigation)
                    .WithMany(p => p.PatientMmse)
                    .HasForeignKey(d => d.VitalSignDetailIdFk)
                    .HasConstraintName("FK_PatientMMSE_VitalSignDetails");
            });

            modelBuilder.Entity<PatientOtherAllergy>(entity =>
            {
                entity.HasOne(d => d.DescriptionIdFkNavigation)
                    .WithMany(p => p.PatientOtherAllergyDescriptionIdFkNavigation)
                    .HasForeignKey(d => d.DescriptionIdFk)
                    .HasConstraintName("FK_PatientOtherAllergy_Code1");

                entity.HasOne(d => d.InitialCareAssessmentIdFkNavigation)
                    .WithMany(p => p.PatientOtherAllergy)
                    .HasForeignKey(d => d.InitialCareAssessmentIdFk)
                    .HasConstraintName("FK_PatientOtherAllergy_InitialCareAssessment");

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.PatientOtherAllergy)
                    .HasForeignKey(d => d.PatientIdFk)
                    .HasConstraintName("FK_PatientOtherAllergy_Patient");

                entity.HasOne(d => d.ReactionIdFkNavigation)
                    .WithMany(p => p.PatientOtherAllergyReactionIdFkNavigation)
                    .HasForeignKey(d => d.ReactionIdFk)
                    .HasConstraintName("FK_PatientOtherAllergy_Code");

                entity.HasOne(d => d.ReferIdFkNavigation)
                    .WithMany(p => p.InverseReferIdFkNavigation)
                    .HasForeignKey(d => d.ReferIdFk)
                    .HasConstraintName("FK_PatientOtherAllergy_PatientDrugAllergy");
            });

            modelBuilder.Entity<PatientPackage>(entity =>
            {
                entity.HasKey(e => new { e.PackageIdFk, e.PatientIdFk });

                entity.HasOne(d => d.PackageIdFkNavigation)
                    .WithMany(p => p.PatientPackage)
                    .HasForeignKey(d => d.PackageIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientPackage_Package");

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.PatientPackage)
                    .HasForeignKey(d => d.PatientIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientPackage_Patient");
            });

            modelBuilder.Entity<PatientProfile>(entity =>
            {
                entity.HasOne(d => d.BloodTypeIdFkNavigation)
                    .WithMany(p => p.PatientProfileBloodTypeIdFkNavigation)
                    .HasForeignKey(d => d.BloodTypeIdFk)
                    .HasConstraintName("FK_PatientProfile_Code");

                entity.HasOne(d => d.ReligionIdFkNavigation)
                    .WithMany(p => p.PatientProfileReligionIdFkNavigation)
                    .HasForeignKey(d => d.ReligionIdFk)
                    .HasConstraintName("FK_PatientProfile_Code1");
            });

            modelBuilder.Entity<PatientRaf>(entity =>
            {
                entity.Property(e => e.Type).IsUnicode(false);

                entity.HasOne(d => d.VitalSignDetailIdFkNavigation)
                    .WithMany(p => p.PatientRaf)
                    .HasForeignKey(d => d.VitalSignDetailIdFk)
                    .HasConstraintName("FK_PatientRAF_VitalSignDetails");
            });

            modelBuilder.Entity<PatientReferral>(entity =>
            {
                entity.HasOne(d => d.PrimaryClinicianIdFkNavigation)
                    .WithMany(p => p.PatientReferralPrimaryClinicianIdFkNavigation)
                    .HasForeignKey(d => d.PrimaryClinicianIdFk)
                    .HasConstraintName("FK_PatientReferral_PatientClinician2");

                entity.HasOne(d => d.PrimaryNurseIdFkNavigation)
                    .WithMany(p => p.PatientReferralPrimaryNurseIdFkNavigation)
                    .HasForeignKey(d => d.PrimaryNurseIdFk)
                    .HasConstraintName("FK_PatientReferral_PatientClinician4");

                entity.HasOne(d => d.SecondaryClinicianIdFkNavigation)
                    .WithMany(p => p.PatientReferralSecondaryClinicianIdFkNavigation)
                    .HasForeignKey(d => d.SecondaryClinicianIdFk)
                    .HasConstraintName("FK_PatientReferral_PatientClinician3");

                entity.HasOne(d => d.SecondaryNurseIdFkNavigation)
                    .WithMany(p => p.PatientReferralSecondaryNurseIdFkNavigation)
                    .HasForeignKey(d => d.SecondaryNurseIdFk)
                    .HasConstraintName("FK_PatientReferral_PatientClinician5");
            });

            modelBuilder.Entity<PatientReferralService>(entity =>
            {
                entity.HasKey(e => new { e.PatientReferralIdFk, e.ServiceIdFk });

                entity.HasOne(d => d.PatientReferralIdFkNavigation)
                    .WithMany(p => p.PatientReferralService)
                    .HasForeignKey(d => d.PatientReferralIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientReferralService_PatientReferral");

                entity.HasOne(d => d.ServiceIdFkNavigation)
                    .WithMany(p => p.PatientReferralService)
                    .HasForeignKey(d => d.ServiceIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientReferralService_Code");
            });

            modelBuilder.Entity<PatientSocialSupport>(entity =>
            {
                entity.HasOne(d => d.GenderIdFkNavigation)
                    .WithMany(p => p.PatientSocialSupportGenderIdFkNavigation)
                    .HasForeignKey(d => d.GenderIdFk)
                    .HasConstraintName("FK_PatientSocialSupport_Code3");

                entity.HasOne(d => d.InitialCareAssessmentIdFkNavigation)
                    .WithMany(p => p.PatientSocialSupport)
                    .HasForeignKey(d => d.InitialCareAssessmentIdFk)
                    .HasConstraintName("FK_PatientSocialSupport_InitialCareAssessment");

                entity.HasOne(d => d.MaritalStatusIdFkNavigation)
                    .WithMany(p => p.PatientSocialSupportMaritalStatusIdFkNavigation)
                    .HasForeignKey(d => d.MaritalStatusIdFk)
                    .HasConstraintName("FK_PatientSocialSupport_Code");

                entity.HasOne(d => d.NationalityIdFkNavigation)
                    .WithMany(p => p.PatientSocialSupportNationalityIdFkNavigation)
                    .HasForeignKey(d => d.NationalityIdFk)
                    .HasConstraintName("FK_PatientSocialSupport_Code2");

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.PatientSocialSupport)
                    .HasForeignKey(d => d.PatientIdFk)
                    .HasConstraintName("FK_PatientSocialSupport_Patient");

                entity.HasOne(d => d.RelationshipIdFkNavigation)
                    .WithMany(p => p.PatientSocialSupportRelationshipIdFkNavigation)
                    .HasForeignKey(d => d.RelationshipIdFk)
                    .HasConstraintName("FK_PatientSocialSupport_Code1");
            });

            modelBuilder.Entity<PatientSpecialIndicator>(entity =>
            {
                entity.HasKey(e => new { e.PatientIdFk, e.CodeIdFk });

                entity.HasOne(d => d.CodeIdFkNavigation)
                    .WithMany(p => p.PatientSpecialIndicator)
                    .HasForeignKey(d => d.CodeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientSpecialIndicator_Code");

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.PatientSpecialIndicator)
                    .HasForeignKey(d => d.PatientIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientSpecialIndicator_Patient");
            });

            modelBuilder.Entity<PatientWound>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.HasOne(d => d.CareReportIdFkNavigation)
                    .WithMany(p => p.PatientWound)
                    .HasForeignKey(d => d.CareReportIdFk)
                    .HasConstraintName("FK_PatientWound_CareReport");

                entity.HasOne(d => d.InitialCareAssessmentIdFkNavigation)
                    .WithMany(p => p.PatientWound)
                    .HasForeignKey(d => d.InitialCareAssessmentIdFk)
                    .HasConstraintName("FK_PatientWound_InitialCareAssessment");

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.PatientWound)
                    .HasForeignKey(d => d.PatientIdFk)
                    .HasConstraintName("FK_PatientWound_Patient");

                entity.HasOne(d => d.WoundStatusIdFkNavigation)
                    .WithMany(p => p.PatientWound)
                    .HasForeignKey(d => d.WoundStatusIdFk)
                    .HasConstraintName("FK_PatientWound_Code");
            });

            modelBuilder.Entity<PatientWoundVisit>(entity =>
            {
                entity.Property(e => e.AverageDepth).HasDefaultValueSql("((0))");

                entity.Property(e => e.ImageUpload).IsUnicode(false);

                entity.Property(e => e.IsDraft).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsRedness).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSmell).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSwelling).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsWarmToTouch).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaximumDepth).HasDefaultValueSql("((0))");

                entity.Property(e => e.MinimumDepth).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModelJpg).IsUnicode(false);

                entity.Property(e => e.ModelMtl).IsUnicode(false);

                entity.Property(e => e.ModelObj).IsUnicode(false);

                entity.Property(e => e.Perimeter).HasDefaultValueSql("((0))");

                entity.Property(e => e.Size).HasDefaultValueSql("((0))");

                entity.Property(e => e.SizeDepth).HasDefaultValueSql("((0))");

                entity.Property(e => e.SizeLength).HasDefaultValueSql("((0))");

                entity.Property(e => e.SizeWidth).HasDefaultValueSql("((0))");

                entity.Property(e => e.Suffering).HasDefaultValueSql("((0))");

                entity.Property(e => e.SurfaceArea).HasDefaultValueSql("((0))");

                entity.Property(e => e.TcAnnotatedImage).IsUnicode(false);

                entity.Property(e => e.TcAutoEpithelizing).HasDefaultValueSql("((0))");

                entity.Property(e => e.TcAutoGranulation).HasDefaultValueSql("((0))");

                entity.Property(e => e.TcAutoNecrosis).HasDefaultValueSql("((0))");

                entity.Property(e => e.TcAutoOthers).HasDefaultValueSql("((0))");

                entity.Property(e => e.TcAutoSlough).HasDefaultValueSql("((0))");

                entity.Property(e => e.TcEpithelizing).HasDefaultValueSql("((0))");

                entity.Property(e => e.TcGranulation).HasDefaultValueSql("((0))");

                entity.Property(e => e.TcIsAccept).HasDefaultValueSql("((0))");

                entity.Property(e => e.TcNecrosis).HasDefaultValueSql("((0))");

                entity.Property(e => e.TcOriginalImage).IsUnicode(false);

                entity.Property(e => e.TcOthers).HasDefaultValueSql("((0))");

                entity.Property(e => e.TcSlough).HasDefaultValueSql("((0))");

                entity.Property(e => e.TcWoundBedImage).IsUnicode(false);

                entity.Property(e => e.ToComments).IsUnicode(false);

                entity.Property(e => e.UnderMiningDepth).HasDefaultValueSql("((0))");

                entity.Property(e => e.Volume).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.AssignedToIdFkNavigation)
                    .WithMany(p => p.PatientWoundVisit)
                    .HasForeignKey(d => d.AssignedToIdFk)
                    .HasConstraintName("FK_PatientWoundVisit_Users");

                entity.HasOne(d => d.CareReportIdFkNavigation)
                    .WithMany(p => p.PatientWoundVisit)
                    .HasForeignKey(d => d.CareReportIdFk)
                    .HasConstraintName("FK_PatientWoundVisit_CareReport");

                entity.HasOne(d => d.InitialCareAssessmentIdFkNavigation)
                    .WithMany(p => p.PatientWoundVisit)
                    .HasForeignKey(d => d.InitialCareAssessmentIdFk)
                    .HasConstraintName("FK_PatientWoundVisit_InitialCareAssessment");

                entity.HasOne(d => d.PatientWoundIdFkNavigation)
                    .WithMany(p => p.PatientWoundVisit)
                    .HasForeignKey(d => d.PatientWoundIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientWoundVisit_PatientWound");

                entity.HasOne(d => d.ReferIdFkNavigation)
                    .WithMany(p => p.InverseReferIdFkNavigation)
                    .HasForeignKey(d => d.ReferIdFk)
                    .HasConstraintName("FK_PatientWoundVisit_PatientWoundVisit");

                entity.HasOne(d => d.VitalSignIdFkNavigation)
                    .WithMany(p => p.PatientWoundVisit)
                    .HasForeignKey(d => d.VitalSignIdFk)
                    .HasConstraintName("FK_PatientWoundVisit_VitalSigns");
            });

            modelBuilder.Entity<PatientWoundVisitAppearance>(entity =>
            {
                entity.HasKey(e => new { e.PatientWoundVisitIdFk, e.CodeIdFk });

                entity.HasOne(d => d.CodeIdFkNavigation)
                    .WithMany(p => p.PatientWoundVisitAppearance)
                    .HasForeignKey(d => d.CodeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientWoundVisitAppearance_Code");

                entity.HasOne(d => d.PatientWoundVisitIdFkNavigation)
                    .WithMany(p => p.PatientWoundVisitAppearance)
                    .HasForeignKey(d => d.PatientWoundVisitIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientWoundVisitAppearance_PatientWoundVisit");
            });

            modelBuilder.Entity<PatientWoundVisitCleansingItem>(entity =>
            {
                entity.HasKey(e => new { e.PatientWoundVisitIdFk, e.CodeIdFk });

                entity.HasOne(d => d.CodeIdFkNavigation)
                    .WithMany(p => p.PatientWoundVisitCleansingItem)
                    .HasForeignKey(d => d.CodeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientWoundVisitCleansingItem_Code");

                entity.HasOne(d => d.PatientWoundVisitIdFkNavigation)
                    .WithMany(p => p.PatientWoundVisitCleansingItem)
                    .HasForeignKey(d => d.PatientWoundVisitIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientWoundVisitCleansingItem_PatientWoundVisit");
            });

            modelBuilder.Entity<PatientWoundVisitClinician>(entity =>
            {
                entity.HasOne(d => d.ExternalDoctorIdFkNavigation)
                    .WithMany(p => p.PatientWoundVisitClinician)
                    .HasForeignKey(d => d.ExternalDoctorIdFk)
                    .HasConstraintName("FK_PatientWoundVisitClinician_ExternalDoctor");

                entity.HasOne(d => d.PatientWoundVisitIdFkNavigation)
                    .WithMany(p => p.PatientWoundVisitClinician)
                    .HasForeignKey(d => d.PatientWoundVisitIdFk)
                    .HasConstraintName("FK_PatientWoundVisitClinician_PatientWoundVisit");

                entity.HasOne(d => d.UserIdFkNavigation)
                    .WithMany(p => p.PatientWoundVisitClinician)
                    .HasForeignKey(d => d.UserIdFk)
                    .HasConstraintName("FK_PatientWoundVisitClinician_Users");
            });

            modelBuilder.Entity<PatientWoundVisitTreatment>(entity =>
            {
                entity.HasOne(d => d.ItemIdFkNavigation)
                    .WithMany(p => p.PatientWoundVisitTreatment)
                    .HasForeignKey(d => d.ItemIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientWoundVisitTreatment_Item");

                entity.HasOne(d => d.PatientWoundVisitIdFkNavigation)
                    .WithMany(p => p.PatientWoundVisitTreatment)
                    .HasForeignKey(d => d.PatientWoundVisitIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientWoundVisitTreatment_PatientWoundVisit");
            });

            modelBuilder.Entity<PatientWoundVisitTreatmentList>(entity =>
            {
                entity.HasOne(d => d.PatientWoundVisitIdFkNavigation)
                    .WithMany(p => p.PatientWoundVisitTreatmentList)
                    .HasForeignKey(d => d.PatientWoundVisitIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientWoundVisitTreatmentList_PatientWoundVisit");

                entity.HasOne(d => d.TlistItemIdFkNavigation)
                    .WithMany(p => p.PatientWoundVisitTreatmentList)
                    .HasForeignKey(d => d.TlistItemIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientWoundVisitTreatmentList_TreatmentListItem");
            });

            modelBuilder.Entity<PatientWoundVisitTreatmentObjectives>(entity =>
            {
                entity.HasKey(e => new { e.PatientWoundVisitIdFk, e.ObjectiveIdFk });

                entity.HasOne(d => d.ObjectiveIdFkNavigation)
                    .WithMany(p => p.PatientWoundVisitTreatmentObjectives)
                    .HasForeignKey(d => d.ObjectiveIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientWoundVisitTreatmentObjectives_Code");

                entity.HasOne(d => d.PatientWoundVisitIdFkNavigation)
                    .WithMany(p => p.PatientWoundVisitTreatmentObjectives)
                    .HasForeignKey(d => d.PatientWoundVisitIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientWoundVisitTreatmentObjectives_PatientWoundVisit");
            });

            modelBuilder.Entity<ProblemList>(entity =>
            {
                entity.HasOne(d => d.DiseaseIdFkNavigation)
                    .WithMany(p => p.ProblemList)
                    .HasForeignKey(d => d.DiseaseIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProblemList_Disease");
            });

            modelBuilder.Entity<ProblemListGoal>(entity =>
            {
                entity.HasOne(d => d.Operator)
                    .WithMany(p => p.ProblemListGoalOperator)
                    .HasForeignKey(d => d.OperatorId)
                    .HasConstraintName("FK_ProblemListGoal_Operator");

                entity.HasOne(d => d.ProblemListIdFkNavigation)
                    .WithMany(p => p.ProblemListGoal)
                    .HasForeignKey(d => d.ProblemListIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProblemListGoal_ProblemList");

                entity.HasOne(d => d.ScoreType)
                    .WithMany(p => p.ProblemListGoalScoreType)
                    .HasForeignKey(d => d.ScoreTypeId)
                    .HasConstraintName("FK_ProblemListGoal_ScoreType");
            });

            modelBuilder.Entity<Receipt>(entity =>
            {
                entity.HasOne(d => d.CreatedByFkNavigation)
                    .WithMany(p => p.ReceiptCreatedByFkNavigation)
                    .HasForeignKey(d => d.CreatedByFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Receipt_Users");

                entity.HasOne(d => d.CurrencyIdFkNavigation)
                    .WithMany(p => p.ReceiptCurrencyIdFkNavigation)
                    .HasForeignKey(d => d.CurrencyIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Receipt_Code1");

                entity.HasOne(d => d.ModifiedByFkNavigation)
                    .WithMany(p => p.ReceiptModifiedByFkNavigation)
                    .HasForeignKey(d => d.ModifiedByFk)
                    .HasConstraintName("FK_Receipt_Users1");

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.Receipt)
                    .HasForeignKey(d => d.PatientIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Receipt_Patient");

                entity.HasOne(d => d.PaymentModeIdFkNavigation)
                    .WithMany(p => p.ReceiptPaymentModeIdFkNavigation)
                    .HasForeignKey(d => d.PaymentModeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Receipt_Code");
            });

            modelBuilder.Entity<ReceiptForInvoice>(entity =>
            {
                entity.HasOne(d => d.BillingInvoiceIdFkNavigation)
                    .WithMany(p => p.ReceiptForInvoice)
                    .HasForeignKey(d => d.BillingInvoiceIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceiptForInv_Inv");

                entity.HasOne(d => d.ReceiptIdFkNavigation)
                    .WithMany(p => p.ReceiptForInvoice)
                    .HasForeignKey(d => d.ReceiptIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceiptForInv_Receipt");
            });

            modelBuilder.Entity<RecentView>(entity =>
            {
                entity.HasKey(e => new { e.UserIdFk, e.PatientIdFk });

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.RecentView)
                    .HasForeignKey(d => d.PatientIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecentView_Patient");

                entity.HasOne(d => d.UserIdFkNavigation)
                    .WithMany(p => p.RecentView)
                    .HasForeignKey(d => d.UserIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecentView_Users");
            });

            modelBuilder.Entity<RegisteredDevice>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DeviceId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.HasOne(d => d.Code)
                    .WithMany(p => p.Resource)
                    .HasForeignKey(d => d.CodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Resource_Code");

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Resource)
                    .HasForeignKey(d => d.LanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Resource_Language");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OptionText).HasDefaultValueSql("('')");

                entity.Property(e => e.OptionType).HasDefaultValueSql("('')");

                entity.Property(e => e.OptionValue).HasDefaultValueSql("('')");

                entity.Property(e => e.RoleDescription).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ScheduledTasks>(entity =>
            {
                entity.Property(e => e.ScheduleId).ValueGeneratedNever();

                entity.Property(e => e.PerformTask).HasDefaultValueSql("('D')");

                entity.Property(e => e.ScheduleDescription).HasDefaultValueSql("('')");

                entity.Property(e => e.Status).HasDefaultValueSql("('')");

                entity.Property(e => e.WeekDays).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ServiceForBilling>(entity =>
            {
                entity.HasOne(d => d.CategoryIdFkNavigation)
                    .WithMany(p => p.ServiceForBilling)
                    .HasForeignKey(d => d.CategoryIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceForBilling_Code");
            });

            modelBuilder.Entity<ServiceForBillingCost>(entity =>
            {
                entity.HasOne(d => d.CurrencyIdFkNavigation)
                    .WithMany(p => p.ServiceForBillingCost)
                    .HasForeignKey(d => d.CurrencyIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceForBillingCost_Code");

                entity.HasOne(d => d.ServiceForBillingIdFkNavigation)
                    .WithMany(p => p.ServiceForBillingCost)
                    .HasForeignKey(d => d.ServiceForBillingIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceForBillingCost_ServiceForBilling");
            });

            modelBuilder.Entity<ServiceSkillset>(entity =>
            {
                entity.HasKey(e => new { e.ServiceIdFk, e.SkillsetIdFk });

                entity.HasOne(d => d.ServiceIdFkNavigation)
                    .WithMany(p => p.ServiceSkillsetServiceIdFkNavigation)
                    .HasForeignKey(d => d.ServiceIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceSkillset_Code1");

                entity.HasOne(d => d.SkillsetIdFkNavigation)
                    .WithMany(p => p.ServiceSkillsetSkillsetIdFkNavigation)
                    .HasForeignKey(d => d.SkillsetIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceSkillset_Code");
            });

            modelBuilder.Entity<SysConfig>(entity =>
            {
                entity.Property(e => e.ConfigName).IsUnicode(false);
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasIndex(e => new { e.ReferenceType, e.ReferenceId })
                    .HasName("IX_Task_Reference");

                entity.Property(e => e.ReferenceType).IsUnicode(false);

                entity.HasOne(d => d.ActionTypeIdFkNavigation)
                    .WithMany(p => p.TaskActionTypeIdFkNavigation)
                    .HasForeignKey(d => d.ActionTypeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_Code");

                entity.HasOne(d => d.CreatedByFkNavigation)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.CreatedByFk)
                    .HasConstraintName("FK_Task_Users");

                entity.HasOne(d => d.DosageIdFkNavigation)
                    .WithMany(p => p.TaskDosageIdFkNavigation)
                    .HasForeignKey(d => d.DosageIdFk)
                    .HasConstraintName("FK_Task_Code2");

                entity.HasOne(d => d.FrequencyIdFkNavigation)
                    .WithMany(p => p.TaskFrequencyIdFkNavigation)
                    .HasForeignKey(d => d.FrequencyIdFk)
                    .HasConstraintName("FK_Task_Code1");

                entity.HasOne(d => d.InitialCareAssessmentIdFkNavigation)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.InitialCareAssessmentIdFk)
                    .HasConstraintName("FK_Task_InitialCareAssessment");

                entity.HasOne(d => d.MedicationIdFkNavigation)
                    .WithMany(p => p.TaskMedicationIdFkNavigation)
                    .HasForeignKey(d => d.MedicationIdFk)
                    .HasConstraintName("FK_Task_Code3");

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.PatientIdFk)
                    .HasConstraintName("FK_Task_Patient");
            });

            modelBuilder.Entity<TaskFileAttachment>(entity =>
            {
                entity.Property(e => e.FileName).IsUnicode(false);

                entity.HasOne(d => d.TaskIdFkNavigation)
                    .WithMany(p => p.TaskFileAttachment)
                    .HasForeignKey(d => d.TaskIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskFileAttachment_Task");
            });

            modelBuilder.Entity<TaskServicesRequired>(entity =>
            {
                entity.HasKey(e => new { e.TaskIdFk, e.CodeIdFk });

                entity.HasOne(d => d.CodeIdFkNavigation)
                    .WithMany(p => p.TaskServicesRequired)
                    .HasForeignKey(d => d.CodeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskServicesRequired_Code");

                entity.HasOne(d => d.TaskIdFkNavigation)
                    .WithMany(p => p.TaskServicesRequired)
                    .HasForeignKey(d => d.TaskIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskServicesRequired_Task");
            });

            modelBuilder.Entity<TaskSpecificDate>(entity =>
            {
                entity.HasOne(d => d.TaskIdFkNavigation)
                    .WithMany(p => p.TaskSpecificDate)
                    .HasForeignKey(d => d.TaskIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskSpecificDate_Task");
            });

            modelBuilder.Entity<TaskUser>(entity =>
            {
                entity.Property(e => e.UserType).IsUnicode(false);

                entity.HasOne(d => d.TaskIdFkNavigation)
                    .WithMany(p => p.TaskUser)
                    .HasForeignKey(d => d.TaskIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskUser_Task");

                entity.HasOne(d => d.UserIdFkNavigation)
                    .WithMany(p => p.TaskUser)
                    .HasForeignKey(d => d.UserIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskUser_Users");
            });

            modelBuilder.Entity<TaskUserLog>(entity =>
            {
                entity.HasIndex(e => e.EndDate)
                    .HasName("IX_TaskUserLog_2");

                entity.HasIndex(e => e.StartDate)
                    .HasName("IX_TaskUserLog_1");

                entity.HasIndex(e => e.TaskIdFk)
                    .HasName("IX_TaskUserLog_3");

                entity.HasIndex(e => new { e.StartDate, e.EndDate, e.TaskIdFk })
                    .HasName("IX_TaskUserLog");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.TaskIdFkNavigation)
                    .WithMany(p => p.TaskUserLog)
                    .HasForeignKey(d => d.TaskIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskUserLog_Task");

                entity.HasOne(d => d.UserIdFkNavigation)
                    .WithMany(p => p.TaskUserLog)
                    .HasForeignKey(d => d.UserIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskUserLog_Users");
            });

            modelBuilder.Entity<TaskUserLogAttachment>(entity =>
            {
                entity.Property(e => e.FileName).IsUnicode(false);

                entity.HasOne(d => d.TaskUserLogIdFkNavigation)
                    .WithMany(p => p.TaskUserLogAttachment)
                    .HasForeignKey(d => d.TaskUserLogIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaskUserLogAttachment_TaskUserLog");
            });

            modelBuilder.Entity<TdWoundAssessmentFactor>(entity =>
            {
                entity.HasKey(e => new { e.TdWoundAssessmentIdFk, e.CodeIdFk });

                entity.HasOne(d => d.CodeIdFkNavigation)
                    .WithMany(p => p.TdWoundAssessmentFactor)
                    .HasForeignKey(d => d.CodeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TD_WoundAssessmentFactor_Code");
            });

            modelBuilder.Entity<TeleconsultationRecording>(entity =>
            {
                entity.Property(e => e.Sid)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.TeleconsultationRecording)
                    .HasForeignKey(d => d.PatientIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeleconsultationRecording_Patient");

                entity.HasOne(d => d.RecordingTypeFkNavigation)
                    .WithMany(p => p.TeleconsultationRecording)
                    .HasForeignKey(d => d.RecordingTypeFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeleconsultationRecording_Code");
            });

            modelBuilder.Entity<TeleconsultationReport>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<TreatmentListItem>(entity =>
            {
                entity.HasOne(d => d.TlistTypeIdFkNavigation)
                    .WithMany(p => p.TreatmentListItem)
                    .HasForeignKey(d => d.TlistTypeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TreatmentListItem_Code");
            });

            modelBuilder.Entity<TreatmentTol>(entity =>
            {
                entity.HasKey(e => new { e.TreatmentTolid, e.TlistItemIdFk });

                entity.HasOne(d => d.TlistItemIdFkNavigation)
                    .WithMany(p => p.TreatmentTol)
                    .HasForeignKey(d => d.TlistItemIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TreatmentTOL_TreatmentListItem");
            });

            modelBuilder.Entity<Types>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__Types__357D4CF8421046E1");

                entity.HasIndex(e => new { e.Code, e.ParentCode })
                    .HasName("idx_Types1");

                entity.HasOne(d => d.ParentCodeNavigation)
                    .WithMany(p => p.InverseParentCodeNavigation)
                    .HasForeignKey(d => d.ParentCode)
                    .HasConstraintName("fk_Types_parentCode");
            });

            modelBuilder.Entity<UserAddress>(entity =>
            {
                entity.HasOne(d => d.UserIdFkNavigation)
                    .WithMany(p => p.UserAddress)
                    .HasForeignKey(d => d.UserIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAddress_Users");
            });

            modelBuilder.Entity<UserBranch>(entity =>
            {
                entity.HasKey(e => new { e.UserIdFk, e.BranchIdFk });

                entity.HasOne(d => d.BranchIdFkNavigation)
                    .WithMany(p => p.UserBranch)
                    .HasForeignKey(d => d.BranchIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserBranch_Branch");

                entity.HasOne(d => d.UserIdFkNavigation)
                    .WithMany(p => p.UserBranch)
                    .HasForeignKey(d => d.UserIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserBranch_Users");
            });

            modelBuilder.Entity<UserCategoryRole>(entity =>
            {
                entity.HasKey(e => new { e.UserCategoryIdFk, e.RoleIdFk });

                entity.HasOne(d => d.RoleIdFkNavigation)
                    .WithMany(p => p.UserCategoryRole)
                    .HasForeignKey(d => d.RoleIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCategoryRole_Role");

                entity.HasOne(d => d.UserCategoryIdFkNavigation)
                    .WithMany(p => p.UserCategoryRole)
                    .HasForeignKey(d => d.UserCategoryIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCategoryRole_UserCategory");
            });

            modelBuilder.Entity<UserLanguage>(entity =>
            {
                entity.HasKey(e => new { e.UserIdFk, e.LanguageIdFk });

                entity.HasOne(d => d.LanguageIdFkNavigation)
                    .WithMany(p => p.UserLanguage)
                    .HasForeignKey(d => d.LanguageIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserLanguage_Code");

                entity.HasOne(d => d.UserIdFkNavigation)
                    .WithMany(p => p.UserLanguage)
                    .HasForeignKey(d => d.UserIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserLanguage_Users");
            });

            modelBuilder.Entity<UserOrganization>(entity =>
            {
                entity.HasKey(e => new { e.UserIdFk, e.CodeIdFk });

                entity.HasOne(d => d.CodeIdFkNavigation)
                    .WithMany(p => p.UserOrganization)
                    .HasForeignKey(d => d.CodeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserOrganization_Code");

                entity.HasOne(d => d.UserIdFkNavigation)
                    .WithMany(p => p.UserOrganization)
                    .HasForeignKey(d => d.UserIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserOrganization_Users");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserIdFk, e.RoleIdFk });

                entity.Property(e => e.Role).HasDefaultValueSql("('')");

                entity.HasOne(d => d.RoleIdFkNavigation)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.RoleIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_Role");

                entity.HasOne(d => d.UserIdFkNavigation)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.UserIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_Users");
            });

            modelBuilder.Entity<UserSkillset>(entity =>
            {
                entity.HasKey(e => new { e.UserIdFk, e.CodeIdFk });

                entity.HasOne(d => d.CodeIdFkNavigation)
                    .WithMany(p => p.UserSkillset)
                    .HasForeignKey(d => d.CodeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSkillset_Code");

                entity.HasOne(d => d.UserIdFkNavigation)
                    .WithMany(p => p.UserSkillset)
                    .HasForeignKey(d => d.UserIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSkillset_Users");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.HasOne(d => d.UserCategoryIdFkNavigation)
                    .WithMany(p => p.UserType)
                    .HasForeignKey(d => d.UserCategoryIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserType_UserCategory");
            });

            modelBuilder.Entity<UserUserType>(entity =>
            {
                entity.HasKey(e => new { e.UserIdFk, e.UserTypeIdFk });

                entity.HasOne(d => d.UserIdFkNavigation)
                    .WithMany(p => p.UserUserType)
                    .HasForeignKey(d => d.UserIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserUserType_Users");

                entity.HasOne(d => d.UserTypeIdFkNavigation)
                    .WithMany(p => p.UserUserType)
                    .HasForeignKey(d => d.UserTypeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserUserType_UserType");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Photo).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.PatientIdFkNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.PatientIdFk)
                    .HasConstraintName("FK_Users_Patient");
            });

            modelBuilder.Entity<Uuidlog>(entity =>
            {
                entity.Property(e => e.Uuid).IsUnicode(false);
            });

            modelBuilder.Entity<VitalSignDetails>(entity =>
            {
                entity.HasOne(d => d.VitalSign)
                    .WithMany(p => p.VitalSignDetails)
                    .HasForeignKey(d => d.VitalSignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_VitalSignDetails_vitalSignId");

                entity.HasOne(d => d.VitalSignType)
                    .WithMany(p => p.VitalSignDetails)
                    .HasForeignKey(d => d.VitalSignTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_VitalSignDetails_vitalSignTypeId");
            });

            modelBuilder.Entity<VitalSignRelationships>(entity =>
            {
                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.VitalSignRelationships)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_VitalSignRelationship_patientId");

                entity.HasOne(d => d.Threshold)
                    .WithMany(p => p.VitalSignRelationships)
                    .HasForeignKey(d => d.ThresholdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_VitalSignRelationship_thresholdId");

                entity.HasOne(d => d.VitalSignType)
                    .WithMany(p => p.VitalSignRelationships)
                    .HasForeignKey(d => d.VitalSignTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_VitalSignRelationship_vitalSignTypeId");
            });

            modelBuilder.Entity<VitalSignTypeThreshold>(entity =>
            {
                entity.HasIndex(e => e.VitalSignTypeIdFk)
                    .HasName("IX_VitalSignTypeThreshold")
                    .IsUnique();

                entity.Property(e => e.VitalSignTypeIdFk).ValueGeneratedNever();

                entity.HasOne(d => d.VitalSignTypeIdFkNavigation)
                    .WithOne(p => p.VitalSignTypeThreshold)
                    .HasForeignKey<VitalSignTypeThreshold>(d => d.VitalSignTypeIdFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VitalSignTypeThreshold_VitalSignTypes");
            });

            modelBuilder.Entity<VitalSignTypes>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("idx_VitalSignTypes1");
            });

            modelBuilder.Entity<VitalSigns>(entity =>
            {
                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.VitalSigns)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_VitalSigns_patientId");
            });

            modelBuilder.Entity<VwAssessmentDue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AssessmentDue");
            });

            modelBuilder.Entity<VwCarePlanSetup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_CarePlanSetup");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<VwCarePlanSystemDisease>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_CarePlanSystemDisease");
            });

            modelBuilder.Entity<VwDoctors>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Doctors");
            });

            modelBuilder.Entity<VwFalangaScores>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_FalangaScores");

                entity.Property(e => e.BlackEschar).IsUnicode(false);

                entity.Property(e => e.GreatestWoundDepth).IsUnicode(false);

                entity.Property(e => e.PatientwoundvisitId).ValueGeneratedOnAdd();

                entity.Property(e => e.PinkWoundBed).IsUnicode(false);
            });

            modelBuilder.Entity<VwPatientAllLatestVitalSigns>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PatientAllLatestVitalSigns");
            });

            modelBuilder.Entity<VwPatientBilling>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PatientBilling");
            });

            modelBuilder.Entity<VwPatientDisease>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PatientDisease");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<VwPatientLatestVitalSigns>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PatientLatestVitalSigns");
            });

            modelBuilder.Entity<VwPatientWoundImageDownload>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PatientWoundImageDownload");

                entity.Property(e => e.ImageDate).IsUnicode(false);

                entity.Property(e => e.ImageUpload).IsUnicode(false);
            });

            modelBuilder.Entity<VwPushScores>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_PushScores");

                entity.Property(e => e.PatientWoundVisitId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwTeleconsultation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Teleconsultation");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
