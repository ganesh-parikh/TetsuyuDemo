using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_TreatmentTOL")]
    public partial class AuditTreatmentTol
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("TreatmentTOLID")]
        public int TreatmentTolid { get; set; }
        [Column("TListItemID_FK")]
        public int TlistItemIdFk { get; set; }
    }
}
