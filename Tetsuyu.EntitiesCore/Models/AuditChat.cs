using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_Chat")]
    public partial class AuditChat
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("ChatID")]
        public int ChatId { get; set; }
        public string Comment { get; set; }
        [StringLength(255)]
        public string Attachment { get; set; }
        [Column("Attachment_Physical")]
        [StringLength(50)]
        public string AttachmentPhysical { get; set; }
        [Column("ParentID_FK")]
        public int? ParentIdFk { get; set; }
        [Column("PatientID_FK")]
        public int? PatientIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int CreatedByFk { get; set; }
        public bool IsDeleted { get; set; }
        public bool? Family { get; set; }
    }
}
