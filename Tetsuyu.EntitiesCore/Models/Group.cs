using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class Group
    {
        public Group()
        {
            GroupRole = new HashSet<GroupRole>();
        }

        [Key]
        public int GroupId { get; set; }
        [Required]
        [StringLength(100)]
        public string GroupName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }

        [InverseProperty("GroupIdFkNavigation")]
        public virtual ICollection<GroupRole> GroupRole { get; set; }
    }
}
