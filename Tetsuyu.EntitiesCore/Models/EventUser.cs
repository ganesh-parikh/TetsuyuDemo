using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class EventUser
    {
        [Key]
        [Column("EventUserID")]
        public int EventUserId { get; set; }
        [Column("EventID_FK")]
        public int EventIdFk { get; set; }
        [Column("UserID_FK")]
        public int UserIdFk { get; set; }
        [Required]
        [StringLength(20)]
        public string UserType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(EventIdFk))]
        [InverseProperty(nameof(Event.EventUser))]
        public virtual Event EventIdFkNavigation { get; set; }
        [ForeignKey(nameof(UserIdFk))]
        [InverseProperty(nameof(Users.EventUser))]
        public virtual Users UserIdFkNavigation { get; set; }
    }
}
