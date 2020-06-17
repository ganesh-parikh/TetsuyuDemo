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
    
    public partial class BillingInvoiceService
    {
        public int BillingInvoiceServiceID { get; set; }
        public int BillingInvoiceID_FK { get; set; }
        public Nullable<int> ProposalID_FK { get; set; }
        public int ServiceID_FK { get; set; }
        public decimal UnitCost { get; set; }
        public int Session { get; set; }
        public decimal Discount { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual BillingInvoice BillingInvoice { get; set; }
        public virtual BillingProposal BillingProposal { get; set; }
        public virtual ServiceForBilling ServiceForBilling { get; set; }
    }
}
