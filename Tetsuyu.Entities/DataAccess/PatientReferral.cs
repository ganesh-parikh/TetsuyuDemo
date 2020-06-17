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
    
    public partial class PatientReferral
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PatientReferral()
        {
            this.InitialCareAssessments = new HashSet<InitialCareAssessment>();
            this.Patients = new HashSet<Patient>();
            this.Codes = new HashSet<Code>();
        }
    
        public int PatientReferralID { get; set; }
        public Nullable<int> PrimaryClinicianID_FK { get; set; }
        public Nullable<int> SecondaryClinicianID_FK { get; set; }
        public Nullable<bool> PatientAwareDiagnose { get; set; }
        public Nullable<bool> FamilyAwareDiagnose { get; set; }
        public Nullable<bool> PatientAwarePrognosis { get; set; }
        public Nullable<bool> FamilyAwarePrognosis { get; set; }
        public string PatientAwareDiagnoseReason { get; set; }
        public string FamilyAwareDiagnoseReason { get; set; }
        public string PatientAwarePrognosisReason { get; set; }
        public string FamilyAwarePrognosisReason { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
        public Nullable<int> PrimaryNurseID_FK { get; set; }
        public Nullable<int> SecondaryNurseID_FK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InitialCareAssessment> InitialCareAssessments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patients { get; set; }
        public virtual PatientClinician PatientClinician { get; set; }
        public virtual PatientClinician PatientClinician1 { get; set; }
        public virtual PatientClinician PatientClinician2 { get; set; }
        public virtual PatientClinician PatientClinician3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Code> Codes { get; set; }
    }
}
