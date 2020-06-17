using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_BillingService")]
    public partial class AuditBillingService
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("ServiceID")]
        public int ServiceId { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [Column("CategoryID_FK")]
        public int CategoryIdFk { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CostPerSession { get; set; }
        public bool Weekend { get; set; }
        [Required]
        [StringLength(15)]
        public string Status { get; set; }
        [Required]
        public string Remarks { get; set; }
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
