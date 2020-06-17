using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class CarePlanDetail
    {
        [Key]
        [Column("CarePlanDetailID")]
        public int CarePlanDetailId { get; set; }
        [Column("CarePlanSubID_FK")]
        public int CarePlanSubIdFk { get; set; }
        [Column("SystemID_FK")]
        public int SystemIdFk { get; set; }
        [Column("DiseaseID_FK")]
        public int DiseaseIdFk { get; set; }
        [Column("DiseaseSubInfoID_FK")]
        public int? DiseaseSubInfoIdFk { get; set; }

        [ForeignKey(nameof(CarePlanSubIdFk))]
        [InverseProperty(nameof(CarePlanSub.CarePlanDetail))]
        public virtual CarePlanSub CarePlanSubIdFkNavigation { get; set; }
        [ForeignKey(nameof(DiseaseIdFk))]
        [InverseProperty(nameof(Disease.CarePlanDetail))]
        public virtual Disease DiseaseIdFkNavigation { get; set; }
        [ForeignKey(nameof(SystemIdFk))]
        [InverseProperty(nameof(SystemForDisease.CarePlanDetail))]
        public virtual SystemForDisease SystemIdFkNavigation { get; set; }
    }
}
