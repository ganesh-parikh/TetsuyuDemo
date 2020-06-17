using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientMedicationSupply
    {
        [Key]
        [Column("PatientMedicationID_FK")]
        public int PatientMedicationIdFk { get; set; }
        [Key]
        [Column("SupplyID_FK")]
        public int SupplyIdFk { get; set; }

        [ForeignKey(nameof(PatientMedicationIdFk))]
        [InverseProperty(nameof(PatientMedication.PatientMedicationSupply))]
        public virtual PatientMedication PatientMedicationIdFkNavigation { get; set; }
        [ForeignKey(nameof(SupplyIdFk))]
        [InverseProperty(nameof(Code.PatientMedicationSupply))]
        public virtual Code SupplyIdFkNavigation { get; set; }
    }
}
