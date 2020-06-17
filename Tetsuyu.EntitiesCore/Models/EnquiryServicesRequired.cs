using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class EnquiryServicesRequired
    {
        [Key]
        [Column("EnquiryID_FK")]
        public int EnquiryIdFk { get; set; }
        [Key]
        [Column("CodeID_FK")]
        public int CodeIdFk { get; set; }

        [ForeignKey(nameof(CodeIdFk))]
        [InverseProperty(nameof(Code.EnquiryServicesRequired))]
        public virtual Code CodeIdFkNavigation { get; set; }
        [ForeignKey(nameof(EnquiryIdFk))]
        [InverseProperty(nameof(Enquiry.EnquiryServicesRequired))]
        public virtual Enquiry EnquiryIdFkNavigation { get; set; }
    }
}
