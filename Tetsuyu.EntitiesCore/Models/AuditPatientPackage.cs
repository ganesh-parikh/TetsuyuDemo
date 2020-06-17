using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_PatientPackage")]
    public partial class AuditPatientPackage
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("PatientID_FK")]
        public int PatientIdFk { get; set; }
        [Column("PackageID_FK")]
        public int PackageIdFk { get; set; }
    }
}
