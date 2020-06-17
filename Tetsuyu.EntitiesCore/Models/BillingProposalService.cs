using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class BillingProposalService
    {
        [Key]
        [Column("BillingProposalServiceID")]
        public int BillingProposalServiceId { get; set; }
        [Column("BillingProposalID_FK")]
        public int BillingProposalIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EndDate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal UnitCost { get; set; }
        [StringLength(50)]
        public string Duration1 { get; set; }
        [StringLength(50)]
        public string Duration2 { get; set; }
        public string ServiceDescription { get; set; }
        public int Visit { get; set; }
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
        public int SessionUsed { get; set; }
        [Column("ServiceID_FK")]
        public int ServiceIdFk { get; set; }

        [ForeignKey(nameof(BillingProposalIdFk))]
        [InverseProperty(nameof(BillingProposal.BillingProposalService))]
        public virtual BillingProposal BillingProposalIdFkNavigation { get; set; }
        [ForeignKey(nameof(ServiceIdFk))]
        [InverseProperty(nameof(ServiceForBilling.BillingProposalService))]
        public virtual ServiceForBilling ServiceIdFkNavigation { get; set; }
    }
}
