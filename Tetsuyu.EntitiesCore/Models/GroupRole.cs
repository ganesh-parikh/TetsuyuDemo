using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class GroupRole
    {
        [Key]
        [Column("GroupId_FK")]
        public int GroupIdFk { get; set; }
        [Key]
        [Column("RoleId_FK")]
        public int RoleIdFk { get; set; }
        [Required]
        [StringLength(50)]
        public string Role { get; set; }

        [ForeignKey(nameof(GroupIdFk))]
        [InverseProperty(nameof(Group.GroupRole))]
        public virtual Group GroupIdFkNavigation { get; set; }
        [ForeignKey(nameof(RoleIdFk))]
        [InverseProperty("GroupRole")]
        public virtual Role RoleIdFkNavigation { get; set; }
    }
}
