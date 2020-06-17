using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_CarePlanDetail")]
    public partial class AuditCarePlanDetail
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
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
    }
}
