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
    
    public partial class APNSNotification
    {
        public int Id { get; set; }
        public string NotificationMessage { get; set; }
        public string NotificationTitle { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<bool> SentStatus { get; set; }
        public Nullable<bool> IsCritical { get; set; }
        public Nullable<int> TaskID { get; set; }
    }
}