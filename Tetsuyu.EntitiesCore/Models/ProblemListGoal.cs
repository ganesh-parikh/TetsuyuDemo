using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class ProblemListGoal
    {
        public ProblemListGoal()
        {
            CarePlanSubProblemListGoal = new HashSet<CarePlanSubProblemListGoal>();
        }

        [Key]
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

        [ForeignKey(nameof(OperatorId))]
        [InverseProperty(nameof(Code.ProblemListGoalOperator))]
        public virtual Code Operator { get; set; }
        [ForeignKey(nameof(ProblemListIdFk))]
        [InverseProperty(nameof(ProblemList.ProblemListGoal))]
        public virtual ProblemList ProblemListIdFkNavigation { get; set; }
        [ForeignKey(nameof(ScoreTypeId))]
        [InverseProperty(nameof(Code.ProblemListGoalScoreType))]
        public virtual Code ScoreType { get; set; }
        [InverseProperty("ProblemListGoalIdFkNavigation")]
        public virtual ICollection<CarePlanSubProblemListGoal> CarePlanSubProblemListGoal { get; set; }
    }
}
