using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_NotificationMessageTemplates")]
    public partial class AuditNotificationMessageTemplates
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("notificationgroupCode")]
        [StringLength(100)]
        public string NotificationgroupCode { get; set; }
        [Column("notificationSubject")]
        [StringLength(200)]
        public string NotificationSubject { get; set; }
        [Required]
        [Column("notificationMessage")]
        [StringLength(500)]
        public string NotificationMessage { get; set; }
        [Column("createdDate", TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("updatedDate", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
    }
}
