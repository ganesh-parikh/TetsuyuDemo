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
    
    public partial class Audit_TD_WoundAssessmentFactor
    {
        public string AuditAction { get; set; }
        public System.DateTime ActionTime { get; set; }
        public int TD_WoundAssessmentID_FK { get; set; }
        public int CodeID_FK { get; set; }
    }
}
