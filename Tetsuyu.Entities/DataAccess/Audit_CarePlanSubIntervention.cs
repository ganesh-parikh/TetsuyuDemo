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
    
    public partial class Audit_CarePlanSubIntervention
    {
        public string AuditAction { get; set; }
        public System.DateTime ActionTime { get; set; }
        public int CarePlanSubID_FK { get; set; }
        public int InterventionID_FK { get; set; }
    }
}
