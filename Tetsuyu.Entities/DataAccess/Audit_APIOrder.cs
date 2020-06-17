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
    
    public partial class Audit_APIOrder
    {
        public string AuditAction { get; set; }
        public System.DateTime ActionTime { get; set; }
        public int APIOrderId { get; set; }
        public string OrderID { get; set; }
        public string ResourceType { get; set; }
        public Nullable<int> PatientID { get; set; }
        public string PatientNRIC { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public Nullable<int> OrderedByID { get; set; }
        public string OrderedByName { get; set; }
        public string OrderedByInstitution { get; set; }
        public Nullable<int> OrderedByInstitutionID { get; set; }
        public string DoctorMCR { get; set; }
        public Nullable<int> AcceptedBy { get; set; }
        public string AcceptedByName { get; set; }
        public string AcceptedInstitutionName { get; set; }
        public Nullable<int> AcceptedInstitutionID { get; set; }
        public string Clinicalsynopsis { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
        public bool IsDeleted { get; set; }
    }
}