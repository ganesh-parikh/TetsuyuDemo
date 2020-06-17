using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientNutrition
    {
        public PatientNutrition()
        {
            CareReport = new HashSet<CareReport>();
            InitialCareAssessment = new HashSet<InitialCareAssessment>();
        }

        [Key]
        [Column("PatientNutritionID")]
        public int PatientNutritionId { get; set; }
        [StringLength(20)]
        public string EatingAndSwallowing { get; set; }
        [StringLength(20)]
        public string EatingAndSwallowingTypeOfTubeFeeding { get; set; }
        [StringLength(20)]
        public string EatingAndSwallowingTypeOfTube { get; set; }
        [StringLength(20)]
        public string EatingAndSwallowingSize { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EatingAndSwallowingDateInserted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EatingAndSwallowingDateDue { get; set; }
        [StringLength(20)]
        public string Diet { get; set; }
        [StringLength(20)]
        public string Appetite { get; set; }
        [StringLength(20)]
        public string FluidConsistency { get; set; }
        [Column("FluidRestrictionMLSPerDay", TypeName = "decimal(4, 0)")]
        public decimal? FluidRestrictionMlsperDay { get; set; }
        public bool? ReviewedBySpeechTherapist { get; set; }
        public bool? ReferralToSpeechTherapist { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        [StringLength(20)]
        public string Enteralfeeding { get; set; }
        [Column("SizeofPEGJtube")]
        [StringLength(20)]
        public string SizeofPegjtube { get; set; }
        [Column("IVtherapyStateType")]
        [StringLength(255)]
        public string IvtherapyStateType { get; set; }
        public bool? SwallowingIssues { get; set; }
        public bool? DiagnosedDysphasia { get; set; }
        [Column("IsFIsluidRestriction")]
        public bool? IsFisluidRestriction { get; set; }
        [Column("IVtherapy")]
        public bool? Ivtherapy { get; set; }
        [Column("IVtherapyMLSPerDay", TypeName = "decimal(4, 0)")]
        public decimal? IvtherapyMlsperDay { get; set; }
        [Column(TypeName = "decimal(4, 0)")]
        public decimal? MilkFeedAmt { get; set; }
        [Column(TypeName = "decimal(4, 0)")]
        public decimal? WaterPerDay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DiagnosedDysphasiaLastReviewDate { get; set; }

        [InverseProperty("PatientNutritionIdFkNavigation")]
        public virtual ICollection<CareReport> CareReport { get; set; }
        [InverseProperty("PatientNutritionIdFkNavigation")]
        public virtual ICollection<InitialCareAssessment> InitialCareAssessment { get; set; }
    }
}
