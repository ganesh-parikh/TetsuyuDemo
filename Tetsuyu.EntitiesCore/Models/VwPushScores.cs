using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class VwPushScores
    {
        [Column("PatientWoundVisitID")]
        public int PatientWoundVisitId { get; set; }
        [Column("LengthXWidthScore")]
        public int LengthXwidthScore { get; set; }
        public int ExudateAmountScore { get; set; }
        public int TissueTypeScore { get; set; }
        public int? TotalScore { get; set; }
    }
}
