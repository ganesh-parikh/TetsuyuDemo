using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_ResidentAssessmentCategory")]
    public partial class AuditResidentAssessmentCategory
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("ResidentAssessmentCategoryID")]
        public int ResidentAssessmentCategoryId { get; set; }
        [Required]
        [StringLength(500)]
        public string Category1Description { get; set; }
        [Required]
        [StringLength(500)]
        public string Category1Recommendation { get; set; }
        [Required]
        [StringLength(500)]
        public string Category2Description { get; set; }
        [Required]
        [StringLength(500)]
        public string Category2Recommendation { get; set; }
        [Required]
        [StringLength(500)]
        public string Category3Description { get; set; }
        [Required]
        [StringLength(500)]
        public string Category3Recommendation { get; set; }
        [Required]
        [StringLength(500)]
        public string Category4Description { get; set; }
        [Required]
        [StringLength(500)]
        public string Category4Recommendation { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
    }
}
