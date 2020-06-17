using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_LoginDevice")]
    public partial class AuditLoginDevice
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        public int LoginDeviceId { get; set; }
        [Column("UserId_FK")]
        public int UserIdFk { get; set; }
        [Required]
        [StringLength(8)]
        public string DeviceType { get; set; }
        [Required]
        [Column("DeviceID")]
        [StringLength(200)]
        public string DeviceId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
    }
}
