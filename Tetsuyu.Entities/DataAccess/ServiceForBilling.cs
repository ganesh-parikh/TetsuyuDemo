//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tetsuyu.Entities.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServiceForBilling
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServiceForBilling()
        {
            this.BillingInvoiceServices = new HashSet<BillingInvoiceService>();
            this.BillingProposalServices = new HashSet<BillingProposalService>();
            this.ServiceForBillingCosts = new HashSet<ServiceForBillingCost>();
        }
    
        public int ServiceForBillingID { get; set; }
        public int CategoryID_FK { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Duration1 { get; set; }
        public string Duration2 { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
        public bool IsDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillingInvoiceService> BillingInvoiceServices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillingProposalService> BillingProposalServices { get; set; }
        public virtual Code Code { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServiceForBillingCost> ServiceForBillingCosts { get; set; }
    }
}
