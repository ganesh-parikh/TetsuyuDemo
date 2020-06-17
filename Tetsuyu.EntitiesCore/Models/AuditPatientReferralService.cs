using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_PatientReferralService")]
    public partial class AuditPatientReferralService
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("PatientReferralID_FK")]
        public int PatientReferralIdFk { get; set; }
        [Column("ServiceID_FK")]
        public int ServiceIdFk { get; set; }
    }
}
