using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class UserCategoryRole
    {
        [Key]
        [Column("UserCategoryID_FK")]
        public int UserCategoryIdFk { get; set; }
        [Key]
        [Column("RoleID_FK")]
        public int RoleIdFk { get; set; }
        [Required]
        [StringLength(50)]
        public string Role { get; set; }

        [ForeignKey(nameof(RoleIdFk))]
        [InverseProperty("UserCategoryRole")]
        public virtual Role RoleIdFkNavigation { get; set; }
        [ForeignKey(nameof(UserCategoryIdFk))]
        [InverseProperty(nameof(UserCategory.UserCategoryRole))]
        public virtual UserCategory UserCategoryIdFkNavigation { get; set; }
    }
}
