using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class VwFalangaScores
    {
        [Column("patientwoundvisitID")]
        public int PatientwoundvisitId { get; set; }
        [StringLength(50)]
        public string HealingEdges { get; set; }
        [Column("HealingEdges_Score")]
        public int HealingEdgesScore { get; set; }
        [Required]
        [StringLength(43)]
        public string BlackEschar { get; set; }
        [Column("BlackEschar_Score")]
        public int BlackEscharScore { get; set; }
        [Required]
        [StringLength(71)]
        public string GreatestWoundDepth { get; set; }
        [Column("GreatestWoundDepth_Score")]
        public int GreatestWoundDepthScore { get; set; }
        [StringLength(50)]
        public string ExudateAmount { get; set; }
        [Column("ExudateAmount_Score")]
        public int ExudateAmountScore { get; set; }
        public bool? Edema { get; set; }
        [Column("Edema_Score")]
        public int EdemaScore { get; set; }
        [StringLength(50)]
        public string PeriwoundDermatitis { get; set; }
        [Column("PeriwoundDermatitis_Score")]
        public int PeriwoundDermatitisScore { get; set; }
        [StringLength(50)]
        public string PeriwoundCallousFibrosis { get; set; }
        [Column("PeriwoundCallousFibrosis_Score")]
        public int PeriwoundCallousFibrosisScore { get; set; }
        [Required]
        [StringLength(43)]
        public string PinkWoundBed { get; set; }
        [Column("PinkWoundBed_Score")]
        public int PinkWoundBedScore { get; set; }
        public int? TotalScore { get; set; }
    }
}
