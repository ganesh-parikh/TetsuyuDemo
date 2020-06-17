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
    
    public partial class CarePlan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarePlan()
        {
            this.CarePlanSubs = new HashSet<CarePlanSub>();
            this.CareReports = new HashSet<CareReport>();
        }
    
        public int CarePlanID { get; set; }
        public Nullable<int> PatientID_FK { get; set; }
        public Nullable<int> DiagnosisID_FK { get; set; }
        public Nullable<int> CarePlanStatusID_FK { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> InitialCareAssessmentID_FK { get; set; }
        public Nullable<int> CarePlanDetailID_FK { get; set; }
        public string CarePlanName { get; set; }
        public Nullable<bool> IsClosed { get; set; }
        public Nullable<int> PersonInCharge { get; set; }
        public string CarePlanType { get; set; }
        public string Remark { get; set; }
    
        public virtual CarePlanStatu CarePlanStatu { get; set; }
        public virtual Diagnosi Diagnosi { get; set; }
        public virtual Patient Patient { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarePlanSub> CarePlanSubs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CareReport> CareReports { get; set; }
    }
}
