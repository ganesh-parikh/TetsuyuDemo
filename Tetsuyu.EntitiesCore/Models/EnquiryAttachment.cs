﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class EnquiryAttachment
    {
        [Key]
        [Column("EnquiryAttachmentID")]
        public int EnquiryAttachmentId { get; set; }
        [Column("EnquiryID_FK")]
        public int EnquiryIdFk { get; set; }
        [StringLength(255)]
        public string Filename { get; set; }
        [StringLength(50)]
        public string Physical { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
        [StringLength(50)]
        public string Type { get; set; }

        [ForeignKey(nameof(EnquiryIdFk))]
        [InverseProperty(nameof(Enquiry.EnquiryAttachment))]
        public virtual Enquiry EnquiryIdFkNavigation { get; set; }
    }
}
