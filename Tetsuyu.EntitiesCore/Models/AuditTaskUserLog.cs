using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_TaskUserLog")]
    public partial class AuditTaskUserLog
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
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
    }
}
