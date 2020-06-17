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
    
    public partial class PatientWoundVisitClinician
    {
        public int PatientWoundVisitClinicianID { get; set; }
        public Nullable<int> PatientWoundVisitID_FK { get; set; }
        public Nullable<int> UserID_FK { get; set; }
        public Nullable<int> ExternalDoctorID_FK { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ExternalDoctor ExternalDoctor { get; set; }
        public virtual PatientWoundVisit PatientWoundVisit { get; set; }
        public virtual User User { get; set; }
    }
}