using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class TaskServicesRequired
    {
        [Key]
        [Column("TaskID_FK")]
        public int TaskIdFk { get; set; }
        [Key]
        [Column("CodeID_FK")]
        public int CodeIdFk { get; set; }

        [ForeignKey(nameof(CodeIdFk))]
        [InverseProperty(nameof(Code.TaskServicesRequired))]
        public virtual Code CodeIdFkNavigation { get; set; }
        [ForeignKey(nameof(TaskIdFk))]
        [InverseProperty(nameof(Task.TaskServicesRequired))]
        public virtual Task TaskIdFkNavigation { get; set; }
    }
}
