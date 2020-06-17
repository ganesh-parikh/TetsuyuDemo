using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_Role")]
    public partial class AuditRole
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        public int RoleId { get; set; }
        [Required]
        [StringLength(250)]
        public string RoleDescription { get; set; }
        [Required]
        [StringLength(250)]
        public string OptionText { get; set; }
        [Required]
        [StringLength(250)]
        public string OptionValue { get; set; }
        [Required]
        [StringLength(1)]
        public string OptionType { get; set; }
        public int Ordering { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        public bool? Active { get; set; }
    }
}
