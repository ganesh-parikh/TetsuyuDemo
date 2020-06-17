using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_UserRole")]
    public partial class AuditUserRole
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("UserId_FK")]
        public int UserIdFk { get; set; }
        [Column("RoleId_FK")]
        public int RoleIdFk { get; set; }
        [Required]
        [StringLength(50)]
        public string Role { get; set; }
    }
}
