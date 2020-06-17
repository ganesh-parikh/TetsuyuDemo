using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class VitalSignRelationships
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("vitalSignTypeId")]
        public int VitalSignTypeId { get; set; }
        [Column("patientId")]
        public int PatientId { get; set; }
        [Column("thresholdId")]
        public int ThresholdId { get; set; }

        [ForeignKey(nameof(PatientId))]
        [InverseProperty("VitalSignRelationships")]
        public virtual Patient Patient { get; set; }
        [ForeignKey(nameof(ThresholdId))]
        [InverseProperty(nameof(Thresholds.VitalSignRelationships))]
        public virtual Thresholds Threshold { get; set; }
        [ForeignKey(nameof(VitalSignTypeId))]
        [InverseProperty(nameof(VitalSignTypes.VitalSignRelationships))]
        public virtual VitalSignTypes VitalSignType { get; set; }
    }
}
