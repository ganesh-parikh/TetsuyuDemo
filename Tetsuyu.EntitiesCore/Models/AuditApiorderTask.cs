using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_APIOrderTask")]
    public partial class AuditApiorderTask
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("APIOrderTaskID")]
        public int ApiorderTaskId { get; set; }
        [Column("APIOrderID_FK")]
        public int ApiorderIdFk { get; set; }
        [Column("TaskID")]
        public int? TaskId { get; set; }
        [StringLength(255)]
        public string TaskName { get; set; }
        [Column("TaskTypeID")]
        public int? TaskTypeId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TaskStartDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TaskEndDateTime { get; set; }
        [Column("TaskFrequencyID")]
        public int? TaskFrequencyId { get; set; }
        public int? TaskFrequency { get; set; }
        public int? TaskPeriod { get; set; }
        [StringLength(60)]
        public string TaskPeriodUnit { get; set; }
        [StringLength(255)]
        public string TaskDisplay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
    }
}
