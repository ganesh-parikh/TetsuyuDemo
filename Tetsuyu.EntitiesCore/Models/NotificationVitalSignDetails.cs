using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class NotificationVitalSignDetails
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("notificationId")]
        public int NotificationId { get; set; }
        [Column("createdDate", TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("updatedDate", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
        public int VitalSignDetailId { get; set; }

        [ForeignKey(nameof(NotificationId))]
        [InverseProperty(nameof(Notifications.NotificationVitalSignDetails))]
        public virtual Notifications Notification { get; set; }
        [ForeignKey(nameof(VitalSignDetailId))]
        [InverseProperty(nameof(VitalSignDetails.NotificationVitalSignDetails))]
        public virtual VitalSignDetails VitalSignDetail { get; set; }
    }
}
