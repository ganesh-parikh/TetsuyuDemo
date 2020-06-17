using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class TaskSpecificDate
    {
        [Key]
        [Column("TaskSpecificDateID")]
        public int TaskSpecificDateId { get; set; }
        [Column("TaskID_FK")]
        public int TaskIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TaskDate { get; set; }
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
        [InverseProperty(nameof(Task.TaskSpecificDate))]
        public virtual Task TaskIdFkNavigation { get; set; }
    }
}
