using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("EnquirySCM")]
    public partial class EnquiryScm
    {
        [Key]
        [Column("EnquiryConfigID_FK")]
        public int EnquiryConfigIdFk { get; set; }
        [Key]
        [Column("UserID_FK")]
        public int UserIdFk { get; set; }

        [ForeignKey(nameof(EnquiryConfigIdFk))]
        [InverseProperty(nameof(EnquiryConfig.EnquiryScm))]
        public virtual EnquiryConfig EnquiryConfigIdFkNavigation { get; set; }
        [ForeignKey(nameof(UserIdFk))]
        [InverseProperty(nameof(Users.EnquiryScm))]
        public virtual Users UserIdFkNavigation { get; set; }
    }
}
