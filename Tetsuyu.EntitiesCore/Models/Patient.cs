using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class Patient
    {
        public Patient()
        {
            BillingInvoice = new HashSet<BillingInvoice>();
            BillingProposal = new HashSet<BillingProposal>();
            CarePlan = new HashSet<CarePlan>();
            CareReport = new HashSet<CareReport>();
            Chat = new HashSet<Chat>();
            MultiDisciplinaryMeeting = new HashSet<MultiDisciplinaryMeeting>();
            NutritionTask = new HashSet<NutritionTask>();
            PatientAmt = new HashSet<PatientAmt>();
            PatientAttachment = new HashSet<PatientAttachment>();
            PatientClinician = new HashSet<PatientClinician>();
            PatientDrugAllergy = new HashSet<PatientDrugAllergy>();
            PatientEbasdep = new HashSet<PatientEbasdep>();
            PatientFamilyHistory = new HashSet<PatientFamilyHistory>();
            PatientImmunisation = new HashSet<PatientImmunisation>();
            PatientLanguage = new HashSet<PatientLanguage>();
            PatientMedicalHistory = new HashSet<PatientMedicalHistory>();
            PatientOtherAllergy = new HashSet<PatientOtherAllergy>();
            PatientPackage = new HashSet<PatientPackage>();
            PatientSocialSupport = new HashSet<PatientSocialSupport>();
            PatientSpecialIndicator = new HashSet<PatientSpecialIndicator>();
            PatientWound = new HashSet<PatientWound>();
            Receipt = new HashSet<Receipt>();
            RecentView = new HashSet<RecentView>();
            Task = new HashSet<Task>();
            TeleconsultationRecording = new HashSet<TeleconsultationRecording>();
            Users = new HashSet<Users>();
            VitalSignRelationships = new HashSet<VitalSignRelationships>();
            VitalSigns = new HashSet<VitalSigns>();
        }

        [Key]
        [Column("PatientID")]
        public int PatientId { get; set; }
        [Required]
        [StringLength(50)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }
        [Required]
        [Column("NRIC")]
        [StringLength(20)]
        public string Nric { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateOfBirth { get; set; }
        public int? Age { get; set; }
        [StringLength(10)]
        public string PostalCode { get; set; }
        [StringLength(50)]
        public string Photo { get; set; }
        [Column("CareManagerAssignedID")]
        public int? CareManagerAssignedId { get; set; }
        [Column("CaseID")]
        [StringLength(50)]
        public string CaseId { get; set; }
        [StringLength(500)]
        public string DrugAllergy { get; set; }
        [StringLength(15)]
        public string Status { get; set; }
        public int? DischargeNoticePeriodInMonths { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AdmittedDate { get; set; }
        [StringLength(500)]
        public string ReasonOfAdmission { get; set; }
        [Column("AMD")]
        public bool? Amd { get; set; }
        [Column("ACP")]
        public bool? Acp { get; set; }
        [Column("PACEMAKER")]
        public bool? Pacemaker { get; set; }
        [Column("ACID")]
        public bool? Acid { get; set; }
        [StringLength(100)]
        public string MobilePhone { get; set; }
        [StringLength(100)]
        public string HomePhone { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(50)]
        public string GenogramPicture { get; set; }
        [StringLength(500)]
        public string ReferringDiagnosis { get; set; }
        [StringLength(50)]
        public string MailForVitalAlert1 { get; set; }
        [StringLength(50)]
        public string MailForVitalAlert2 { get; set; }
        [StringLength(50)]
        public string MailForVitalAlert3 { get; set; }
        [StringLength(50)]
        public string MailForFamilyNotification1 { get; set; }
        [StringLength(50)]
        public string MailForFamilyNotification2 { get; set; }
        [StringLength(500)]
        public string VisitingFrequency { get; set; }
        public int? NumberOfChildren { get; set; }
        [StringLength(500)]
        public string Occupation { get; set; }
        public bool? UpfrontPayment { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CareReviewDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        [Column("PatientTypeID_FK")]
        public int? PatientTypeIdFk { get; set; }
        [StringLength(255)]
        public string MailingAddress1 { get; set; }
        [StringLength(255)]
        public string MailingAddress2 { get; set; }
        [StringLength(255)]
        public string MailingAddress3 { get; set; }
        [Column("GenderID_FK")]
        public int? GenderIdFk { get; set; }
        [Column("BloodTypeID_FK")]
        public int? BloodTypeIdFk { get; set; }
        [Column("ResidentTypeID_FK")]
        public int? ResidentTypeIdFk { get; set; }
        [Column("MaritalStatusID_FK")]
        public int? MaritalStatusIdFk { get; set; }
        [Column("ReligionID_FK")]
        public int? ReligionIdFk { get; set; }
        [Column("PatientProfileID_FK")]
        public int? PatientProfileIdFk { get; set; }
        [Column("RaceID_FK")]
        public int? RaceIdFk { get; set; }
        [Column("PatientAdditionalInfoID_FK")]
        public int? PatientAdditionalInfoIdFk { get; set; }
        [Column("PatientReferralID_FK")]
        public int? PatientReferralIdFk { get; set; }
        public string MedicalHistoryRemarks { get; set; }
        [Column("PatientMedicationID_FK")]
        public int? PatientMedicationIdFk { get; set; }
        [Column("PatientReferralByID_FK")]
        public int? PatientReferralByIdFk { get; set; }
        [StringLength(255)]
        public string IdentificationNumber { get; set; }
        [StringLength(255)]
        public string IdentificationAttachmentFilename { get; set; }
        [StringLength(50)]
        public string IdentificationAttachmentPhysical { get; set; }
        [StringLength(255)]
        public string OtherRace { get; set; }
        [StringLength(255)]
        public string OtherLanguage { get; set; }
        [StringLength(10)]
        public string PaymentMode { get; set; }
        [Column("InvoiceModeID_FK")]
        public int? InvoiceModeIdFk { get; set; }
        [StringLength(255)]
        public string DisplayName { get; set; }
        [Column("OrderID")]
        [StringLength(60)]
        public string OrderId { get; set; }
        public bool? Accepted { get; set; }
        [StringLength(255)]
        public string NursingStation { get; set; }

        [ForeignKey(nameof(BloodTypeIdFk))]
        [InverseProperty(nameof(Code.PatientBloodTypeIdFkNavigation))]
        public virtual Code BloodTypeIdFkNavigation { get; set; }
        [ForeignKey(nameof(GenderIdFk))]
        [InverseProperty(nameof(Code.PatientGenderIdFkNavigation))]
        public virtual Code GenderIdFkNavigation { get; set; }
        [ForeignKey(nameof(InvoiceModeIdFk))]
        [InverseProperty(nameof(Code.PatientInvoiceModeIdFkNavigation))]
        public virtual Code InvoiceModeIdFkNavigation { get; set; }
        [ForeignKey(nameof(MaritalStatusIdFk))]
        [InverseProperty(nameof(Code.PatientMaritalStatusIdFkNavigation))]
        public virtual Code MaritalStatusIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientAdditionalInfoIdFk))]
        [InverseProperty(nameof(PatientAdditionalInfo.Patient))]
        public virtual PatientAdditionalInfo PatientAdditionalInfoIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientMedicationIdFk))]
        [InverseProperty(nameof(PatientMedication.Patient))]
        public virtual PatientMedication PatientMedicationIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientProfileIdFk))]
        [InverseProperty(nameof(PatientProfile.Patient))]
        public virtual PatientProfile PatientProfileIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientReferralByIdFk))]
        [InverseProperty(nameof(Code.PatientPatientReferralByIdFkNavigation))]
        public virtual Code PatientReferralByIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientReferralIdFk))]
        [InverseProperty(nameof(PatientReferral.Patient))]
        public virtual PatientReferral PatientReferralIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientTypeIdFk))]
        [InverseProperty(nameof(Code.PatientPatientTypeIdFkNavigation))]
        public virtual Code PatientTypeIdFkNavigation { get; set; }
        [ForeignKey(nameof(RaceIdFk))]
        [InverseProperty(nameof(Code.PatientRaceIdFkNavigation))]
        public virtual Code RaceIdFkNavigation { get; set; }
        [ForeignKey(nameof(ReligionIdFk))]
        [InverseProperty(nameof(Code.PatientReligionIdFkNavigation))]
        public virtual Code ReligionIdFkNavigation { get; set; }
        [ForeignKey(nameof(ResidentTypeIdFk))]
        [InverseProperty(nameof(Code.PatientResidentTypeIdFkNavigation))]
        public virtual Code ResidentTypeIdFkNavigation { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<BillingInvoice> BillingInvoice { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<BillingProposal> BillingProposal { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<CarePlan> CarePlan { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<CareReport> CareReport { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<Chat> Chat { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<MultiDisciplinaryMeeting> MultiDisciplinaryMeeting { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<NutritionTask> NutritionTask { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<PatientAmt> PatientAmt { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<PatientAttachment> PatientAttachment { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<PatientClinician> PatientClinician { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<PatientDrugAllergy> PatientDrugAllergy { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<PatientEbasdep> PatientEbasdep { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<PatientFamilyHistory> PatientFamilyHistory { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<PatientImmunisation> PatientImmunisation { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<PatientLanguage> PatientLanguage { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<PatientMedicalHistory> PatientMedicalHistory { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<PatientOtherAllergy> PatientOtherAllergy { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<PatientPackage> PatientPackage { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<PatientSocialSupport> PatientSocialSupport { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<PatientSpecialIndicator> PatientSpecialIndicator { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<PatientWound> PatientWound { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<Receipt> Receipt { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<RecentView> RecentView { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<Task> Task { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<TeleconsultationRecording> TeleconsultationRecording { get; set; }
        [InverseProperty("PatientIdFkNavigation")]
        public virtual ICollection<Users> Users { get; set; }
        [InverseProperty("Patient")]
        public virtual ICollection<VitalSignRelationships> VitalSignRelationships { get; set; }
        [InverseProperty("Patient")]
        public virtual ICollection<VitalSigns> VitalSigns { get; set; }
    }
}
