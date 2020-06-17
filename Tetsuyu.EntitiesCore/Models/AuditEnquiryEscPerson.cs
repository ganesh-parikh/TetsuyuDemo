using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_EnquiryEscPerson")]
    public partial class AuditEnquiryEscPerson
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("EnquiryConfigID")]
        public int EnquiryConfigId { get; set; }
        [Column("UserID_FK")]
        public int UserIdFk { get; set; }
    }
}
