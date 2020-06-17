using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class Chat
    {
        public Chat()
        {
            InverseParentIdFkNavigation = new HashSet<Chat>();
            NotificationChat = new HashSet<NotificationChat>();
        }

        [Key]
        [Column("ChatID")]
        public int ChatId { get; set; }
        public string Comment { get; set; }
        [StringLength(255)]
        public string Attachment { get; set; }
        [Column("Attachment_Physical")]
        [StringLength(50)]
        public string AttachmentPhysical { get; set; }
        [Column("ParentID_FK")]
        public int? ParentIdFk { get; set; }
        [Column("PatientID_FK")]
        public int? PatientIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int CreatedByFk { get; set; }
        public bool IsDeleted { get; set; }
        public bool? Family { get; set; }

        [ForeignKey(nameof(CreatedByFk))]
        [InverseProperty(nameof(Users.Chat))]
        public virtual Users CreatedByFkNavigation { get; set; }
        [ForeignKey(nameof(ParentIdFk))]
        [InverseProperty(nameof(Chat.InverseParentIdFkNavigation))]
        public virtual Chat ParentIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientIdFk))]
        [InverseProperty(nameof(Patient.Chat))]
        public virtual Patient PatientIdFkNavigation { get; set; }
        [InverseProperty(nameof(Chat.ParentIdFkNavigation))]
        public virtual ICollection<Chat> InverseParentIdFkNavigation { get; set; }
        [InverseProperty("ChatIdFkNavigation")]
        public virtual ICollection<NotificationChat> NotificationChat { get; set; }
    }
}
