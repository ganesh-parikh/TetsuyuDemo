using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class Event
    {
        public Event()
        {
            EventUser = new HashSet<EventUser>();
            EventUserLog = new HashSet<EventUserLog>();
            NotificationEvent = new HashSet<NotificationEvent>();
        }

        [Key]
        [Column("EventID")]
        public int EventId { get; set; }
        [Required]
        [StringLength(50)]
        public string EventName { get; set; }
        [Column("EventTypeID_FK")]
        public int EventTypeIdFk { get; set; }
        [Column("PeriodTypeID_FK")]
        public int PeriodTypeIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime FromDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ToDate { get; set; }
        public string Remarks { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(CreatedByFk))]
        [InverseProperty(nameof(Users.Event))]
        public virtual Users CreatedByFkNavigation { get; set; }
        [ForeignKey(nameof(EventTypeIdFk))]
        [InverseProperty(nameof(Code.EventEventTypeIdFkNavigation))]
        public virtual Code EventTypeIdFkNavigation { get; set; }
        [ForeignKey(nameof(PeriodTypeIdFk))]
        [InverseProperty(nameof(Code.EventPeriodTypeIdFkNavigation))]
        public virtual Code PeriodTypeIdFkNavigation { get; set; }
        [InverseProperty("EventIdFkNavigation")]
        public virtual ICollection<EventUser> EventUser { get; set; }
        [InverseProperty("EventIdFkNavigation")]
        public virtual ICollection<EventUserLog> EventUserLog { get; set; }
        [InverseProperty("EventIdFkNavigation")]
        public virtual ICollection<NotificationEvent> NotificationEvent { get; set; }
    }
}
