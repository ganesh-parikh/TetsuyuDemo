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
    
    public partial class Audit_APIOrderMedication
    {
        public string AuditAction { get; set; }
        public System.DateTime ActionTime { get; set; }
        public int APIOrderMedicationID { get; set; }
        public int APIOrderID_FK { get; set; }
        public Nullable<int> MedicationID { get; set; }
        public string MedicationName { get; set; }
        public string MedicationStatus { get; set; }
        public Nullable<int> MedicationQuantity { get; set; }
        public string MedicationQuantityUnit { get; set; }
        public Nullable<int> MedicationFrequencyID { get; set; }
        public Nullable<int> MedicationFrequency { get; set; }
        public Nullable<int> MedicationPeriod { get; set; }
        public string MedicationPeriodUnit { get; set; }
        public Nullable<bool> MedicationAsNeeded { get; set; }
        public string MedicationDisplay { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> DosageID_FK { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
    }
}
