using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class Types
    {
        public Types()
        {
            ApiaccessKey = new HashSet<ApiaccessKey>();
            InverseParentCodeNavigation = new HashSet<Types>();
            NotificationMessageTemplates = new HashSet<NotificationMessageTemplates>();
            Notifications = new HashSet<Notifications>();
        }

        [Key]
        [Column("code")]
        [StringLength(100)]
        public string Code { get; set; }
        [Required]
        [Column("codeValue")]
        [StringLength(200)]
        public string CodeValue { get; set; }
        [Column("parentCode")]
        [StringLength(100)]
        public string ParentCode { get; set; }
        [Column("ordering")]
        public int Ordering { get; set; }
        [Column("created", TypeName = "datetime")]
        public DateTime Created { get; set; }
        [Column("updated", TypeName = "datetime")]
        public DateTime? Updated { get; set; }

        [ForeignKey(nameof(ParentCode))]
        [InverseProperty(nameof(Types.InverseParentCodeNavigation))]
        public virtual Types ParentCodeNavigation { get; set; }
        [InverseProperty("TokenCodeNavigation")]
        public virtual ICollection<ApiaccessKey> ApiaccessKey { get; set; }
        [InverseProperty(nameof(Types.ParentCodeNavigation))]
        public virtual ICollection<Types> InverseParentCodeNavigation { get; set; }
        [InverseProperty("NotificationgroupCodeNavigation")]
        public virtual ICollection<NotificationMessageTemplates> NotificationMessageTemplates { get; set; }
        [InverseProperty("NotificationTypeCodeNavigation")]
        public virtual ICollection<Notifications> Notifications { get; set; }
    }
}
