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
    
    public partial class Audit_CarePlanSubProblemList
    {
        public string AuditAction { get; set; }
        public System.DateTime ActionTime { get; set; }
        public int CarePlanSubProblemListID { get; set; }
        public int CarePlanSubID_FK { get; set; }
        public int ProblemListID_FK { get; set; }
        public Nullable<System.DateTime> PLReviewDate { get; set; }
        public string PLStatus { get; set; }
        public Nullable<int> PersonInChargeID_FK { get; set; }
        public Nullable<int> TypeOfGoal { get; set; }
        public string Goal { get; set; }
    }
}
