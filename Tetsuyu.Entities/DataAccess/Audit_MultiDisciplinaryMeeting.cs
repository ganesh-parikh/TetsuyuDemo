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
    
    public partial class Audit_MultiDisciplinaryMeeting
    {
        public string AuditAction { get; set; }
        public System.DateTime ActionTime { get; set; }
        public int MultiDisciplinaryMeetingID { get; set; }
        public int PatientID_FK { get; set; }
        public string IssuesOverall { get; set; }
        public int AssignedToFollowUp { get; set; }
        public string Remarks { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
        public bool IsDeleted { get; set; }
    }
}
