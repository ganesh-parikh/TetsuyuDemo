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
    
    public partial class Audit_Disease
    {
        public string AuditAction { get; set; }
        public System.DateTime ActionTime { get; set; }
        public int DiseaseID { get; set; }
        public string DiseaseName { get; set; }
        public int SystemID_FK { get; set; }
        public bool IsAdditionalInfo { get; set; }
        public bool IsSuggestPalliativeCare { get; set; }
        public bool IsSystemUsed { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
        public string AdditionalInfo { get; set; }
        public string DiseaseCode { get; set; }
    }
}