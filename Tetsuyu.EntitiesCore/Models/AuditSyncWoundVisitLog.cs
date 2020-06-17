using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_SyncWoundVisitLog")]
    public partial class AuditSyncWoundVisitLog
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        public int SyncLogId { get; set; }
        public int SyncBatchTs { get; set; }
        [Column("OffWoundVisitID")]
        public int OffWoundVisitId { get; set; }
        [Column("ServerWoundID")]
        public int ServerWoundId { get; set; }
        [Column("ServerWoundVisitID")]
        public int ServerWoundVisitId { get; set; }
        public bool SyncResult { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
    }
}
