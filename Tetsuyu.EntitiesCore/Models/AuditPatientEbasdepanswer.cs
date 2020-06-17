using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_PatientEBASDEPAnswer")]
    public partial class AuditPatientEbasdepanswer
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("PatientEBASDEPID_FK")]
        public int PatientEbasdepidFk { get; set; }
        [Column("EBASDEPQuestionID_FK")]
        public int EbasdepquestionIdFk { get; set; }
        public int? Answer { get; set; }
    }
}
