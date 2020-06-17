using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class Code
    {
        public Code()
        {
            BillingInvoice = new HashSet<BillingInvoice>();
            BillingProposal = new HashSet<BillingProposal>();
            BillingService = new HashSet<BillingService>();
            Branch = new HashSet<Branch>();
            CarePlanSubProblemListGoalOperator = new HashSet<CarePlanSubProblemListGoal>();
            CarePlanSubProblemListGoalScoreType = new HashSet<CarePlanSubProblemListGoal>();
            CareReportAirwayBreathingIdFkNavigation = new HashSet<CareReport>();
            CareReportBladderCareIdFkNavigation = new HashSet<CareReport>();
            CareReportBowelCareIdFkNavigation = new HashSet<CareReport>();
            CareReportCapillaryRefillIdFkNavigation = new HashSet<CareReport>();
            CareReportCirculationIdFkNavigation = new HashSet<CareReport>();
            CareReportCoughIdFkNavigation = new HashSet<CareReport>();
            CareReportDiapersIdFkNavigation = new HashSet<CareReport>();
            CareReportLipsIdFkNavigation = new HashSet<CareReport>();
            CareReportLowerEyelidsIdFkNavigation = new HashSet<CareReport>();
            CareReportO2aidIdFkNavigation = new HashSet<CareReport>();
            CareReportPainDescriptionIdFkNavigation = new HashSet<CareReport>();
            CareReportPeripheralPulsesPedalIdFkNavigation = new HashSet<CareReport>();
            CareReportPeripheralPulsesRadialIdFkNavigation = new HashSet<CareReport>();
            CareReportSleepRestIdFkNavigation = new HashSet<CareReport>();
            CareReportTemperatureIdFkNavigation = new HashSet<CareReport>();
            EnquiryCaregiverAtHomeIdFkNavigation = new HashSet<Enquiry>();
            EnquiryEnquirySourceIdFkNavigation = new HashSet<Enquiry>();
            EnquiryGenderIdFkNavigation = new HashSet<Enquiry>();
            EnquiryLanguage = new HashSet<EnquiryLanguage>();
            EnquiryPreferredLanguageIdFkNavigation = new HashSet<Enquiry>();
            EnquiryRaceIdFkNavigation = new HashSet<Enquiry>();
            EnquiryServicesRequired = new HashSet<EnquiryServicesRequired>();
            EnquiryServicesRequiredIdFkNavigation = new HashSet<Enquiry>();
            EnquiryUserOrganizationIdFkNavigation = new HashSet<Enquiry>();
            EventEventTypeIdFkNavigation = new HashSet<Event>();
            EventPeriodTypeIdFkNavigation = new HashSet<Event>();
            IcawoundCare = new HashSet<IcawoundCare>();
            InverseMedicationGroupIdFkNavigation = new HashSet<Code>();
            ItemCategoryIdFkNavigation = new HashSet<Item>();
            ItemItemUnitIdFkNavigation = new HashSet<Item>();
            MedicationVitalSignType = new HashSet<MedicationVitalSignType>();
            NutritionTask = new HashSet<NutritionTask>();
            NutritionTaskReference = new HashSet<NutritionTaskReference>();
            PatientBloodTypeIdFkNavigation = new HashSet<Patient>();
            PatientDrugAllergyMedicationIdFkNavigation = new HashSet<PatientDrugAllergy>();
            PatientDrugAllergyReactionIdFkNavigation = new HashSet<PatientDrugAllergy>();
            PatientGenderIdFkNavigation = new HashSet<Patient>();
            PatientInvoiceModeIdFkNavigation = new HashSet<Patient>();
            PatientLanguage = new HashSet<PatientLanguage>();
            PatientMaritalStatusIdFkNavigation = new HashSet<Patient>();
            PatientMedicalHistory = new HashSet<PatientMedicalHistory>();
            PatientMedicationConsumeAcutePrnindicationIdFkNavigation = new HashSet<PatientMedicationConsume>();
            PatientMedicationConsumeDosageIdFkNavigation = new HashSet<PatientMedicationConsume>();
            PatientMedicationConsumeFrequencyIdFkNavigation = new HashSet<PatientMedicationConsume>();
            PatientMedicationConsumeInstructedBy2IdFkNavigation = new HashSet<PatientMedicationConsume>();
            PatientMedicationConsumeInstructedByIdFkNavigation = new HashSet<PatientMedicationConsume>();
            PatientMedicationConsumeMedicationIdFkNavigation = new HashSet<PatientMedicationConsume>();
            PatientMedicationConsumeRouteIdFkNavigation = new HashSet<PatientMedicationConsume>();
            PatientMedicationSupply = new HashSet<PatientMedicationSupply>();
            PatientOtherAllergyDescriptionIdFkNavigation = new HashSet<PatientOtherAllergy>();
            PatientOtherAllergyReactionIdFkNavigation = new HashSet<PatientOtherAllergy>();
            PatientPatientReferralByIdFkNavigation = new HashSet<Patient>();
            PatientPatientTypeIdFkNavigation = new HashSet<Patient>();
            PatientProfileBloodTypeIdFkNavigation = new HashSet<PatientProfile>();
            PatientProfileReligionIdFkNavigation = new HashSet<PatientProfile>();
            PatientRaceIdFkNavigation = new HashSet<Patient>();
            PatientReferralService = new HashSet<PatientReferralService>();
            PatientReligionIdFkNavigation = new HashSet<Patient>();
            PatientResidentTypeIdFkNavigation = new HashSet<Patient>();
            PatientSocialSupportGenderIdFkNavigation = new HashSet<PatientSocialSupport>();
            PatientSocialSupportMaritalStatusIdFkNavigation = new HashSet<PatientSocialSupport>();
            PatientSocialSupportNationalityIdFkNavigation = new HashSet<PatientSocialSupport>();
            PatientSocialSupportRelationshipIdFkNavigation = new HashSet<PatientSocialSupport>();
            PatientSpecialIndicator = new HashSet<PatientSpecialIndicator>();
            PatientWound = new HashSet<PatientWound>();
            PatientWoundVisitAppearance = new HashSet<PatientWoundVisitAppearance>();
            PatientWoundVisitCleansingItem = new HashSet<PatientWoundVisitCleansingItem>();
            PatientWoundVisitTreatmentObjectives = new HashSet<PatientWoundVisitTreatmentObjectives>();
            ProblemListGoalOperator = new HashSet<ProblemListGoal>();
            ProblemListGoalScoreType = new HashSet<ProblemListGoal>();
            ReceiptCurrencyIdFkNavigation = new HashSet<Receipt>();
            ReceiptPaymentModeIdFkNavigation = new HashSet<Receipt>();
            Resource = new HashSet<Resource>();
            ServiceForBilling = new HashSet<ServiceForBilling>();
            ServiceForBillingCost = new HashSet<ServiceForBillingCost>();
            ServiceSkillsetServiceIdFkNavigation = new HashSet<ServiceSkillset>();
            ServiceSkillsetSkillsetIdFkNavigation = new HashSet<ServiceSkillset>();
            TaskActionTypeIdFkNavigation = new HashSet<Task>();
            TaskDosageIdFkNavigation = new HashSet<Task>();
            TaskFrequencyIdFkNavigation = new HashSet<Task>();
            TaskMedicationIdFkNavigation = new HashSet<Task>();
            TaskServicesRequired = new HashSet<TaskServicesRequired>();
            TdWoundAssessmentFactor = new HashSet<TdWoundAssessmentFactor>();
            TeleconsultationRecording = new HashSet<TeleconsultationRecording>();
            TreatmentListItem = new HashSet<TreatmentListItem>();
            UserLanguage = new HashSet<UserLanguage>();
            UserOrganization = new HashSet<UserOrganization>();
            UserSkillset = new HashSet<UserSkillset>();
        }

        [Key]
        public int CodeId { get; set; }
        [Column("CodeTypeId_FK")]
        public int CodeTypeIdFk { get; set; }
        [Required]
        [StringLength(255)]
        public string CodeName { get; set; }
        public int? Ordering { get; set; }
        public bool IsSystemUsed { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        [Column("Indication_Acute")]
        public bool? IndicationAcute { get; set; }
        [Column("Indication_PRN")]
        public bool? IndicationPrn { get; set; }
        [Column("Referral_Code")]
        [StringLength(3)]
        public string ReferralCode { get; set; }
        [Column("AllergyReaction_Drug")]
        public bool? AllergyReactionDrug { get; set; }
        [Column("AllergyReaction_Others")]
        public bool? AllergyReactionOthers { get; set; }
        [Column("MedicationGroupID_FK")]
        public int? MedicationGroupIdFk { get; set; }
        [StringLength(15)]
        public string Status { get; set; }
        [StringLength(3)]
        public string CurrencyCodeA { get; set; }
        [StringLength(3)]
        public string CurrencyCodeN { get; set; }
        public string CurrencyInvoiceFooter { get; set; }
        public bool? Critical { get; set; }

        [ForeignKey(nameof(CodeTypeIdFk))]
        [InverseProperty(nameof(CodeType.Code))]
        public virtual CodeType CodeTypeIdFkNavigation { get; set; }
        [ForeignKey(nameof(MedicationGroupIdFk))]
        [InverseProperty(nameof(Code.InverseMedicationGroupIdFkNavigation))]
        public virtual Code MedicationGroupIdFkNavigation { get; set; }
        [InverseProperty("CurrencyIdFkNavigation")]
        public virtual ICollection<BillingInvoice> BillingInvoice { get; set; }
        [InverseProperty("CurrencyIdFkNavigation")]
        public virtual ICollection<BillingProposal> BillingProposal { get; set; }
        [InverseProperty("CategoryIdFkNavigation")]
        public virtual ICollection<BillingService> BillingService { get; set; }
        [InverseProperty("CurrencyIdFkNavigation")]
        public virtual ICollection<Branch> Branch { get; set; }
        [InverseProperty(nameof(CarePlanSubProblemListGoal.Operator))]
        public virtual ICollection<CarePlanSubProblemListGoal> CarePlanSubProblemListGoalOperator { get; set; }
        [InverseProperty(nameof(CarePlanSubProblemListGoal.ScoreType))]
        public virtual ICollection<CarePlanSubProblemListGoal> CarePlanSubProblemListGoalScoreType { get; set; }
        [InverseProperty(nameof(CareReport.AirwayBreathingIdFkNavigation))]
        public virtual ICollection<CareReport> CareReportAirwayBreathingIdFkNavigation { get; set; }
        [InverseProperty(nameof(CareReport.BladderCareIdFkNavigation))]
        public virtual ICollection<CareReport> CareReportBladderCareIdFkNavigation { get; set; }
        [InverseProperty(nameof(CareReport.BowelCareIdFkNavigation))]
        public virtual ICollection<CareReport> CareReportBowelCareIdFkNavigation { get; set; }
        [InverseProperty(nameof(CareReport.CapillaryRefillIdFkNavigation))]
        public virtual ICollection<CareReport> CareReportCapillaryRefillIdFkNavigation { get; set; }
        [InverseProperty(nameof(CareReport.CirculationIdFkNavigation))]
        public virtual ICollection<CareReport> CareReportCirculationIdFkNavigation { get; set; }
        [InverseProperty(nameof(CareReport.CoughIdFkNavigation))]
        public virtual ICollection<CareReport> CareReportCoughIdFkNavigation { get; set; }
        [InverseProperty(nameof(CareReport.DiapersIdFkNavigation))]
        public virtual ICollection<CareReport> CareReportDiapersIdFkNavigation { get; set; }
        [InverseProperty(nameof(CareReport.LipsIdFkNavigation))]
        public virtual ICollection<CareReport> CareReportLipsIdFkNavigation { get; set; }
        [InverseProperty(nameof(CareReport.LowerEyelidsIdFkNavigation))]
        public virtual ICollection<CareReport> CareReportLowerEyelidsIdFkNavigation { get; set; }
        [InverseProperty(nameof(CareReport.O2aidIdFkNavigation))]
        public virtual ICollection<CareReport> CareReportO2aidIdFkNavigation { get; set; }
        [InverseProperty(nameof(CareReport.PainDescriptionIdFkNavigation))]
        public virtual ICollection<CareReport> CareReportPainDescriptionIdFkNavigation { get; set; }
        [InverseProperty(nameof(CareReport.PeripheralPulsesPedalIdFkNavigation))]
        public virtual ICollection<CareReport> CareReportPeripheralPulsesPedalIdFkNavigation { get; set; }
        [InverseProperty(nameof(CareReport.PeripheralPulsesRadialIdFkNavigation))]
        public virtual ICollection<CareReport> CareReportPeripheralPulsesRadialIdFkNavigation { get; set; }
        [InverseProperty(nameof(CareReport.SleepRestIdFkNavigation))]
        public virtual ICollection<CareReport> CareReportSleepRestIdFkNavigation { get; set; }
        [InverseProperty(nameof(CareReport.TemperatureIdFkNavigation))]
        public virtual ICollection<CareReport> CareReportTemperatureIdFkNavigation { get; set; }
        [InverseProperty(nameof(Enquiry.CaregiverAtHomeIdFkNavigation))]
        public virtual ICollection<Enquiry> EnquiryCaregiverAtHomeIdFkNavigation { get; set; }
        [InverseProperty(nameof(Enquiry.EnquirySourceIdFkNavigation))]
        public virtual ICollection<Enquiry> EnquiryEnquirySourceIdFkNavigation { get; set; }
        [InverseProperty(nameof(Enquiry.GenderIdFkNavigation))]
        public virtual ICollection<Enquiry> EnquiryGenderIdFkNavigation { get; set; }
        [InverseProperty("CodeIdFkNavigation")]
        public virtual ICollection<EnquiryLanguage> EnquiryLanguage { get; set; }
        [InverseProperty(nameof(Enquiry.PreferredLanguageIdFkNavigation))]
        public virtual ICollection<Enquiry> EnquiryPreferredLanguageIdFkNavigation { get; set; }
        [InverseProperty(nameof(Enquiry.RaceIdFkNavigation))]
        public virtual ICollection<Enquiry> EnquiryRaceIdFkNavigation { get; set; }
        [InverseProperty("CodeIdFkNavigation")]
        public virtual ICollection<EnquiryServicesRequired> EnquiryServicesRequired { get; set; }
        [InverseProperty(nameof(Enquiry.ServicesRequiredIdFkNavigation))]
        public virtual ICollection<Enquiry> EnquiryServicesRequiredIdFkNavigation { get; set; }
        [InverseProperty(nameof(Enquiry.UserOrganizationIdFkNavigation))]
        public virtual ICollection<Enquiry> EnquiryUserOrganizationIdFkNavigation { get; set; }
        [InverseProperty(nameof(Event.EventTypeIdFkNavigation))]
        public virtual ICollection<Event> EventEventTypeIdFkNavigation { get; set; }
        [InverseProperty(nameof(Event.PeriodTypeIdFkNavigation))]
        public virtual ICollection<Event> EventPeriodTypeIdFkNavigation { get; set; }
        [InverseProperty("CodeIdFkNavigation")]
        public virtual ICollection<IcawoundCare> IcawoundCare { get; set; }
        [InverseProperty(nameof(Code.MedicationGroupIdFkNavigation))]
        public virtual ICollection<Code> InverseMedicationGroupIdFkNavigation { get; set; }
        [InverseProperty(nameof(Item.CategoryIdFkNavigation))]
        public virtual ICollection<Item> ItemCategoryIdFkNavigation { get; set; }
        [InverseProperty(nameof(Item.ItemUnitIdFkNavigation))]
        public virtual ICollection<Item> ItemItemUnitIdFkNavigation { get; set; }
        [InverseProperty("MedicationIdFkNavigation")]
        public virtual ICollection<MedicationVitalSignType> MedicationVitalSignType { get; set; }
        [InverseProperty("ActionTypeIdFkNavigation")]
        public virtual ICollection<NutritionTask> NutritionTask { get; set; }
        [InverseProperty("CodeIdFkNavigation")]
        public virtual ICollection<NutritionTaskReference> NutritionTaskReference { get; set; }
        [InverseProperty(nameof(Patient.BloodTypeIdFkNavigation))]
        public virtual ICollection<Patient> PatientBloodTypeIdFkNavigation { get; set; }
        [InverseProperty(nameof(PatientDrugAllergy.MedicationIdFkNavigation))]
        public virtual ICollection<PatientDrugAllergy> PatientDrugAllergyMedicationIdFkNavigation { get; set; }
        [InverseProperty(nameof(PatientDrugAllergy.ReactionIdFkNavigation))]
        public virtual ICollection<PatientDrugAllergy> PatientDrugAllergyReactionIdFkNavigation { get; set; }
        [InverseProperty(nameof(Patient.GenderIdFkNavigation))]
        public virtual ICollection<Patient> PatientGenderIdFkNavigation { get; set; }
        [InverseProperty(nameof(Patient.InvoiceModeIdFkNavigation))]
        public virtual ICollection<Patient> PatientInvoiceModeIdFkNavigation { get; set; }
        [InverseProperty("CodeIdFkNavigation")]
        public virtual ICollection<PatientLanguage> PatientLanguage { get; set; }
        [InverseProperty(nameof(Patient.MaritalStatusIdFkNavigation))]
        public virtual ICollection<Patient> PatientMaritalStatusIdFkNavigation { get; set; }
        [InverseProperty("MedicalStatusIdFkNavigation")]
        public virtual ICollection<PatientMedicalHistory> PatientMedicalHistory { get; set; }
        [InverseProperty(nameof(PatientMedicationConsume.AcutePrnindicationIdFkNavigation))]
        public virtual ICollection<PatientMedicationConsume> PatientMedicationConsumeAcutePrnindicationIdFkNavigation { get; set; }
        [InverseProperty(nameof(PatientMedicationConsume.DosageIdFkNavigation))]
        public virtual ICollection<PatientMedicationConsume> PatientMedicationConsumeDosageIdFkNavigation { get; set; }
        [InverseProperty(nameof(PatientMedicationConsume.FrequencyIdFkNavigation))]
        public virtual ICollection<PatientMedicationConsume> PatientMedicationConsumeFrequencyIdFkNavigation { get; set; }
        [InverseProperty(nameof(PatientMedicationConsume.InstructedBy2IdFkNavigation))]
        public virtual ICollection<PatientMedicationConsume> PatientMedicationConsumeInstructedBy2IdFkNavigation { get; set; }
        [InverseProperty(nameof(PatientMedicationConsume.InstructedByIdFkNavigation))]
        public virtual ICollection<PatientMedicationConsume> PatientMedicationConsumeInstructedByIdFkNavigation { get; set; }
        [InverseProperty(nameof(PatientMedicationConsume.MedicationIdFkNavigation))]
        public virtual ICollection<PatientMedicationConsume> PatientMedicationConsumeMedicationIdFkNavigation { get; set; }
        [InverseProperty(nameof(PatientMedicationConsume.RouteIdFkNavigation))]
        public virtual ICollection<PatientMedicationConsume> PatientMedicationConsumeRouteIdFkNavigation { get; set; }
        [InverseProperty("SupplyIdFkNavigation")]
        public virtual ICollection<PatientMedicationSupply> PatientMedicationSupply { get; set; }
        [InverseProperty(nameof(PatientOtherAllergy.DescriptionIdFkNavigation))]
        public virtual ICollection<PatientOtherAllergy> PatientOtherAllergyDescriptionIdFkNavigation { get; set; }
        [InverseProperty(nameof(PatientOtherAllergy.ReactionIdFkNavigation))]
        public virtual ICollection<PatientOtherAllergy> PatientOtherAllergyReactionIdFkNavigation { get; set; }
        [InverseProperty(nameof(Patient.PatientReferralByIdFkNavigation))]
        public virtual ICollection<Patient> PatientPatientReferralByIdFkNavigation { get; set; }
        [InverseProperty(nameof(Patient.PatientTypeIdFkNavigation))]
        public virtual ICollection<Patient> PatientPatientTypeIdFkNavigation { get; set; }
        [InverseProperty(nameof(PatientProfile.BloodTypeIdFkNavigation))]
        public virtual ICollection<PatientProfile> PatientProfileBloodTypeIdFkNavigation { get; set; }
        [InverseProperty(nameof(PatientProfile.ReligionIdFkNavigation))]
        public virtual ICollection<PatientProfile> PatientProfileReligionIdFkNavigation { get; set; }
        [InverseProperty(nameof(Patient.RaceIdFkNavigation))]
        public virtual ICollection<Patient> PatientRaceIdFkNavigation { get; set; }
        [InverseProperty("ServiceIdFkNavigation")]
        public virtual ICollection<PatientReferralService> PatientReferralService { get; set; }
        [InverseProperty(nameof(Patient.ReligionIdFkNavigation))]
        public virtual ICollection<Patient> PatientReligionIdFkNavigation { get; set; }
        [InverseProperty(nameof(Patient.ResidentTypeIdFkNavigation))]
        public virtual ICollection<Patient> PatientResidentTypeIdFkNavigation { get; set; }
        [InverseProperty(nameof(PatientSocialSupport.GenderIdFkNavigation))]
        public virtual ICollection<PatientSocialSupport> PatientSocialSupportGenderIdFkNavigation { get; set; }
        [InverseProperty(nameof(PatientSocialSupport.MaritalStatusIdFkNavigation))]
        public virtual ICollection<PatientSocialSupport> PatientSocialSupportMaritalStatusIdFkNavigation { get; set; }
        [InverseProperty(nameof(PatientSocialSupport.NationalityIdFkNavigation))]
        public virtual ICollection<PatientSocialSupport> PatientSocialSupportNationalityIdFkNavigation { get; set; }
        [InverseProperty(nameof(PatientSocialSupport.RelationshipIdFkNavigation))]
        public virtual ICollection<PatientSocialSupport> PatientSocialSupportRelationshipIdFkNavigation { get; set; }
        [InverseProperty("CodeIdFkNavigation")]
        public virtual ICollection<PatientSpecialIndicator> PatientSpecialIndicator { get; set; }
        [InverseProperty("WoundStatusIdFkNavigation")]
        public virtual ICollection<PatientWound> PatientWound { get; set; }
        [InverseProperty("CodeIdFkNavigation")]
        public virtual ICollection<PatientWoundVisitAppearance> PatientWoundVisitAppearance { get; set; }
        [InverseProperty("CodeIdFkNavigation")]
        public virtual ICollection<PatientWoundVisitCleansingItem> PatientWoundVisitCleansingItem { get; set; }
        [InverseProperty("ObjectiveIdFkNavigation")]
        public virtual ICollection<PatientWoundVisitTreatmentObjectives> PatientWoundVisitTreatmentObjectives { get; set; }
        [InverseProperty(nameof(ProblemListGoal.Operator))]
        public virtual ICollection<ProblemListGoal> ProblemListGoalOperator { get; set; }
        [InverseProperty(nameof(ProblemListGoal.ScoreType))]
        public virtual ICollection<ProblemListGoal> ProblemListGoalScoreType { get; set; }
        [InverseProperty(nameof(Receipt.CurrencyIdFkNavigation))]
        public virtual ICollection<Receipt> ReceiptCurrencyIdFkNavigation { get; set; }
        [InverseProperty(nameof(Receipt.PaymentModeIdFkNavigation))]
        public virtual ICollection<Receipt> ReceiptPaymentModeIdFkNavigation { get; set; }
        [InverseProperty("Code")]
        public virtual ICollection<Resource> Resource { get; set; }
        [InverseProperty("CategoryIdFkNavigation")]
        public virtual ICollection<ServiceForBilling> ServiceForBilling { get; set; }
        [InverseProperty("CurrencyIdFkNavigation")]
        public virtual ICollection<ServiceForBillingCost> ServiceForBillingCost { get; set; }
        [InverseProperty(nameof(ServiceSkillset.ServiceIdFkNavigation))]
        public virtual ICollection<ServiceSkillset> ServiceSkillsetServiceIdFkNavigation { get; set; }
        [InverseProperty(nameof(ServiceSkillset.SkillsetIdFkNavigation))]
        public virtual ICollection<ServiceSkillset> ServiceSkillsetSkillsetIdFkNavigation { get; set; }
        [InverseProperty(nameof(Task.ActionTypeIdFkNavigation))]
        public virtual ICollection<Task> TaskActionTypeIdFkNavigation { get; set; }
        [InverseProperty(nameof(Task.DosageIdFkNavigation))]
        public virtual ICollection<Task> TaskDosageIdFkNavigation { get; set; }
        [InverseProperty(nameof(Task.FrequencyIdFkNavigation))]
        public virtual ICollection<Task> TaskFrequencyIdFkNavigation { get; set; }
        [InverseProperty(nameof(Task.MedicationIdFkNavigation))]
        public virtual ICollection<Task> TaskMedicationIdFkNavigation { get; set; }
        [InverseProperty("CodeIdFkNavigation")]
        public virtual ICollection<TaskServicesRequired> TaskServicesRequired { get; set; }
        [InverseProperty("CodeIdFkNavigation")]
        public virtual ICollection<TdWoundAssessmentFactor> TdWoundAssessmentFactor { get; set; }
        [InverseProperty("RecordingTypeFkNavigation")]
        public virtual ICollection<TeleconsultationRecording> TeleconsultationRecording { get; set; }
        [InverseProperty("TlistTypeIdFkNavigation")]
        public virtual ICollection<TreatmentListItem> TreatmentListItem { get; set; }
        [InverseProperty("LanguageIdFkNavigation")]
        public virtual ICollection<UserLanguage> UserLanguage { get; set; }
        [InverseProperty("CodeIdFkNavigation")]
        public virtual ICollection<UserOrganization> UserOrganization { get; set; }
        [InverseProperty("CodeIdFkNavigation")]
        public virtual ICollection<UserSkillset> UserSkillset { get; set; }
    }
}
