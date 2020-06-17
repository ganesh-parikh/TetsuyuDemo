using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_InitialCareAssessment")]
    public partial class AuditInitialCareAssessment
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("InitialCareAssessmentID")]
        public int InitialCareAssessmentId { get; set; }
        [Column("PatientID_FK")]
        public int? PatientIdFk { get; set; }
        [StringLength(20)]
        public string GeneralCondition { get; set; }
        [StringLength(20)]
        public string Physique { get; set; }
        [StringLength(40)]
        public string ConsciousLevel { get; set; }
        [StringLength(20)]
        public string EmotionalState { get; set; }
        [StringLength(255)]
        public string OtherEmotionalState { get; set; }
        [StringLength(20)]
        public string Breathing { get; set; }
        [StringLength(255)]
        public string OtherBreathing { get; set; }
        [Column("O2Litres", TypeName = "decimal(3, 1)")]
        public decimal? O2litres { get; set; }
        [Column("O2LitresVia")]
        [StringLength(40)]
        public string O2litresVia { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TracheostomyDateInserted { get; set; }
        [StringLength(10)]
        public string TracheostomySize { get; set; }
        [StringLength(50)]
        public string TracheostomyType { get; set; }
        public bool? IsTracheostomyInnerCannula { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TracheostomyNextReviewDate { get; set; }
        [StringLength(20)]
        public string Cough { get; set; }
        [StringLength(20)]
        public string Vision { get; set; }
        public bool? VisionImpairedLeft { get; set; }
        public bool? VisionImpairedRight { get; set; }
        [StringLength(500)]
        public string VisionImpairedRemarks { get; set; }
        public bool? VisionImpairedGlaucoma { get; set; }
        public bool? VisionImpairedCataract { get; set; }
        public bool? VisionImpairedGlaucomaLeft { get; set; }
        public bool? VisionImpairedGlaucomaRight { get; set; }
        [StringLength(500)]
        public string VisionImpairedGlaucomaRemarks { get; set; }
        public bool? VisionImpairedCataractLeft { get; set; }
        public bool? VisionImpairedCataractRight { get; set; }
        [StringLength(500)]
        public string VisionImpairedCataractRemarks { get; set; }
        [StringLength(50)]
        public string Hearing { get; set; }
        public bool? HearingImpairedLeft { get; set; }
        public bool? HearingImpairedRight { get; set; }
        [StringLength(500)]
        public string HearingImpairedRemarks { get; set; }
        public bool? HearingImpairedWithHearingAidLeft { get; set; }
        public bool? HearingImpairedWithHearingAidRight { get; set; }
        [StringLength(500)]
        public string HearingImpairedWithHearingAidRemarks { get; set; }
        [StringLength(5)]
        public string BowelHabitsTimes { get; set; }
        [StringLength(5)]
        public string BowelHabitsDays { get; set; }
        [StringLength(20)]
        public string BowelType { get; set; }
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
        [StringLength(5)]
        public string UrinaryFrequencyTimes { get; set; }
        [StringLength(5)]
        public string UrinaryFrequencyDay { get; set; }
        [StringLength(500)]
        public string UrinaryTypes { get; set; }
        [StringLength(5)]
        public string Catheter { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CatheterDateInserted { get; set; }
        [StringLength(50)]
        public string CatheterType { get; set; }
        [StringLength(10)]
        public string CatheterSize { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CatheterNextReviewDate { get; set; }
        [Column("LMP", TypeName = "datetime")]
        public DateTime? Lmp { get; set; }
        public bool? UseOfDrug { get; set; }
        [StringLength(1000)]
        public string UseOfDrugExplain { get; set; }
        [StringLength(1000)]
        public string MedicalHistory { get; set; }
        public int? OralCavityAssessmentScore1 { get; set; }
        public int? OralCavityAssessmentScore2 { get; set; }
        public int? OralCavityAssessmentScore3 { get; set; }
        public int? OralCavityAssessmentScore4 { get; set; }
        public int? OralCavityAssessmentScore5 { get; set; }
        public int? OralCavityAssessmentScore6 { get; set; }
        [StringLength(255)]
        public string MilkFeedRx { get; set; }
        public bool? EmotionalYesNo { get; set; }
        [StringLength(255)]
        public string EmotionalYes { get; set; }
        [Column("HowCanIHelp")]
        [StringLength(255)]
        public string HowCanIhelp { get; set; }
        public bool? LostInterest { get; set; }
        [StringLength(255)]
        public string LostInterestYes { get; set; }
        [StringLength(255)]
        public string HowDoYouScope { get; set; }
        public bool? DifficultyCoping { get; set; }
        [StringLength(255)]
        public string DifficultyCopingYes { get; set; }
        public bool? Depressed { get; set; }
        [StringLength(255)]
        public string GetSupport { get; set; }
        public bool? ReferCounsellor { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        [Required]
        [StringLength(20)]
        public string Status { get; set; }
        [Column("PatientProfileID_FK")]
        public int? PatientProfileIdFk { get; set; }
        [Column("PatientReferralID_FK")]
        public int? PatientReferralIdFk { get; set; }
        [StringLength(30)]
        public string SectionStatus { get; set; }
        [Column("PatientAdditionalInfoID_FK")]
        public int? PatientAdditionalInfoIdFk { get; set; }
        [Column("VitalSignID_FK")]
        public int? VitalSignIdFk { get; set; }
        public int? WoundAssessmentScore1 { get; set; }
        public int? WoundAssessmentScore2 { get; set; }
        public int? WoundAssessmentScore3 { get; set; }
        public int? WoundAssessmentScore4 { get; set; }
        public int? WoundAssessmentScore5 { get; set; }
        public int? WoundAssessmentScore6 { get; set; }
        [Column("PatientMedicationID_FK")]
        public int? PatientMedicationIdFk { get; set; }
        public bool? HomeFacilityVentilation { get; set; }
        public bool? HomeFacilityCooking { get; set; }
        public bool? HomeFacilityRefrigeration { get; set; }
        public bool? HomeFacilityToileting { get; set; }
        public bool? HomeFacilityStairs { get; set; }
        public bool? HomeFacilityCommunication { get; set; }
        public bool? HomeFacilityAffectCaregiver { get; set; }
        public bool? HomeFacilityAffectCareManager { get; set; }
        [StringLength(500)]
        public string HomeFacilityRemarks { get; set; }
        public bool? IsRequirePalliativeCare { get; set; }
        public int? PainLevel { get; set; }
        public int? TirednessLevel { get; set; }
        public int? DrowsinessLevel { get; set; }
        public int? NauseaLevel { get; set; }
        public int? LackOfAppetiteLevel { get; set; }
        public int? ShortnessOfBreath { get; set; }
        public int? DepressionLevel { get; set; }
        public int? AnxietyLevel { get; set; }
        public int? BestWellbeing { get; set; }
        [StringLength(255)]
        public string Faith { get; set; }
        public bool? IsReligious { get; set; }
        [StringLength(255)]
        public string GiveMeaningToLife { get; set; }
        [StringLength(255)]
        public string MakeSense { get; set; }
        public bool? IsBeliefImportant { get; set; }
        [StringLength(255)]
        public string InfluenceTakeCare { get; set; }
        [StringLength(255)]
        public string BeliefInfluenced { get; set; }
        [StringLength(255)]
        public string RoleOfBeliefForInfluence { get; set; }
        public bool? IsPartOfCommunity { get; set; }
        [StringLength(255)]
        public string SupportTo { get; set; }
        [StringLength(255)]
        public string RoleOfBeliefForCommunity { get; set; }
        [StringLength(255)]
        public string PersonalConcern { get; set; }
        [StringLength(255)]
        public string AddressIssue { get; set; }
        [StringLength(255)]
        public string Concern { get; set; }
        [StringLength(255)]
        public string TalkToSomeone { get; set; }
        public int? OralCavityAssessmentScore7 { get; set; }
        public int? OralCavityAssessmentScore8 { get; set; }
        [Column("PatientNutritionID_FK")]
        public int? PatientNutritionIdFk { get; set; }
        [Column("PatientRAFID_FK")]
        public int? PatientRafidFk { get; set; }
        [Column("PatientMBIID_FK")]
        public int? PatientMbiidFk { get; set; }
        [Column("PatientMFSID_FK")]
        public int? PatientMfsidFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? VisitDateTime { get; set; }
        [Column("VSOnSetDate", TypeName = "datetime")]
        public DateTime? VsonSetDate { get; set; }
        [Column("painOnSetDate", TypeName = "datetime")]
        public DateTime? PainOnSetDate { get; set; }
        [Column("VSQuality")]
        [StringLength(20)]
        public string Vsquality { get; set; }
        [Column("VSPainFrequency")]
        [StringLength(20)]
        public string VspainFrequency { get; set; }
        [Column("VSIntermittent")]
        [StringLength(20)]
        public string Vsintermittent { get; set; }
        [Column("VSLocation")]
        [StringLength(255)]
        public string Vslocation { get; set; }
        [Column("VSPrecipitatingFactors")]
        [StringLength(255)]
        public string VsprecipitatingFactors { get; set; }
        [Column("VSRelievingFactors")]
        [StringLength(255)]
        public string VsrelievingFactors { get; set; }
        [Column("VSPainFrequencyIntermittentNumber")]
        public int? VspainFrequencyIntermittentNumber { get; set; }
        [Column("CAAlertness")]
        [StringLength(50)]
        public string Caalertness { get; set; }
        [Column("CACommunication")]
        [StringLength(50)]
        public string Cacommunication { get; set; }
        [Column("CADementia")]
        public bool? Cadementia { get; set; }
        [Column("CAdateAndTime")]
        public bool? CadateAndTime { get; set; }
        [Column("CAPerson")]
        public bool? Caperson { get; set; }
        [Column("CAPlace")]
        public bool? Caplace { get; set; }
        [Column("CASituation")]
        public bool? Casituation { get; set; }
        public bool? HearingAid { get; set; }
        public bool? ChestSymmetry { get; set; }
        public bool? AbdomenSymmetry { get; set; }
        public bool? AnySkinIssue { get; set; }
        public bool? PressureInjuries { get; set; }
        public int? ApicalPulse { get; set; }
        [StringLength(100)]
        public string SkinType { get; set; }
        [StringLength(100)]
        public string SkinIssue { get; set; }
        [StringLength(100)]
        public string SkinTurgor { get; set; }
        [StringLength(100)]
        public string BreathSounds { get; set; }
        [StringLength(100)]
        public string BowelSounds { get; set; }
        [StringLength(100)]
        public string Percussion { get; set; }
        [StringLength(100)]
        public string Palpation { get; set; }
        [Column("TenderNGuarding")]
        [StringLength(100)]
        public string TenderNguarding { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        public int? LeftUpperLimbStrength { get; set; }
        public int? RightUpperLimbStrength { get; set; }
        public int? LeftLowerLimbStrength { get; set; }
        public int? RightLowerLimbStrength { get; set; }
        [StringLength(100)]
        public string MobilityStatus { get; set; }
        [StringLength(100)]
        public string AssistiveAids { get; set; }
        public bool? Incontinence { get; set; }
        [StringLength(20)]
        public string IncontinenceType { get; set; }
        [StringLength(20)]
        public string UrineConsistency { get; set; }
        [StringLength(20)]
        public string UrineColour { get; set; }
        [StringLength(20)]
        public string StoolsType { get; set; }
        public bool? VisionSpectacles { get; set; }
        public bool? OxygenRequired { get; set; }
        public bool? Sputum { get; set; }
        public bool? SuctioningRequired { get; set; }
        [Column("OxygenLMin", TypeName = "decimal(5, 2)")]
        public decimal? OxygenLmin { get; set; }
        [StringLength(100)]
        public string OxygenType { get; set; }
        [StringLength(255)]
        public string OxygenRemark { get; set; }
        [StringLength(100)]
        public string Oralhealth { get; set; }
        [StringLength(100)]
        public string Teeth { get; set; }
        public bool? AblePassUrine { get; set; }
        public bool? NutritionalImbalance { get; set; }
    }
}
