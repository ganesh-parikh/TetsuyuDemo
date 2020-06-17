using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientAccessLine
    {
        [Key]
        [Column("PatientAccessLineID")]
        public int PatientAccessLineId { get; set; }
        [Required]
        [StringLength(30)]
        public string AccessLine { get; set; }
        [Column("CareReportID_FK")]
        public int CareReportIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateOfInsertion { get; set; }
        [Required]
        [StringLength(5)]
        public string Patent { get; set; }
        [StringLength(5)]
        public string PatentReSited { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PatentReSitedDate { get; set; }
        [StringLength(1000)]
        public string PatentSite { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateDueForChange { get; set; }
        [StringLength(500)]
        public string AccessLineRemarks { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }

        [ForeignKey(nameof(CareReportIdFk))]
        [InverseProperty(nameof(CareReport.PatientAccessLine))]
        public virtual CareReport CareReportIdFkNavigation { get; set; }
    }
}
