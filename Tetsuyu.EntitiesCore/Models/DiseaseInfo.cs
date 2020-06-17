using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class DiseaseInfo
    {
        [Key]
        [Column("DiseaseInfoID")]
        public int DiseaseInfoId { get; set; }
        [Required]
        [Column("DiseaseInfo")]
        [StringLength(50)]
        public string DiseaseInfo1 { get; set; }
        [Column("DiseaseID_FK")]
        public int DiseaseIdFk { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }

        [ForeignKey(nameof(DiseaseIdFk))]
        [InverseProperty(nameof(Disease.DiseaseInfo))]
        public virtual Disease DiseaseIdFkNavigation { get; set; }
    }
}
