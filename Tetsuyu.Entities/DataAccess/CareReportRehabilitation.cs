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
    
    public partial class CareReportRehabilitation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CareReportRehabilitation()
        {
            this.CareReports = new HashSet<CareReport>();
        }
    
        public int CareReportRehabilitationID { get; set; }
        public Nullable<bool> IsADLAssistance { get; set; }
        public string ADLAssistanceType { get; set; }
        public string Bounded { get; set; }
        public Nullable<int> NoOfTimesTurned { get; set; }
        public Nullable<int> NoOfSatOutOfBed { get; set; }
        public Nullable<bool> IsDVTPrevention { get; set; }
        public string DVTType { get; set; }
        public Nullable<bool> RequirePhysioTherapist { get; set; }
        public Nullable<int> VisitForPhysioTherapist { get; set; }
        public Nullable<bool> RequireOccupationTherapist { get; set; }
        public Nullable<int> VisitForOccupationTherapist { get; set; }
        public Nullable<bool> RequireSpeechTherapist { get; set; }
        public Nullable<int> VisitForSpeechTherapist { get; set; }
        public Nullable<bool> RequireWalkingAid { get; set; }
        public string WalkingAidType { get; set; }
        public Nullable<bool> IsUpperLimbStrengthLeft { get; set; }
        public Nullable<bool> IsUpperLimbStrengthRight { get; set; }
        public Nullable<int> UpperLimbStrengthLeft { get; set; }
        public Nullable<int> UpperLimbStrengthRight { get; set; }
        public Nullable<bool> IsLowerLimbStrengthLeft { get; set; }
        public Nullable<bool> IsLowerLimbStrengthRight { get; set; }
        public Nullable<int> LowerLimbStrengthLeft { get; set; }
        public Nullable<int> LowerLimbStrengthRight { get; set; }
        public string RehabilitationRemarks { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CareReport> CareReports { get; set; }
    }
}
