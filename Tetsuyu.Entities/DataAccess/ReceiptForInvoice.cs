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
    
    public partial class ReceiptForInvoice
    {
        public int ReceiptForInvoiceID { get; set; }
        public int ReceiptID_FK { get; set; }
        public int BillingInvoiceID_FK { get; set; }
        public decimal Amt { get; set; }
    
        public virtual BillingInvoice BillingInvoice { get; set; }
        public virtual Receipt Receipt { get; set; }
    }
}