using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class DischargeSummaryReportAttachment
    {
        [Key]
        [Column("DischargeSummaryReportAttachmentID")]
        public int DischargeSummaryReportAttachmentId { get; set; }
        [Column("DischargeSummaryReportID_FK")]
        public int DischargeSummaryReportIdFk { get; set; }
        [StringLength(255)]
        public string Filename { get; set; }
        [StringLength(50)]
        public string Physical { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(DischargeSummaryReportIdFk))]
        [InverseProperty(nameof(DischargeSummaryReport.DischargeSummaryReportAttachment))]
        public virtual DischargeSummaryReport DischargeSummaryReportIdFkNavigation { get; set; }
    }
}
