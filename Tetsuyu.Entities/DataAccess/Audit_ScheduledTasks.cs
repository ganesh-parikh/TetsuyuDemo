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
    
    public partial class Audit_ScheduledTasks
    {
        public string AuditAction { get; set; }
        public System.DateTime ActionTime { get; set; }
        public int ScheduleId { get; set; }
        public string ScheduleDescription { get; set; }
        public string PerformTask { get; set; }
        public bool Everyday { get; set; }
        public bool Weekday { get; set; }
        public int NDays { get; set; }
        public string WeekDays { get; set; }
        public Nullable<System.DateTime> TimeStart { get; set; }
        public Nullable<System.DateTime> TimeEnd { get; set; }
        public int Interval { get; set; }
        public string IntervalType { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> NextRun { get; set; }
        public Nullable<System.DateTime> LastRun { get; set; }
        public string Status { get; set; }
    }
}
