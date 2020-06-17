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
    
    public partial class Audit_PatientSocialSupport
    {
        public string AuditAction { get; set; }
        public System.DateTime ActionTime { get; set; }
        public int PatientSocialSupportID { get; set; }
        public Nullable<int> PatientID_FK { get; set; }
        public Nullable<int> InitialCareAssessmentID_FK { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Nullable<int> GenderID_FK { get; set; }
        public Nullable<int> MaritalStatusID_FK { get; set; }
        public Nullable<int> RelationshipID_FK { get; set; }
        public Nullable<int> NationalityID_FK { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public Nullable<bool> NotifyEmail { get; set; }
        public Nullable<bool> NotifySMS { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<bool> NotifyPhoneCall { get; set; }
        public Nullable<bool> Spokeperson { get; set; }
        public Nullable<bool> CanLogin { get; set; }
        public Nullable<bool> BillTo { get; set; }
        public string UserType { get; set; }
    }
}