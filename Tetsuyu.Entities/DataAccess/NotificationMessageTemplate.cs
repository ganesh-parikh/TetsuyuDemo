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
    
    public partial class NotificationMessageTemplate
    {
        public int id { get; set; }
        public string notificationgroupCode { get; set; }
        public string notificationSubject { get; set; }
        public string notificationMessage { get; set; }
        public System.DateTime createdDate { get; set; }
        public Nullable<System.DateTime> updatedDate { get; set; }
    
        public virtual Type Type { get; set; }
    }
}
