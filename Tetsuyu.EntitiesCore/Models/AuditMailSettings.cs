using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_MailSettings")]
    public partial class AuditMailSettings
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("description")]
        [StringLength(255)]
        public string Description { get; set; }
        [Column("msgBCC")]
        [StringLength(255)]
        public string MsgBcc { get; set; }
        [Column("msgCC")]
        [StringLength(255)]
        public string MsgCc { get; set; }
        [Column("msgTo")]
        [StringLength(255)]
        public string MsgTo { get; set; }
        [Column("msgSubj")]
        public string MsgSubj { get; set; }
        [Column("msgBody")]
        public string MsgBody { get; set; }
        [Column("displayMsgTo")]
        public bool? DisplayMsgTo { get; set; }
        [Column("displayMsgCC")]
        public bool? DisplayMsgCc { get; set; }
        [Column("displayMsgBCC")]
        public bool? DisplayMsgBcc { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
    }
}
