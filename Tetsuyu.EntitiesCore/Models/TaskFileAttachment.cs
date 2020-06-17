using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class TaskFileAttachment
    {
        [Key]
        [Column("FileAttachmentID")]
        public int FileAttachmentId { get; set; }
        [Column("TaskID_FK")]
        public int TaskIdFk { get; set; }
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

        [ForeignKey(nameof(TaskIdFk))]
        [InverseProperty(nameof(Task.TaskFileAttachment))]
        public virtual Task TaskIdFkNavigation { get; set; }
    }
}
