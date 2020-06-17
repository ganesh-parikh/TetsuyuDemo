using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class EmailLog
    {
        [Key]
        public int EmailLogId { get; set; }
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
        [Column("msgFromName")]
        [StringLength(255)]
        public string MsgFromName { get; set; }
        [Column("msgFrom")]
        [StringLength(255)]
        public string MsgFrom { get; set; }
        [Column("isHtml")]
        public bool? IsHtml { get; set; }
        [Column("attachmentName")]
        [StringLength(255)]
        public string AttachmentName { get; set; }
        [Column("isSent")]
        public bool? IsSent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("smtpServerAddress")]
        [StringLength(255)]
        public string SmtpServerAddress { get; set; }
        [Column("smtpLogin")]
        [StringLength(255)]
        public string SmtpLogin { get; set; }
        [Column("smtpPassword")]
        [StringLength(255)]
        public string SmtpPassword { get; set; }
        [Column("smtpPort")]
        [StringLength(255)]
        public string SmtpPort { get; set; }
    }
}
