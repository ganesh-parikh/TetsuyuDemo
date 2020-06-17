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
    
    public partial class Audit_PatientNutrition
    {
        public string AuditAction { get; set; }
        public System.DateTime ActionTime { get; set; }
        public int PatientNutritionID { get; set; }
        public string EatingAndSwallowing { get; set; }
        public string EatingAndSwallowingTypeOfTubeFeeding { get; set; }
        public string EatingAndSwallowingTypeOfTube { get; set; }
        public string EatingAndSwallowingSize { get; set; }
        public Nullable<System.DateTime> EatingAndSwallowingDateInserted { get; set; }
        public Nullable<System.DateTime> EatingAndSwallowingDateDue { get; set; }
        public string Diet { get; set; }
        public string Appetite { get; set; }
        public string FluidConsistency { get; set; }
        public Nullable<decimal> FluidRestrictionMLSPerDay { get; set; }
        public Nullable<bool> ReviewedBySpeechTherapist { get; set; }
        public Nullable<bool> ReferralToSpeechTherapist { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
        public string Enteralfeeding { get; set; }
        public string SizeofPEGJtube { get; set; }
        public string IVtherapyStateType { get; set; }
        public Nullable<bool> SwallowingIssues { get; set; }
        public Nullable<bool> DiagnosedDysphasia { get; set; }
        public Nullable<bool> IsFIsluidRestriction { get; set; }
        public Nullable<bool> IVtherapy { get; set; }
        public Nullable<decimal> IVtherapyMLSPerDay { get; set; }
        public Nullable<decimal> MilkFeedAmt { get; set; }
        public Nullable<decimal> WaterPerDay { get; set; }
        public Nullable<System.DateTime> DiagnosedDysphasiaLastReviewDate { get; set; }
    }
}