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
    
    public partial class BillingPackageRequest
    {
        public int PackageRequestID { get; set; }
        public string PackageRequestNo { get; set; }
        public int PatientID_FK { get; set; }
        public string PatientName { get; set; }
        public string SendBillTo { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public bool Discount { get; set; }
        public string DiscountType { get; set; }
        public decimal DiscountAmt { get; set; }
        public decimal DiscountPercentage { get; set; }
        public string Remarks { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
        public bool IsDeleted { get; set; }
        public string BillingAddress1 { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingAddress3 { get; set; }
        public string BillingPostalCode { get; set; }
        public decimal TotalPackageAmount { get; set; }
        public string Email { get; set; }
        public string PackageList { get; set; }
    }
}