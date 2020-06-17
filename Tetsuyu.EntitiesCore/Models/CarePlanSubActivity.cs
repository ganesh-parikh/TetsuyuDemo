using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class CarePlanSubActivity
    {
        [Key]
        [Column("CarePlanSubID_FK")]
        public int CarePlanSubIdFk { get; set; }
        [Key]
        [Column("ActivityID_FK")]
        public int ActivityIdFk { get; set; }

        [ForeignKey(nameof(ActivityIdFk))]
        [InverseProperty(nameof(Activity.CarePlanSubActivity))]
        public virtual Activity ActivityIdFkNavigation { get; set; }
        [ForeignKey(nameof(CarePlanSubIdFk))]
        [InverseProperty(nameof(CarePlanSub.CarePlanSubActivity))]
        public virtual CarePlanSub CarePlanSubIdFkNavigation { get; set; }
    }
}
