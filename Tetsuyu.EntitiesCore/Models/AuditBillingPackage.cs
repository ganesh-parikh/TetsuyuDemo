using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_BillingPackage")]
    public partial class AuditBillingPackage
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("ID")]
        public int? Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        [StringLength(10)]
        public string Type { get; set; }
        public int? Session { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? TotalPrice { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? UnitPrice { get; set; }
        public int? Validity { get; set; }
        [StringLength(10)]
        public string Status { get; set; }
        public string Remarks { get; set; }
        [Column("BillingServiceID")]
        public int BillingServiceId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
    }
}
