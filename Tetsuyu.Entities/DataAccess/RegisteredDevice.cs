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
    
    public partial class RegisteredDevice
    {
        public int DeviceID { get; set; }
        public Nullable<int> DeviceType { get; set; }
        public string DeviceToken { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}