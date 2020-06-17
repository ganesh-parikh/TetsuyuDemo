using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class DiseaseVitalSignType
    {
        [Key]
        [Column("DiseaseVitalSignTypeID")]
        public int DiseaseVitalSignTypeId { get; set; }
        [Column("DiseaseID_FK")]
        public int DiseaseIdFk { get; set; }
        [Column("VitalSignTypeID_FK")]
        public int VitalSignTypeIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(DiseaseIdFk))]
        [InverseProperty(nameof(Disease.DiseaseVitalSignType))]
        public virtual Disease DiseaseIdFkNavigation { get; set; }
        [ForeignKey(nameof(VitalSignTypeIdFk))]
        [InverseProperty(nameof(VitalSignTypes.DiseaseVitalSignType))]
        public virtual VitalSignTypes VitalSignTypeIdFkNavigation { get; set; }
    }
}
