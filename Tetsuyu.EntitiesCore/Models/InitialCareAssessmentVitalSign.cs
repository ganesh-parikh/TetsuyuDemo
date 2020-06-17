using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class InitialCareAssessmentVitalSign
    {
        [Key]
        [Column("InitialCareAssessmentID_FK")]
        public int InitialCareAssessmentIdFk { get; set; }
        [Key]
        [Column("VitalSignID_FK")]
        public int VitalSignIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeOfRecord { get; set; }
    }
}
