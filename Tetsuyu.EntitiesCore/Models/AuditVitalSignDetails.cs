using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_VitalSignDetails")]
    public partial class AuditVitalSignDetails
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
        [Column("vitalSignId")]
        public int VitalSignId { get; set; }
        [Column("detailValue", TypeName = "decimal(18, 2)")]
        public decimal DetailValue { get; set; }
        public bool IsDeleted { get; set; }
    }
}
