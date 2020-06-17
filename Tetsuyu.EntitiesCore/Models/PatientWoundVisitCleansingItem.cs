using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientWoundVisitCleansingItem
    {
        [Key]
        [Column("PatientWoundVisitID_FK")]
        public int PatientWoundVisitIdFk { get; set; }
        [Key]
        [Column("CodeID_FK")]
        public int CodeIdFk { get; set; }

        [ForeignKey(nameof(CodeIdFk))]
        [InverseProperty(nameof(Code.PatientWoundVisitCleansingItem))]
        public virtual Code CodeIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientWoundVisitIdFk))]
        [InverseProperty(nameof(PatientWoundVisit.PatientWoundVisitCleansingItem))]
        public virtual PatientWoundVisit PatientWoundVisitIdFkNavigation { get; set; }
    }
}
