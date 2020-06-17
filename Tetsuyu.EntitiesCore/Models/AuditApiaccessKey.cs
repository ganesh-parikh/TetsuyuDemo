using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_APIAccessKey")]
    public partial class AuditApiaccessKey
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("APIAccessKeyID")]
        public int ApiaccessKeyId { get; set; }
        [Required]
        [StringLength(100)]
        public string TokenCode { get; set; }
        [Required]
        [StringLength(200)]
        public string AccessKey { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ExpiryDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
        [Column("UserId_FK")]
        public int? UserIdFk { get; set; }
    }
}
