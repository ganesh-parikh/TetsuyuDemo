using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("PatientAMTAnswer")]
    public partial class PatientAmtanswer
    {
        [Key]
        [Column("PatientAMTID_FK")]
        public int PatientAmtidFk { get; set; }
        [Key]
        [Column("AMTQuestionID_FK")]
        public int AmtquestionIdFk { get; set; }
        public int? Answer { get; set; }

        [ForeignKey(nameof(AmtquestionIdFk))]
        [InverseProperty(nameof(Amtquestion.PatientAmtanswer))]
        public virtual Amtquestion AmtquestionIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientAmtidFk))]
        [InverseProperty(nameof(PatientAmt.PatientAmtanswer))]
        public virtual PatientAmt PatientAmtidFkNavigation { get; set; }
    }
}
