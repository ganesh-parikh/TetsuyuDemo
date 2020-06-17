using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class ReceiptForInvoice
    {
        [Key]
        [Column("ReceiptForInvoiceID")]
        public int ReceiptForInvoiceId { get; set; }
        [Column("ReceiptID_FK")]
        public int ReceiptIdFk { get; set; }
        [Column("BillingInvoiceID_FK")]
        public int BillingInvoiceIdFk { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Amt { get; set; }

        [ForeignKey(nameof(BillingInvoiceIdFk))]
        [InverseProperty(nameof(BillingInvoice.ReceiptForInvoice))]
        public virtual BillingInvoice BillingInvoiceIdFkNavigation { get; set; }
        [ForeignKey(nameof(ReceiptIdFk))]
        [InverseProperty(nameof(Receipt.ReceiptForInvoice))]
        public virtual Receipt ReceiptIdFkNavigation { get; set; }
    }
}
