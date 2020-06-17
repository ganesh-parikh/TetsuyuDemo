using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("PatientEBASDEPAnswer")]
    public partial class PatientEbasdepanswer
    {
        [Key]
        [Column("PatientEBASDEPID_FK")]
        public int PatientEbasdepidFk { get; set; }
        [Key]
        [Column("EBASDEPQuestionID_FK")]
        public int EbasdepquestionIdFk { get; set; }
        public int? Answer { get; set; }

        [ForeignKey(nameof(EbasdepquestionIdFk))]
        [InverseProperty(nameof(Ebasdepquestion.PatientEbasdepanswer))]
        public virtual Ebasdepquestion EbasdepquestionIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientEbasdepidFk))]
        [InverseProperty(nameof(PatientEbasdep.PatientEbasdepanswer))]
        public virtual PatientEbasdep PatientEbasdepidFkNavigation { get; set; }
    }
}
