using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_SyncWoundLog")]
    public partial class AuditSyncWoundLog
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        public int SyncLogId { get; set; }
        public int SyncBatchTs { get; set; }
        [Column("WoundID")]
        public int WoundId { get; set; }
        [Column("OffWoundID")]
        public int OffWoundId { get; set; }
        [Column("ServerPatientID")]
        public int ServerPatientId { get; set; }
        [Column("ServerWoundID")]
        public int ServerWoundId { get; set; }
        public bool SyncResult { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
    }
}
