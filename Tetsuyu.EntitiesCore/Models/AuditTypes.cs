using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_Types")]
    public partial class AuditTypes
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Required]
        [Column("code")]
        [StringLength(100)]
        public string Code { get; set; }
        [Required]
        [Column("codeValue")]
        [StringLength(200)]
        public string CodeValue { get; set; }
        [Column("parentCode")]
        [StringLength(100)]
        public string ParentCode { get; set; }
        [Column("ordering")]
        public int Ordering { get; set; }
        [Column("created", TypeName = "datetime")]
        public DateTime Created { get; set; }
        [Column("updated", TypeName = "datetime")]
        public DateTime? Updated { get; set; }
    }
}
