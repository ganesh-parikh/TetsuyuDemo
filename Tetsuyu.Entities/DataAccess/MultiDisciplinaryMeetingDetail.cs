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
    
    public partial class MultiDisciplinaryMeetingDetail
    {
        public int MultiDisciplinaryMeetingDetailID { get; set; }
        public int MultiDisciplinaryMeetingID_FK { get; set; }
        public int IssueCatID { get; set; }
        public string IssueTitle { get; set; }
        public string IssueContent { get; set; }
        public int ActionPlan { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual MultiDisciplinaryMeeting MultiDisciplinaryMeeting { get; set; }
    }
}