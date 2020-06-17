using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_CareReport")]
    public partial class AuditCareReport
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("CareReportID")]
        public int CareReportId { get; set; }
        [Column("PatientID_FK")]
        public int PatientIdFk { get; set; }
        [StringLength(30)]
        public string CareReportType { get; set; }
        [Required]
        [StringLength(20)]
        public string Status { get; set; }
        [StringLength(30)]
        public string SectionStatus { get; set; }
        public string Memo1 { get; set; }
        public string Memo2 { get; set; }
        public string Memo3 { get; set; }
        public string Memo4 { get; set; }
        public string Memo5 { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        [Column("CarePlanID_FK")]
        public int? CarePlanIdFk { get; set; }
        [Column("CareReportID_FK")]
        public int? CareReportIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? VisitStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? VisitEndDate { get; set; }
        [Column("VisitedBy_FK")]
        public int? VisitedByFk { get; set; }
        [StringLength(50)]
        public string Subject { get; set; }
        [Column("VitalSignID_FK")]
        public int? VitalSignIdFk { get; set; }
        [StringLength(10)]
        public string Pain { get; set; }
        [StringLength(30)]
        public string PainScaleType { get; set; }
        public int? PainLevel { get; set; }
        [Column("PainDescriptionID_FK")]
        public int? PainDescriptionIdFk { get; set; }
        [StringLength(255)]
        public string SiteOfPain { get; set; }
        [StringLength(30)]
        public string TypeOfPain { get; set; }
        [StringLength(255)]
        public string AggravatingFactor { get; set; }
        [StringLength(255)]
        public string RelievingFactor { get; set; }
        [StringLength(30)]
        public string Frequency { get; set; }
        [StringLength(500)]
        public string PainRemarks { get; set; }
        public int? NeuroOrMental { get; set; }
        public int? Eyes { get; set; }
        public int? VerbalResponse { get; set; }
        public int? MotorResponse { get; set; }
        public int? LeftEyeSize { get; set; }
        [StringLength(30)]
        public string LeftEyeReaction { get; set; }
        public int? RightEyeSize { get; set; }
        [StringLength(30)]
        public string RightEyeReaction { get; set; }
        [StringLength(500)]
        public string NeuroRemarks { get; set; }
        [StringLength(30)]
        public string SectionRequired { get; set; }
        [StringLength(1000)]
        public string PsychoEmotionalSpiritual { get; set; }
        [StringLength(500)]
        public string PsychoRemarks { get; set; }
        [Column("AirwayBreathingID_FK")]
        public int? AirwayBreathingIdFk { get; set; }
        [Column("CoughID_FK")]
        public int? CoughIdFk { get; set; }
        [Column("O2AidID_FK")]
        public int? O2aidIdFk { get; set; }
        [Column("O2LitresPercent", TypeName = "decimal(3, 0)")]
        public decimal? O2litresPercent { get; set; }
        [Column("O2Litres", TypeName = "decimal(4, 1)")]
        public decimal? O2litres { get; set; }
        [StringLength(5)]
        public string Sunction { get; set; }
        [StringLength(30)]
        public string CoughAmount { get; set; }
        [StringLength(30)]
        public string Color { get; set; }
        [StringLength(30)]
        public string ColorOthers { get; set; }
        [StringLength(30)]
        public string Consistency { get; set; }
        [StringLength(1000)]
        public string Nebuliser { get; set; }
        [StringLength(500)]
        public string AirwayBreathingRemarks { get; set; }
        [Column("CirculationID_FK")]
        public int? CirculationIdFk { get; set; }
        [Column("LowerEyelidsID_FK")]
        public int? LowerEyelidsIdFk { get; set; }
        [Column("LipsID_FK")]
        public int? LipsIdFk { get; set; }
        [Column("CapillaryRefillID_FK")]
        public int? CapillaryRefillIdFk { get; set; }
        [Column("PeripheralPulsesRadialID_FK")]
        public int? PeripheralPulsesRadialIdFk { get; set; }
        [Column("PeripheralPulsesPedalID_FK")]
        public int? PeripheralPulsesPedalIdFk { get; set; }
        [StringLength(500)]
        public string CirculationRemarks { get; set; }
        [Column("SleepRestID_FK")]
        public int? SleepRestIdFk { get; set; }
        [StringLength(5)]
        public string DayNightReversal { get; set; }
        [StringLength(500)]
        public string SleepRestRemarks { get; set; }
        [Column("TemperatureID_FK")]
        public int? TemperatureIdFk { get; set; }
        [StringLength(100)]
        public string TemperatureInterventions { get; set; }
        [StringLength(500)]
        public string TemperatureRemarks { get; set; }
        [Column("BowelCareID_FK")]
        public int? BowelCareIdFk { get; set; }
        public int? NoOfBowelTimes { get; set; }
        public int? BowelType { get; set; }
        [Column("HowManyDaysBNO")]
        public int? HowManyDaysBno { get; set; }
        [StringLength(500)]
        public string BowelInterventions { get; set; }
        [StringLength(5)]
        public string Stoma { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StomaCreatedDate { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal? StomaSizeLength { get; set; }
        [Column(TypeName = "decimal(4, 2)")]
        public decimal? StomaSizeBreath { get; set; }
        [StringLength(20)]
        public string StomaColour { get; set; }
        [StringLength(20)]
        public string StomaAppearance { get; set; }
        [StringLength(50)]
        public string StomaProtrusion { get; set; }
        [StringLength(20)]
        public string StomaPeristomalSkin { get; set; }
        [StringLength(50)]
        public string StomaEffluent { get; set; }
        [StringLength(50)]
        public string StomaAmountOfOutput { get; set; }
        [StringLength(500)]
        public string StomaOstomyProductUsed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StomaReviewDate { get; set; }
        [StringLength(500)]
        public string BowelRemarks { get; set; }
        [Column("BladderCareID_FK")]
        public int? BladderCareIdFk { get; set; }
        public int? BladderCareTimes { get; set; }
        [Column("BladderCareNPU")]
        public int? BladderCareNpu { get; set; }
        [Column("DiapersID_FK")]
        public int? DiapersIdFk { get; set; }
        [StringLength(30)]
        public string TypeOfUrine { get; set; }
        [StringLength(500)]
        public string CharacteristicOfUrine { get; set; }
        [StringLength(5)]
        public string Dysuria { get; set; }
        [StringLength(500)]
        public string BladderCareRemarks { get; set; }
        [StringLength(500)]
        public string PersonalHygieneRemarks { get; set; }
        [Column("CareReportRehabilitationID_FK")]
        public int? CareReportRehabilitationIdFk { get; set; }
        [StringLength(500)]
        public string EnvironmentRemarks { get; set; }
        [Column("ACP")]
        public bool? Acp { get; set; }
        [Column("ACP_DoneDate", TypeName = "datetime")]
        public DateTime? AcpDoneDate { get; set; }
        [Column("ACP_ReviewDate", TypeName = "datetime")]
        public DateTime? AcpReviewDate { get; set; }
        [StringLength(2000)]
        public string OtherTreatment { get; set; }
        [StringLength(255)]
        public string OtherTreatmentOther { get; set; }
        [StringLength(500)]
        public string OtherTreatmentRemarks { get; set; }
        [Column("CareReportSystemInfoID_FK")]
        public int? CareReportSystemInfoIdFk { get; set; }
        [StringLength(30)]
        public string SectionRequireInput { get; set; }
        [Column("PatientNutritionID_FK")]
        public int? PatientNutritionIdFk { get; set; }
        [StringLength(2000)]
        public string SkinAndWoundCare { get; set; }
        [StringLength(2000)]
        public string PersonalHygiene { get; set; }
        [StringLength(2000)]
        public string Environment { get; set; }
        [StringLength(100)]
        public string BreathSounds { get; set; }
        [StringLength(100)]
        public string BowelSounds { get; set; }
        [StringLength(100)]
        public string HeartSounds { get; set; }
    }
}
