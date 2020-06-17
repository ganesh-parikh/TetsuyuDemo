using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class VitalSignTypes
    {
        public VitalSignTypes()
        {
            DiseaseVitalSignType = new HashSet<DiseaseVitalSignType>();
            MedicationVitalSignType = new HashSet<MedicationVitalSignType>();
            VitalSignDetails = new HashSet<VitalSignDetails>();
            VitalSignRelationships = new HashSet<VitalSignRelationships>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(200)]
        public string Name { get; set; }
        [Column("isDeleted")]
        public bool IsDeleted { get; set; }
        [Column("createdBy")]
        public int? CreatedBy { get; set; }
        [Column("createdDate", TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("updatedBy")]
        public int? UpdatedBy { get; set; }
        [Column("updatedDate", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }

        [InverseProperty("VitalSignTypeIdFkNavigation")]
        public virtual VitalSignTypeThreshold VitalSignTypeThreshold { get; set; }
        [InverseProperty("VitalSignTypeIdFkNavigation")]
        public virtual ICollection<DiseaseVitalSignType> DiseaseVitalSignType { get; set; }
        [InverseProperty("VitalSignTypeIdFkNavigation")]
        public virtual ICollection<MedicationVitalSignType> MedicationVitalSignType { get; set; }
        [InverseProperty("VitalSignType")]
        public virtual ICollection<VitalSignDetails> VitalSignDetails { get; set; }
        [InverseProperty("VitalSignType")]
        public virtual ICollection<VitalSignRelationships> VitalSignRelationships { get; set; }
    }
}
