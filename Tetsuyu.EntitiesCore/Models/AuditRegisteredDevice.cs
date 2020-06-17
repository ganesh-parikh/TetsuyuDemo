using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_RegisteredDevice")]
    public partial class AuditRegisteredDevice
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("DeviceID")]
        public int DeviceId { get; set; }
        public int? DeviceType { get; set; }
        [StringLength(300)]
        public string DeviceToken { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }
        public bool? Status { get; set; }
    }
}
