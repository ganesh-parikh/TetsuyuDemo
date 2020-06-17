using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_PatientSpecialIndicator")]
    public partial class AuditPatientSpecialIndicator
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("PatientID_FK")]
        public int PatientIdFk { get; set; }
        [Column("CodeID_FK")]
        public int CodeIdFk { get; set; }
    }
}
