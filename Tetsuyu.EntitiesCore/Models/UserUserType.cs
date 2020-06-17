using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class UserUserType
    {
        [Key]
        [Column("UserID_FK")]
        public int UserIdFk { get; set; }
        [Key]
        [Column("UserTypeID_FK")]
        public int UserTypeIdFk { get; set; }

        [ForeignKey(nameof(UserIdFk))]
        [InverseProperty(nameof(Users.UserUserType))]
        public virtual Users UserIdFkNavigation { get; set; }
        [ForeignKey(nameof(UserTypeIdFk))]
        [InverseProperty(nameof(UserType.UserUserType))]
        public virtual UserType UserTypeIdFkNavigation { get; set; }
    }
}
