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
    
    public partial class Audit_MailSettings
    {
        public string AuditAction { get; set; }
        public System.DateTime ActionTime { get; set; }
        public int id { get; set; }
        public string description { get; set; }
        public string msgBCC { get; set; }
        public string msgCC { get; set; }
        public string msgTo { get; set; }
        public string msgSubj { get; set; }
        public string msgBody { get; set; }
        public Nullable<bool> displayMsgTo { get; set; }
        public Nullable<bool> displayMsgCC { get; set; }
        public Nullable<bool> displayMsgBCC { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
        public bool IsDeleted { get; set; }
    }
}