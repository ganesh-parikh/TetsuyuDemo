using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class BillingInvoiceConsumable
    {
        [Key]
        [Column("BillingInvoiceConsumableID")]
        public int BillingInvoiceConsumableId { get; set; }
        [Column("BillingInvoiceID_FK")]
        public int BillingInvoiceIdFk { get; set; }
        [Column("ItemID_FK")]
        public int ItemIdFk { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal UnitPrice { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(BillingInvoiceIdFk))]
        [InverseProperty(nameof(BillingInvoice.BillingInvoiceConsumable))]
        public virtual BillingInvoice BillingInvoiceIdFkNavigation { get; set; }
        [ForeignKey(nameof(ItemIdFk))]
        [InverseProperty(nameof(Item.BillingInvoiceConsumable))]
        public virtual Item ItemIdFkNavigation { get; set; }
    }
}
