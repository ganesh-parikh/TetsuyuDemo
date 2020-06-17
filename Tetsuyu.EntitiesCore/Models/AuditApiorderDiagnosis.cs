using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_APIOrderDiagnosis")]
    public partial class AuditApiorderDiagnosis
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("APIOrderDiagnosisID")]
        public int ApiorderDiagnosisId { get; set; }
        [Column("APIOrderID_FK")]
        public int ApiorderIdFk { get; set; }
        [StringLength(255)]
        public string DiagnosisType { get; set; }
        [StringLength(255)]
        public string DiagnosisDesc { get; set; }
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
