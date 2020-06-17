using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_Task")]
    public partial class AuditTask
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("TaskID")]
        public int TaskId { get; set; }
        [Column("ActionTypeID_FK")]
        public int ActionTypeIdFk { get; set; }
        [Column("PatientID_FK")]
        public int? PatientIdFk { get; set; }
        [Column("InitialCareAssessmentID_FK")]
        public int? InitialCareAssessmentIdFk { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        public string Remarks { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [StringLength(800)]
        public string Location { get; set; }
        [StringLength(800)]
        public string OtherLocation { get; set; }
        [Column("FrequencyID_FK")]
        public int? FrequencyIdFk { get; set; }
        [Column("DosageID_FK")]
        public int? DosageIdFk { get; set; }
        [Column("MilkFeedVolumeMLS", TypeName = "decimal(4, 0)")]
        public decimal? MilkFeedVolumeMls { get; set; }
        [StringLength(255)]
        public string Supplement { get; set; }
        [Column("H2OFlushingMLS", TypeName = "decimal(4, 0)")]
        public decimal? H2oflushingMls { get; set; }
        [StringLength(30)]
        public string ReferenceType { get; set; }
        [Column("ReferenceID")]
        public int? ReferenceId { get; set; }
        public bool? Pending { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
        [Column("MedicationID_FK")]
        public int? MedicationIdFk { get; set; }
        [Column("Recurrence_Frequency")]
        public int? RecurrenceFrequency { get; set; }
        [Column("Recurrence_Days")]
        public int? RecurrenceDays { get; set; }
        [Column("Recurrence_Interval")]
        public int? RecurrenceInterval { get; set; }
        [Column("Recurrence_IntervalFlag")]
        public int? RecurrenceIntervalFlag { get; set; }
        [StringLength(255)]
        public string MedicationInstructions { get; set; }
        [Column("recurrenceDailyHourly")]
        public int? RecurrenceDailyHourly { get; set; }
    }
}
