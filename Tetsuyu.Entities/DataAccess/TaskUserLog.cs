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
    
    public partial class TaskUserLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaskUserLog()
        {
            this.TaskUserLogAttachments = new HashSet<TaskUserLogAttachment>();
        }
    
        public int TaskUserLogID { get; set; }
        public int TaskID_FK { get; set; }
        public int UserID_FK { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Status { get; set; }
        public string FailReason { get; set; }
        public Nullable<System.DateTime> StatusDate { get; set; }
        public Nullable<bool> HideDashboard { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy_FK { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> ModifiedBy_FK { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Task Task { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskUserLogAttachment> TaskUserLogAttachments { get; set; }
    }
}
