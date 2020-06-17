using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class CarePlanSubProblemListGoal
    {
        [Key]
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
        [Column(TypeName = "numeric(3, 0)")]
        public decimal? Score1 { get; set; }
        [Column(TypeName = "numeric(3, 0)")]
        public decimal? Score2 { get; set; }
        [Column("ProblemListGoalID_FK")]
        public int? ProblemListGoalIdFk { get; set; }

        [ForeignKey(nameof(CarePlanSubProblemListIdFk))]
        [InverseProperty(nameof(CarePlanSubProblemList.CarePlanSubProblemListGoal))]
        public virtual CarePlanSubProblemList CarePlanSubProblemListIdFkNavigation { get; set; }
        [ForeignKey(nameof(OperatorId))]
        [InverseProperty(nameof(Code.CarePlanSubProblemListGoalOperator))]
        public virtual Code Operator { get; set; }
        [ForeignKey(nameof(ProblemListGoalIdFk))]
        [InverseProperty(nameof(ProblemListGoal.CarePlanSubProblemListGoal))]
        public virtual ProblemListGoal ProblemListGoalIdFkNavigation { get; set; }
        [ForeignKey(nameof(ScoreTypeId))]
        [InverseProperty(nameof(Code.CarePlanSubProblemListGoalScoreType))]
        public virtual Code ScoreType { get; set; }
    }
}
