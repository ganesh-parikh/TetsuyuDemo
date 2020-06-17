using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_ReceiptForInvoice")]
    public partial class AuditReceiptForInvoice
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("ReceiptForInvoiceID")]
        public int ReceiptForInvoiceId { get; set; }
        [Column("ReceiptID_FK")]
        public int ReceiptIdFk { get; set; }
        [Column("BillingInvoiceID_FK")]
        public int BillingInvoiceIdFk { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amt { get; set; }
    }
}
