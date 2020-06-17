using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class EnquiryEscPerson
    {
        [Key]
        [Column("EnquiryConfigID")]
        public int EnquiryConfigId { get; set; }
        [Key]
        [Column("UserID_FK")]
        public int UserIdFk { get; set; }

        [ForeignKey(nameof(EnquiryConfigId))]
        [InverseProperty("EnquiryEscPerson")]
        public virtual EnquiryConfig EnquiryConfig { get; set; }
        [ForeignKey(nameof(UserIdFk))]
        [InverseProperty(nameof(Users.EnquiryEscPerson))]
        public virtual Users UserIdFkNavigation { get; set; }
    }
}
