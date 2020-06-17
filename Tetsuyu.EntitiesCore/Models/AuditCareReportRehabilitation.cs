using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_CareReportRehabilitation")]
    public partial class AuditCareReportRehabilitation
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("CareReportRehabilitationID")]
        public int CareReportRehabilitationId { get; set; }
        [Column("IsADLAssistance")]
        public bool? IsAdlassistance { get; set; }
        [Column("ADLAssistanceType")]
        [StringLength(30)]
        public string AdlassistanceType { get; set; }
        [StringLength(30)]
        public string Bounded { get; set; }
        public int? NoOfTimesTurned { get; set; }
        public int? NoOfSatOutOfBed { get; set; }
        [Column("IsDVTPrevention")]
        public bool? IsDvtprevention { get; set; }
        [Column("DVTType")]
        [StringLength(300)]
        public string Dvttype { get; set; }
        public bool? RequirePhysioTherapist { get; set; }
        public int? VisitForPhysioTherapist { get; set; }
        public bool? RequireOccupationTherapist { get; set; }
        public int? VisitForOccupationTherapist { get; set; }
        public bool? RequireSpeechTherapist { get; set; }
        public int? VisitForSpeechTherapist { get; set; }
        public bool? RequireWalkingAid { get; set; }
        [StringLength(30)]
        public string WalkingAidType { get; set; }
        public bool? IsUpperLimbStrengthLeft { get; set; }
        public bool? IsUpperLimbStrengthRight { get; set; }
        public int? UpperLimbStrengthLeft { get; set; }
        public int? UpperLimbStrengthRight { get; set; }
        public bool? IsLowerLimbStrengthLeft { get; set; }
        public bool? IsLowerLimbStrengthRight { get; set; }
        public int? LowerLimbStrengthLeft { get; set; }
        public int? LowerLimbStrengthRight { get; set; }
        [StringLength(500)]
        public string RehabilitationRemarks { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
    }
}
