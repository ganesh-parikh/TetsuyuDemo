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
    
    public partial class Otp
    {
        public int OtpId { get; set; }
        public int UserId { get; set; }
        public string Password { get; set; }
        public System.DateTime CreatedDate { get; set; }
    }
}
