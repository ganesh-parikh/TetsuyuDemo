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
    
    public partial class ResidentAssessmentCategory
    {
        public int ResidentAssessmentCategoryID { get; set; }
        public string Category1Description { get; set; }
        public string Category1Recommendation { get; set; }
        public string Category2Description { get; set; }
        public string Category2Recommendation { get; set; }
        public string Category3Description { get; set; }
        public string Category3Recommendation { get; set; }
        public string Category4Description { get; set; }
        public string Category4Recommendation { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
    }
}
