using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class NotificationEvent
    {
        [Key]
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

        [ForeignKey(nameof(EventIdFk))]
        [InverseProperty(nameof(Event.NotificationEvent))]
        public virtual Event EventIdFkNavigation { get; set; }
        [ForeignKey(nameof(NotificationIdFk))]
        [InverseProperty(nameof(Notifications.NotificationEvent))]
        public virtual Notifications NotificationIdFkNavigation { get; set; }
    }
}
