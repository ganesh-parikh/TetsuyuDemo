using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_CarePlanSubProblemListGoal")]
    public partial class AuditCarePlanSubProblemListGoal
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("CarePlanSubProblemListGoalID")]
        public int CarePlanSubProblemListGoalId { get; set; }
        [Column("CarePlanSubProblemListID_FK")]
        public int CarePlanSubProblemListIdFk { get; set; }
        [StringLength(500)]
        public string Goal { get; set; }
        public int? Action { get; set; }
        [Column("ScoreTypeID")]
        public int? ScoreTypeId { get; set; }
        [Column("OperatorID")]
        public int? OperatorId { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Score1 { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Score2 { get; set; }
        [Column("ProblemListGoalID_FK")]
        public int? ProblemListGoalIdFk { get; set; }
    }
}
