using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_TaskServicesRequired")]
    public partial class AuditTaskServicesRequired
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("TaskID_FK")]
        public int TaskIdFk { get; set; }
        [Column("CodeID_FK")]
        public int CodeIdFk { get; set; }
    }
}
