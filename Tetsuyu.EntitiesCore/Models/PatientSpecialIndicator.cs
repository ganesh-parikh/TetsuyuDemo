using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientSpecialIndicator
    {
        [Key]
        [Column("PatientID_FK")]
        public int PatientIdFk { get; set; }
        [Key]
        [Column("CodeID_FK")]
        public int CodeIdFk { get; set; }

        [ForeignKey(nameof(CodeIdFk))]
        [InverseProperty(nameof(Code.PatientSpecialIndicator))]
        public virtual Code CodeIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientIdFk))]
        [InverseProperty(nameof(Patient.PatientSpecialIndicator))]
        public virtual Patient PatientIdFkNavigation { get; set; }
    }
}
