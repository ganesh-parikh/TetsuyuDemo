using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_SyncPatientLog")]
    public partial class AuditSyncPatientLog
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        public int SyncLogId { get; set; }
        public int SyncBatchTs { get; set; }
        [Column("PatientID")]
        public int PatientId { get; set; }
        [Column("OffPatientID")]
        public int OffPatientId { get; set; }
        [Column("ServerPatientID")]
        public int? ServerPatientId { get; set; }
        public bool SyncResult { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
    }
}
