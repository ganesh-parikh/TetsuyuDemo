using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class UserLanguage
    {
        [Key]
        [Column("UserID_FK")]
        public int UserIdFk { get; set; }
        [Key]
        [Column("LanguageID_FK")]
        public int LanguageIdFk { get; set; }

        [ForeignKey(nameof(LanguageIdFk))]
        [InverseProperty(nameof(Code.UserLanguage))]
        public virtual Code LanguageIdFkNavigation { get; set; }
        [ForeignKey(nameof(UserIdFk))]
        [InverseProperty(nameof(Users.UserLanguage))]
        public virtual Users UserIdFkNavigation { get; set; }
    }
}
