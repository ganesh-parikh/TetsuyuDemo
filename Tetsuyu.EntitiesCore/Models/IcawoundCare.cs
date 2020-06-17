using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("ICAWoundCare")]
    public partial class IcawoundCare
    {
        [Key]
        [Column("InitialCareAssessmentID_FK")]
        public int InitialCareAssessmentIdFk { get; set; }
        [Key]
        [Column("CodeID_FK")]
        public int CodeIdFk { get; set; }

        [ForeignKey(nameof(CodeIdFk))]
        [InverseProperty(nameof(Code.IcawoundCare))]
        public virtual Code CodeIdFkNavigation { get; set; }
        [ForeignKey(nameof(InitialCareAssessmentIdFk))]
        [InverseProperty(nameof(InitialCareAssessment.IcawoundCare))]
        public virtual InitialCareAssessment InitialCareAssessmentIdFkNavigation { get; set; }
    }
}
