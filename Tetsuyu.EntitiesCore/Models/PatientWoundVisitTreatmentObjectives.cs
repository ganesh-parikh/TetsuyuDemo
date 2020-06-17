using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientWoundVisitTreatmentObjectives
    {
        [Key]
        [Column("PatientWoundVisitID_FK")]
        public int PatientWoundVisitIdFk { get; set; }
        [Key]
        [Column("ObjectiveID_FK")]
        public int ObjectiveIdFk { get; set; }

        [ForeignKey(nameof(ObjectiveIdFk))]
        [InverseProperty(nameof(Code.PatientWoundVisitTreatmentObjectives))]
        public virtual Code ObjectiveIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientWoundVisitIdFk))]
        [InverseProperty(nameof(PatientWoundVisit.PatientWoundVisitTreatmentObjectives))]
        public virtual PatientWoundVisit PatientWoundVisitIdFkNavigation { get; set; }
    }
}
