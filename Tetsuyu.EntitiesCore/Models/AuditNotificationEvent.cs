using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_NotificationEvent")]
    public partial class AuditNotificationEvent
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("NotificationEventID")]
        public int NotificationEventId { get; set; }
        [Column("NotificationId_FK")]
        public int NotificationIdFk { get; set; }
        [Column("EventID_FK")]
        public int EventIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
    }
}
