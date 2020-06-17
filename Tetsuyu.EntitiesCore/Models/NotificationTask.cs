using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class NotificationTask
    {
        [Key]
        [Column("NotificationTaskID")]
        public int NotificationTaskId { get; set; }
        [Column("NotificationId_FK")]
        public int NotificationIdFk { get; set; }
        [Column("TaskID_FK")]
        public int TaskIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }

        [ForeignKey(nameof(NotificationIdFk))]
        [InverseProperty(nameof(Notifications.NotificationTask))]
        public virtual Notifications NotificationIdFkNavigation { get; set; }
        [ForeignKey(nameof(TaskIdFk))]
        [InverseProperty(nameof(Task.NotificationTask))]
        public virtual Task TaskIdFkNavigation { get; set; }
    }
}
