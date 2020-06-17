using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class TaskUserLogAttachment
    {
        [Key]
        [Column("FileAttachmentID")]
        public int FileAttachmentId { get; set; }
        [Column("TaskUserLogID_FK")]
        public int TaskUserLogIdFk { get; set; }
        [StringLength(50)]
        public string FileName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(TaskUserLogIdFk))]
        [InverseProperty(nameof(TaskUserLog.TaskUserLogAttachment))]
        public virtual TaskUserLog TaskUserLogIdFkNavigation { get; set; }
    }
}
