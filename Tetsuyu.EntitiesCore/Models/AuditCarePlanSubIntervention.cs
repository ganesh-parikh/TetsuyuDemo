using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_CarePlanSubIntervention")]
    public partial class AuditCarePlanSubIntervention
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("CarePlanSubID_FK")]
        public int CarePlanSubIdFk { get; set; }
        [Column("InterventionID_FK")]
        public int InterventionIdFk { get; set; }
    }
}
