using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class VwCarePlanSystemDisease
    {
        [Column("CarePlanID")]
        public int CarePlanId { get; set; }
        [Column("SystemID_FK")]
        public int SystemIdFk { get; set; }
        [Column("DiseaseID_FK")]
        public int DiseaseIdFk { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsClosed { get; set; }
    }
}
