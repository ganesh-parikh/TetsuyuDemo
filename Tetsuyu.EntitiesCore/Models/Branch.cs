using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class Branch
    {
        public Branch()
        {
            UserBranch = new HashSet<UserBranch>();
        }

        [Key]
        [Column("BranchID")]
        public int BranchId { get; set; }
        [Required]
        [StringLength(255)]
        public string BranchName { get; set; }
        [StringLength(255)]
        public string Address1 { get; set; }
        [StringLength(255)]
        public string Address2 { get; set; }
        [StringLength(255)]
        public string Address3 { get; set; }
        [StringLength(255)]
        public string Contact { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        [StringLength(10)]
        public string Status { get; set; }
        public bool IsSystemUsed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
        [Column("CurrencyID_FK")]
        public int? CurrencyIdFk { get; set; }

        [ForeignKey(nameof(CurrencyIdFk))]
        [InverseProperty(nameof(Code.Branch))]
        public virtual Code CurrencyIdFkNavigation { get; set; }
        [InverseProperty("BranchIdFkNavigation")]
        public virtual ICollection<UserBranch> UserBranch { get; set; }
    }
}
