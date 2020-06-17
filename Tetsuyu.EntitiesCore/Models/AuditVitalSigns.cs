using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_VitalSigns")]
    public partial class AuditVitalSigns
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Column("patientId")]
        public int PatientId { get; set; }
        [Required]
        [Column("source")]
        [StringLength(200)]
        public string Source { get; set; }
        [Column("icaId")]
        public int IcaId { get; set; }
        [Column("isDeleted")]
        public bool IsDeleted { get; set; }
        [Column("createdBy")]
        public int? CreatedBy { get; set; }
        [Column("createdDate", TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("updatedBy")]
        public int? UpdatedBy { get; set; }
        [Column("updatedDate", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
    }
}
