using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class BillingInvoiceService
    {
        [Key]
        [Column("BillingInvoiceServiceID")]
        public int BillingInvoiceServiceId { get; set; }
        [Column("BillingInvoiceID_FK")]
        public int BillingInvoiceIdFk { get; set; }
        [Column("ProposalID_FK")]
        public int? ProposalIdFk { get; set; }
        [Column("ServiceID_FK")]
        public int ServiceIdFk { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal UnitCost { get; set; }
        public int Session { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Discount { get; set; }
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
        [InverseProperty(nameof(BillingInvoice.BillingInvoiceService))]
        public virtual BillingInvoice BillingInvoiceIdFkNavigation { get; set; }
        [ForeignKey(nameof(ProposalIdFk))]
        [InverseProperty(nameof(BillingProposal.BillingInvoiceService))]
        public virtual BillingProposal ProposalIdFkNavigation { get; set; }
        [ForeignKey(nameof(ServiceIdFk))]
        [InverseProperty(nameof(ServiceForBilling.BillingInvoiceService))]
        public virtual ServiceForBilling ServiceIdFkNavigation { get; set; }
    }
}
