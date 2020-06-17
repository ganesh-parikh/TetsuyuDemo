using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_PatientWoundVisit")]
    public partial class AuditPatientWoundVisit
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("PatientWoundVisitID")]
        public int PatientWoundVisitId { get; set; }
        [Column("PatientWoundID_FK")]
        public int PatientWoundIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? VisitDate { get; set; }
        [Required]
        [StringLength(50)]
        public string WoundType { get; set; }
        [StringLength(50)]
        public string WoundSubType { get; set; }
        [StringLength(50)]
        public string WoundTypeOther { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? SizeLength { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? SizeDepth { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? SizeWidth { get; set; }
        [StringLength(50)]
        public string Edges { get; set; }
        [StringLength(50)]
        public string Appearance { get; set; }
        [StringLength(50)]
        public string Smell { get; set; }
        [StringLength(255)]
        public string UnderMining { get; set; }
        [StringLength(50)]
        public string Exudate { get; set; }
        public int? Suffering { get; set; }
        [StringLength(50)]
        public string ImageUpload { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? SurfaceArea { get; set; }
        [Column(TypeName = "decimal(4, 1)")]
        public decimal? UnderMiningDepth { get; set; }
        [StringLength(50)]
        public string ExudateSubInfo { get; set; }
        [Column("VitalSignID_FK")]
        public int? VitalSignIdFk { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        [Column("CareReportID_FK")]
        public int? CareReportIdFk { get; set; }
        [Column("InitialCareAssessmentID_FK")]
        public int? InitialCareAssessmentIdFk { get; set; }
        [Column("ReferID_FK")]
        public int? ReferIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NextReviewDate { get; set; }
        [StringLength(500)]
        public string TreatmentRemarks { get; set; }
        [Column("AssignedToID_FK")]
        public int? AssignedToIdFk { get; set; }
        [Column("DESIGN_R_Depth")]
        [StringLength(50)]
        public string DesignRDepth { get; set; }
        [Column("DESIGN_R_Exudate")]
        public int? DesignRExudate { get; set; }
        [Column("DESIGN_R_Size")]
        public int? DesignRSize { get; set; }
        [Column("DESIGN_R_Inflammation")]
        public int? DesignRInflammation { get; set; }
        [Column("DESIGN_R_Granulation")]
        public int? DesignRGranulation { get; set; }
        [Column("DESIGN_R_Necrotic")]
        public int? DesignRNecrotic { get; set; }
        [Column("DESIGN_R_Pocket")]
        public int? DesignRPocket { get; set; }
        [Column("DESIGN_R_Score")]
        public int? DesignRScore { get; set; }
        [Column("IsDESIGN_R")]
        public bool? IsDesignR { get; set; }
        [StringLength(50)]
        public string ExudateSubInfo2 { get; set; }
        [StringLength(50)]
        public string PeriWound { get; set; }
        [StringLength(50)]
        public string Debridement { get; set; }
        [StringLength(50)]
        public string CleansingSolutionUsed { get; set; }
        [Column("Model_jpg")]
        public string ModelJpg { get; set; }
        [Column("Model_mtl")]
        public string ModelMtl { get; set; }
        [Column("Model_obj")]
        public string ModelObj { get; set; }
        public bool? IsDraft { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Volume { get; set; }
        public bool? WoundInfection { get; set; }
        [Column("fever")]
        public bool? Fever { get; set; }
        [Column("temperature", TypeName = "decimal(5, 2)")]
        public decimal? Temperature { get; set; }
        [Column("abscessPuss")]
        public bool? AbscessPuss { get; set; }
        [Column("increasedPain")]
        public bool? IncreasedPain { get; set; }
        [Column("erythema")]
        public bool? Erythema { get; set; }
        [Column("oedema")]
        public bool? Oedema { get; set; }
        [Column("localWarmth")]
        public bool? LocalWarmth { get; set; }
        [Column("increasedExcudate")]
        public bool? IncreasedExcudate { get; set; }
        [Column("delayedHealing")]
        public bool? DelayedHealing { get; set; }
        [Column("maladour")]
        public bool? Maladour { get; set; }
        [Column("pocketing")]
        public bool? Pocketing { get; set; }
        [Column("suspectedInfection")]
        public bool? SuspectedInfection { get; set; }
        [Column("TC_Granulation", TypeName = "decimal(5, 2)")]
        public decimal? TcGranulation { get; set; }
        [Column("TC_Slough", TypeName = "decimal(5, 2)")]
        public decimal? TcSlough { get; set; }
        [Column("TC_Necrosis", TypeName = "decimal(5, 2)")]
        public decimal? TcNecrosis { get; set; }
        [Column("TC_Epithelizing", TypeName = "decimal(5, 2)")]
        public decimal? TcEpithelizing { get; set; }
        [Column("TC_Others", TypeName = "decimal(5, 2)")]
        public decimal? TcOthers { get; set; }
        [Column("TC_OriginalImage")]
        public string TcOriginalImage { get; set; }
        [Column("TC_WoundBedImage")]
        public string TcWoundBedImage { get; set; }
        [Column("TC_AnnotatedImage")]
        public string TcAnnotatedImage { get; set; }
        [Column("TC_IsAccept")]
        public bool? TcIsAccept { get; set; }
        [Column("TC_Reason")]
        public string TcReason { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Perimeter { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal? AverageDepth { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? MaximumDepth { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? MinimumDepth { get; set; }
        public bool? IsRedness { get; set; }
        public bool? IsSwelling { get; set; }
        public bool? IsWarmToTouch { get; set; }
        public bool? IsSmell { get; set; }
        [Column(TypeName = "decimal(5, 2)")]
        public decimal? Size { get; set; }
        [Column("TC_Auto_Granulation", TypeName = "decimal(5, 2)")]
        public decimal? TcAutoGranulation { get; set; }
        [Column("TC_Auto_Slough", TypeName = "decimal(5, 2)")]
        public decimal? TcAutoSlough { get; set; }
        [Column("TC_Auto_Necrosis", TypeName = "decimal(5, 2)")]
        public decimal? TcAutoNecrosis { get; set; }
        [Column("TC_Auto_Epithelizing", TypeName = "decimal(5, 2)")]
        public decimal? TcAutoEpithelizing { get; set; }
        [Column("TC_Auto_Others", TypeName = "decimal(5, 2)")]
        public decimal? TcAutoOthers { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NextTreatmentDate { get; set; }
        [StringLength(500)]
        public string InfectionRemarks { get; set; }
        [Column("TO_Comments")]
        public string ToComments { get; set; }
    }
}
