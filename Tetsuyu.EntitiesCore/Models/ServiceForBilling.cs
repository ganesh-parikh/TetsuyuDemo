using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class ServiceForBilling
    {
        public ServiceForBilling()
        {
            BillingInvoiceService = new HashSet<BillingInvoiceService>();
            BillingProposalService = new HashSet<BillingProposalService>();
            ServiceForBillingCost = new HashSet<ServiceForBillingCost>();
        }

        [Key]
        [Column("ServiceForBillingID")]
        public int ServiceForBillingId { get; set; }
        [Column("CategoryID_FK")]
        public int CategoryIdFk { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [StringLength(50)]
        public string Duration1 { get; set; }
        [StringLength(50)]
        public string Duration2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(CategoryIdFk))]
        [InverseProperty(nameof(Code.ServiceForBilling))]
        public virtual Code CategoryIdFkNavigation { get; set; }
        [InverseProperty("ServiceIdFkNavigation")]
        public virtual ICollection<BillingInvoiceService> BillingInvoiceService { get; set; }
        [InverseProperty("ServiceIdFkNavigation")]
        public virtual ICollection<BillingProposalService> BillingProposalService { get; set; }
        [InverseProperty("ServiceForBillingIdFkNavigation")]
        public virtual ICollection<ServiceForBillingCost> ServiceForBillingCost { get; set; }
    }
}
