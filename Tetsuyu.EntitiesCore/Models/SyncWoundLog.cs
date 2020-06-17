using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class SyncWoundLog
    {
        [Key]
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
