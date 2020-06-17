using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class CarePlanSubGoal
    {
        [Key]
        [Column("CarePlanSubGoalID")]
        public int CarePlanSubGoalId { get; set; }
        [Column("CarePlanSubID_FK")]
        public int CarePlanSubIdFk { get; set; }
        [Column("ScoreTypeID")]
        public int? ScoreTypeId { get; set; }
        [Column("OperatorID")]
        public int? OperatorId { get; set; }
        [Column(TypeName = "numeric(3, 0)")]
        public decimal? Score1 { get; set; }
        [Column(TypeName = "numeric(3, 0)")]
        public decimal? Score2 { get; set; }
        [StringLength(255)]
        public string CarePlanSubGoalName { get; set; }
        public bool? IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        [Column("DiseaseID_FK")]
        public int? DiseaseIdFk { get; set; }

        [ForeignKey(nameof(CarePlanSubIdFk))]
        [InverseProperty(nameof(CarePlanSub.CarePlanSubGoal))]
        public virtual CarePlanSub CarePlanSubIdFkNavigation { get; set; }
        [ForeignKey(nameof(DiseaseIdFk))]
        [InverseProperty(nameof(Disease.CarePlanSubGoal))]
        public virtual Disease DiseaseIdFkNavigation { get; set; }
    }
}
