using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_Patient")]
    public partial class AuditPatient
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
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
    }
}
