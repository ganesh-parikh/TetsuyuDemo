using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class CarePlanSubIntervention
    {
        [Key]
        [Column("CarePlanSubID_FK")]
        public int CarePlanSubIdFk { get; set; }
        [Key]
        [Column("InterventionID_FK")]
        public int InterventionIdFk { get; set; }

        [ForeignKey(nameof(CarePlanSubIdFk))]
        [InverseProperty(nameof(CarePlanSub.CarePlanSubIntervention))]
        public virtual CarePlanSub CarePlanSubIdFkNavigation { get; set; }
        [ForeignKey(nameof(InterventionIdFk))]
        [InverseProperty(nameof(Intervention.CarePlanSubIntervention))]
        public virtual Intervention InterventionIdFkNavigation { get; set; }
    }
}
