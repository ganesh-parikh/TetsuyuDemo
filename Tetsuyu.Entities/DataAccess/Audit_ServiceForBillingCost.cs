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
    
    public partial class Audit_ServiceForBillingCost
    {
        public string AuditAction { get; set; }
        public System.DateTime ActionTime { get; set; }
        public int ServiceForBillingCostID { get; set; }
        public int ServiceForBillingID_FK { get; set; }
        public int CurrencyID_FK { get; set; }
        public decimal UnitCost { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
        public bool IsDeleted { get; set; }
    }
}
