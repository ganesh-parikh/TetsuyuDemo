using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_Disease")]
    public partial class AuditDisease
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("DiseaseID")]
        public int DiseaseId { get; set; }
        [Required]
        [StringLength(255)]
        public string DiseaseName { get; set; }
        [Column("SystemID_FK")]
        public int SystemIdFk { get; set; }
        public bool IsAdditionalInfo { get; set; }
        public bool IsSuggestPalliativeCare { get; set; }
        public bool IsSystemUsed { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public string AdditionalInfo { get; set; }
        [StringLength(60)]
        public string DiseaseCode { get; set; }
    }
}
