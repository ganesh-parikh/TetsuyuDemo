using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class UserBranch
    {
        [Key]
        [Column("UserID_FK")]
        public int UserIdFk { get; set; }
        [Key]
        [Column("BranchID_FK")]
        public int BranchIdFk { get; set; }

        [ForeignKey(nameof(BranchIdFk))]
        [InverseProperty(nameof(Branch.UserBranch))]
        public virtual Branch BranchIdFkNavigation { get; set; }
        [ForeignKey(nameof(UserIdFk))]
        [InverseProperty(nameof(Users.UserBranch))]
        public virtual Users UserIdFkNavigation { get; set; }
    }
}
