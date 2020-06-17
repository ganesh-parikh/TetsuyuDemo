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
    
    public partial class CarePlanSubProblemListGoal
    {
        public int CarePlanSubProblemListGoalID { get; set; }
        public int CarePlanSubProblemListID_FK { get; set; }
        public string Goal { get; set; }
        public Nullable<int> Action { get; set; }
        public Nullable<int> ScoreTypeID { get; set; }
        public Nullable<int> OperatorID { get; set; }
        public Nullable<decimal> Score1 { get; set; }
        public Nullable<decimal> Score2 { get; set; }
        public Nullable<int> ProblemListGoalID_FK { get; set; }
    
        public virtual CarePlanSubProblemList CarePlanSubProblemList { get; set; }
        public virtual Code Code { get; set; }
        public virtual ProblemListGoal ProblemListGoal { get; set; }
        public virtual Code Code1 { get; set; }
    }
}
