using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class TeleconsultationReport
    {
        [Key]
        [Column("TeleReportID")]
        public int TeleReportId { get; set; }
        public int MediaType { get; set; }
        [Column("TaskID_FK")]
        public int TaskIdFk { get; set; }
        [Column("PatientID_FK")]
        public int PatientIdFk { get; set; }
        [Required]
        public string Memo { get; set; }
        [StringLength(15)]
        public string Status { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ModifiedDate { get; set; }
    }
}
