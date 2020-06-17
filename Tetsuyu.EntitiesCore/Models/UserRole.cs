using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class UserRole
    {
        [Key]
        [Column("UserId_FK")]
        public int UserIdFk { get; set; }
        [Key]
        [Column("RoleId_FK")]
        public int RoleIdFk { get; set; }
        [Required]
        [StringLength(50)]
        public string Role { get; set; }

        [ForeignKey(nameof(RoleIdFk))]
        [InverseProperty("UserRole")]
        public virtual Role RoleIdFkNavigation { get; set; }
        [ForeignKey(nameof(UserIdFk))]
        [InverseProperty(nameof(Users.UserRole))]
        public virtual Users UserIdFkNavigation { get; set; }
    }
}
