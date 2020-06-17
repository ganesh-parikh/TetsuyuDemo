using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class Intervention
    {
        public Intervention()
        {
            CarePlanSubIntervention = new HashSet<CarePlanSubIntervention>();
        }

        [Key]
        [Column("InterventionID")]
        public int InterventionId { get; set; }
        [Column("DiseaseID_FK")]
        public int DiseaseIdFk { get; set; }
        [Required]
        [StringLength(255)]
        public string InterventionInfo { get; set; }
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
        [InverseProperty(nameof(Disease.Intervention))]
        public virtual Disease DiseaseIdFkNavigation { get; set; }
        [InverseProperty("InterventionIdFkNavigation")]
        public virtual ICollection<CarePlanSubIntervention> CarePlanSubIntervention { get; set; }
    }
}
