using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class UserSkillset
    {
        [Key]
        [Column("UserID_FK")]
        public int UserIdFk { get; set; }
        [Key]
        [Column("CodeID_FK")]
        public int CodeIdFk { get; set; }

        [ForeignKey(nameof(CodeIdFk))]
        [InverseProperty(nameof(Code.UserSkillset))]
        public virtual Code CodeIdFkNavigation { get; set; }
        [ForeignKey(nameof(UserIdFk))]
        [InverseProperty(nameof(Users.UserSkillset))]
        public virtual Users UserIdFkNavigation { get; set; }
    }
}
