using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_EnquiryServicesRequired")]
    public partial class AuditEnquiryServicesRequired
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("EnquiryID_FK")]
        public int EnquiryIdFk { get; set; }
        [Column("CodeID_FK")]
        public int CodeIdFk { get; set; }
    }
}
