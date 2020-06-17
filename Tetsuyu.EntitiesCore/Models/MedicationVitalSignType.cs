using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class MedicationVitalSignType
    {
        [Key]
        [Column("MedicationVitalSignTypeID")]
        public int MedicationVitalSignTypeId { get; set; }
        [Column("MedicationID_FK")]
        public int MedicationIdFk { get; set; }
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

        [ForeignKey(nameof(MedicationIdFk))]
        [InverseProperty(nameof(Code.MedicationVitalSignType))]
        public virtual Code MedicationIdFkNavigation { get; set; }
        [ForeignKey(nameof(VitalSignTypeIdFk))]
        [InverseProperty(nameof(VitalSignTypes.MedicationVitalSignType))]
        public virtual VitalSignTypes VitalSignTypeIdFkNavigation { get; set; }
    }
}
