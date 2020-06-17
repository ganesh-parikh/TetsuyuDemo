using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_UserBranch")]
    public partial class AuditUserBranch
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("UserID_FK")]
        public int UserIdFk { get; set; }
        [Column("BranchID_FK")]
        public int BranchIdFk { get; set; }
    }
}
