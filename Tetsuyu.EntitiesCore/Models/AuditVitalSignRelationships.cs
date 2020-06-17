using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_VitalSignRelationships")]
    public partial class AuditVitalSignRelationships
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Column("vitalSignTypeId")]
        public int VitalSignTypeId { get; set; }
        [Column("patientId")]
        public int PatientId { get; set; }
        [Column("thresholdId")]
        public int ThresholdId { get; set; }
    }
}
