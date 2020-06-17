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
    
    public partial class Audit_CareReportSystemInfo
    {
        public string AuditAction { get; set; }
        public System.DateTime ActionTime { get; set; }
        public int CareReportSystemInfoID { get; set; }
        public Nullable<bool> IsUpdatePrimaryDoctor { get; set; }
        public Nullable<int> PrimaryDoctorUserID_FK { get; set; }
        public string PrimaryDoctorName { get; set; }
        public Nullable<bool> IsUpdateSecondaryDoctor { get; set; }
        public Nullable<int> SecondaryDoctorUserID_FK { get; set; }
        public string SecondaryDoctorName { get; set; }
        public Nullable<bool> IsUpdateKeyPerson1 { get; set; }
        public Nullable<int> KeyPerson1UserID_FK { get; set; }
        public Nullable<bool> IsUpdateKeyPerson2 { get; set; }
        public Nullable<int> KeyPerson2UserID_FK { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
        public bool IsUpdateFamily { get; set; }
    }
}