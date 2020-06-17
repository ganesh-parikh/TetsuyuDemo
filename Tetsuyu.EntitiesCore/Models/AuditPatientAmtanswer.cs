using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_PatientAMTAnswer")]
    public partial class AuditPatientAmtanswer
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("PatientAMTID_FK")]
        public int PatientAmtidFk { get; set; }
        [Column("AMTQuestionID_FK")]
        public int AmtquestionIdFk { get; set; }
        public int? Answer { get; set; }
    }
}
