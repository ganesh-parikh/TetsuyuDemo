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
    
    public partial class Audit_TeleconsultationRecording
    {
        public string AuditAction { get; set; }
        public System.DateTime ActionTime { get; set; }
        public int RecordingID { get; set; }
        public int RecordingType { get; set; }
        public int PatientID_FK { get; set; }
        public string Sid { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
    }
}
