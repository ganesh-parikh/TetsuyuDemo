using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_ScheduledTasks")]
    public partial class AuditScheduledTasks
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        public int ScheduleId { get; set; }
        [Required]
        [StringLength(200)]
        public string ScheduleDescription { get; set; }
        [Required]
        [StringLength(1)]
        public string PerformTask { get; set; }
        public bool Everyday { get; set; }
        public bool Weekday { get; set; }
        [Column("NDays")]
        public int Ndays { get; set; }
        [Required]
        [StringLength(10)]
        public string WeekDays { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeEnd { get; set; }
        public int Interval { get; set; }
        [Required]
        [StringLength(1)]
        public string IntervalType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NextRun { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastRun { get; set; }
        [Required]
        [StringLength(1)]
        public string Status { get; set; }
    }
}
