using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class DischargeSummaryReport
    {
        public DischargeSummaryReport()
        {
            DischargeSummaryReportAttachment = new HashSet<DischargeSummaryReportAttachment>();
        }

        [Key]
        public int DischargeSummaryReportId { get; set; }
        [Column("PatientID_FK")]
        public int PatientIdFk { get; set; }
        [Required]
        [StringLength(20)]
        public string Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DischargeDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? VisitDateStart { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? VisitDateEnd { get; set; }
        [Column("VisitedBy_FK")]
        public int? VisitedByFk { get; set; }
        public string SummaryCaseNote { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }

        [InverseProperty("DischargeSummaryReportIdFkNavigation")]
        public virtual ICollection<DischargeSummaryReportAttachment> DischargeSummaryReportAttachment { get; set; }
    }
}
