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
    
    public partial class PatientMedicalHistory
    {
        public int PatientMedicalHistoryID { get; set; }
        public Nullable<int> PatientID_FK { get; set; }
        public Nullable<int> InitialCareAssessmentID_FK { get; set; }
        public Nullable<int> ClinicianID_FK { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> MedicalStatusID_FK { get; set; }
    
        public virtual Code Code { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual PatientClinician PatientClinician { get; set; }
    }
}
