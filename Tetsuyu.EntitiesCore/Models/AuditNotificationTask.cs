using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_NotificationTask")]
    public partial class AuditNotificationTask
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("NotificationTaskID")]
        public int? NotificationTaskId { get; set; }
        [Column("NotificationId_FK")]
        public int NotificationIdFk { get; set; }
        [Column("TaskID_FK")]
        public int TaskIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
    }
}
