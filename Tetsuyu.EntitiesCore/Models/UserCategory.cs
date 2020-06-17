using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class UserCategory
    {
        public UserCategory()
        {
            UserCategoryRole = new HashSet<UserCategoryRole>();
            UserType = new HashSet<UserType>();
        }

        [Key]
        [Column("UserCategoryID")]
        public int UserCategoryId { get; set; }
        [Required]
        [Column("UserCategory")]
        [StringLength(50)]
        public string UserCategory1 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }

        [InverseProperty("UserCategoryIdFkNavigation")]
        public virtual ICollection<UserCategoryRole> UserCategoryRole { get; set; }
        [InverseProperty("UserCategoryIdFkNavigation")]
        public virtual ICollection<UserType> UserType { get; set; }
    }
}
