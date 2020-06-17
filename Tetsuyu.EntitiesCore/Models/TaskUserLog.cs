using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class TaskUserLog
    {
        public TaskUserLog()
        {
            TaskUserLogAttachment = new HashSet<TaskUserLogAttachment>();
        }

        [Key]
        [Column("TaskUserLogID")]
        public int TaskUserLogId { get; set; }
        [Column("TaskID_FK")]
        public int TaskIdFk { get; set; }
        [Column("UserID_FK")]
        public int UserIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EndDate { get; set; }
        [StringLength(20)]
        public string Status { get; set; }
        public string FailReason { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StatusDate { get; set; }
        public bool? HideDashboard { get; set; }
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
        [InverseProperty(nameof(Task.TaskUserLog))]
        public virtual Task TaskIdFkNavigation { get; set; }
        [ForeignKey(nameof(UserIdFk))]
        [InverseProperty(nameof(Users.TaskUserLog))]
        public virtual Users UserIdFkNavigation { get; set; }
        [InverseProperty("TaskUserLogIdFkNavigation")]
        public virtual ICollection<TaskUserLogAttachment> TaskUserLogAttachment { get; set; }
    }
}
