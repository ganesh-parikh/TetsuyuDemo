using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class NotificationChat
    {
        [Key]
        [Column("NotificationChatID")]
        public int NotificationChatId { get; set; }
        [Column("NotificationId_FK")]
        public int NotificationIdFk { get; set; }
        [Column("ChatID_FK")]
        public int ChatIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }

        [ForeignKey(nameof(ChatIdFk))]
        [InverseProperty(nameof(Chat.NotificationChat))]
        public virtual Chat ChatIdFkNavigation { get; set; }
        [ForeignKey(nameof(NotificationIdFk))]
        [InverseProperty(nameof(Notifications.NotificationChat))]
        public virtual Notifications NotificationIdFkNavigation { get; set; }
    }
}
