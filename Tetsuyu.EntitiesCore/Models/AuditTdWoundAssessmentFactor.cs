using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_TD_WoundAssessmentFactor")]
    public partial class AuditTdWoundAssessmentFactor
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("TD_WoundAssessmentID_FK")]
        public int TdWoundAssessmentIdFk { get; set; }
        [Column("CodeID_FK")]
        public int CodeIdFk { get; set; }
    }
}
