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
    
    public partial class Audit_PatientAccessLine
    {
        public string AuditAction { get; set; }
        public System.DateTime ActionTime { get; set; }
        public int PatientAccessLineID { get; set; }
        public string AccessLine { get; set; }
        public int CareReportID_FK { get; set; }
        public System.DateTime DateOfInsertion { get; set; }
        public string Patent { get; set; }
        public string PatentReSited { get; set; }
        public Nullable<System.DateTime> PatentReSitedDate { get; set; }
        public string PatentSite { get; set; }
        public System.DateTime DateDueForChange { get; set; }
        public string AccessLineRemarks { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
    }
}