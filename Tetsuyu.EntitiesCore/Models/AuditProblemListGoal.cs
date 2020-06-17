using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_ProblemListGoal")]
    public partial class AuditProblemListGoal
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("ProblemListGoalID")]
        public int ProblemListGoalId { get; set; }
        [Column("ProblemListID_FK")]
        public int ProblemListIdFk { get; set; }
        [StringLength(500)]
        public string Goal { get; set; }
        public int? Action { get; set; }
        [Column("ScoreTypeID")]
        public int? ScoreTypeId { get; set; }
        [Column("OperatorID")]
        public int? OperatorId { get; set; }
    }
}
