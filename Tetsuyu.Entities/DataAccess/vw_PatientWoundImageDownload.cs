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
    
    public partial class vw_PatientWoundImageDownload
    {
        public string NewImageName { get; set; }
        public int PatientID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int PatientWoundID { get; set; }
        public string LocationOfWound { get; set; }
        public string Site { get; set; }
        public int PatientWoundVisitID { get; set; }
        public string ImageDate { get; set; }
        public Nullable<System.DateTime> VisitDate { get; set; }
        public string ImageUpload { get; set; }
    }
}