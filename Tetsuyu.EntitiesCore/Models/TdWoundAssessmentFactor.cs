using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("TD_WoundAssessmentFactor")]
    public partial class TdWoundAssessmentFactor
    {
        [Key]
        [Column("TD_WoundAssessmentID_FK")]
        public int TdWoundAssessmentIdFk { get; set; }
        [Key]
        [Column("CodeID_FK")]
        public int CodeIdFk { get; set; }

        [ForeignKey(nameof(CodeIdFk))]
        [InverseProperty(nameof(Code.TdWoundAssessmentFactor))]
        public virtual Code CodeIdFkNavigation { get; set; }
    }
}
