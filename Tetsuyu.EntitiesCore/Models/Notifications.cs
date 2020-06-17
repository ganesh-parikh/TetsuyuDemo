using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class Notifications
    {
        public Notifications()
        {
            NotificationChat = new HashSet<NotificationChat>();
            NotificationEvent = new HashSet<NotificationEvent>();
            NotificationTask = new HashSet<NotificationTask>();
            NotificationVitalSignDetails = new HashSet<NotificationVitalSignDetails>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("userId")]
        public int UserId { get; set; }
        [Required]
        [Column("notificationTypeCode")]
        [StringLength(100)]
        public string NotificationTypeCode { get; set; }
        [Column("isRead")]
        public bool IsRead { get; set; }
        [Column("isDeleted")]
        public bool IsDeleted { get; set; }
        [Column("createdDate", TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("updatedDate", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }

        [ForeignKey(nameof(NotificationTypeCode))]
        [InverseProperty(nameof(Types.Notifications))]
        public virtual Types NotificationTypeCodeNavigation { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(Users.Notifications))]
        public virtual Users User { get; set; }
        [InverseProperty("NotificationIdFkNavigation")]
        public virtual ICollection<NotificationChat> NotificationChat { get; set; }
        [InverseProperty("NotificationIdFkNavigation")]
        public virtual ICollection<NotificationEvent> NotificationEvent { get; set; }
        [InverseProperty("NotificationIdFkNavigation")]
        public virtual ICollection<NotificationTask> NotificationTask { get; set; }
        [InverseProperty("Notification")]
        public virtual ICollection<NotificationVitalSignDetails> NotificationVitalSignDetails { get; set; }
    }
}
