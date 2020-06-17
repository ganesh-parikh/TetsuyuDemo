using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("CarePlanSubCPGoals")]
    public partial class CarePlanSubCpgoals
    {
        [Key]
        [Column("CarePlanSubID_FK")]
        public int CarePlanSubIdFk { get; set; }
        [Key]
        [Column("CPGoalsID_FK")]
        public int CpgoalsIdFk { get; set; }

        [ForeignKey(nameof(CarePlanSubIdFk))]
        [InverseProperty(nameof(CarePlanSub.CarePlanSubCpgoals))]
        public virtual CarePlanSub CarePlanSubIdFkNavigation { get; set; }
        [ForeignKey(nameof(CpgoalsIdFk))]
        [InverseProperty(nameof(Cpgoals.CarePlanSubCpgoals))]
        public virtual Cpgoals CpgoalsIdFkNavigation { get; set; }
    }
}
