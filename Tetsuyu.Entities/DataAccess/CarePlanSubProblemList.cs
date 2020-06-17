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
    
    public partial class CarePlanSubProblemList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarePlanSubProblemList()
        {
            this.CarePlanSubProblemListGoals = new HashSet<CarePlanSubProblemListGoal>();
        }
    
        public int CarePlanSubProblemListID { get; set; }
        public int CarePlanSubID_FK { get; set; }
        public int ProblemListID_FK { get; set; }
        public Nullable<System.DateTime> PLReviewDate { get; set; }
        public string PLStatus { get; set; }
        public Nullable<int> PersonInChargeID_FK { get; set; }
        public Nullable<int> TypeOfGoal { get; set; }
        public string Goal { get; set; }
    
        public virtual CarePlanSub CarePlanSub { get; set; }
        public virtual ProblemList ProblemList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarePlanSubProblemListGoal> CarePlanSubProblemListGoals { get; set; }
    }
}
