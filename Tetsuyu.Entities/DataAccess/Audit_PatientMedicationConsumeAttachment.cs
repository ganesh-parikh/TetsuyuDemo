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
    
    public partial class Audit_PatientMedicationConsumeAttachment
    {
        public string AuditAction { get; set; }
        public System.DateTime ActionTime { get; set; }
        public int PatientMedicationConsumeAttachmentID { get; set; }
        public int PatientMedicationConsumeID_FK { get; set; }
        public string Filename { get; set; }
        public string Physical { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<bool> IsEndDate { get; set; }
    }
}