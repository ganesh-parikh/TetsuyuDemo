using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class SyncPatientLog
    {
        [Key]
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
