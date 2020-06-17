using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class ServiceForBillingCost
    {
        [Key]
        [Column("ServiceForBillingCostID")]
        public int ServiceForBillingCostId { get; set; }
        [Column("ServiceForBillingID_FK")]
        public int ServiceForBillingIdFk { get; set; }
        [Column("CurrencyID_FK")]
        public int CurrencyIdFk { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal UnitCost { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(CurrencyIdFk))]
        [InverseProperty(nameof(Code.ServiceForBillingCost))]
        public virtual Code CurrencyIdFkNavigation { get; set; }
        [ForeignKey(nameof(ServiceForBillingIdFk))]
        [InverseProperty(nameof(ServiceForBilling.ServiceForBillingCost))]
        public virtual ServiceForBilling ServiceForBillingIdFkNavigation { get; set; }
    }
}
