using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class Role
    {
        public Role()
        {
            GroupRole = new HashSet<GroupRole>();
            UserCategoryRole = new HashSet<UserCategoryRole>();
            UserRole = new HashSet<UserRole>();
        }

        [Key]
        public int RoleId { get; set; }
        [Required]
        [StringLength(250)]
        public string RoleDescription { get; set; }
        [Required]
        [StringLength(250)]
        public string OptionText { get; set; }
        [Required]
        [StringLength(250)]
        public string OptionValue { get; set; }
        [Required]
        [StringLength(1)]
        public string OptionType { get; set; }
        public int Ordering { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }
        public bool? Active { get; set; }

        [InverseProperty("RoleIdFkNavigation")]
        public virtual ICollection<GroupRole> GroupRole { get; set; }
        [InverseProperty("RoleIdFkNavigation")]
        public virtual ICollection<UserCategoryRole> UserCategoryRole { get; set; }
        [InverseProperty("RoleIdFkNavigation")]
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
