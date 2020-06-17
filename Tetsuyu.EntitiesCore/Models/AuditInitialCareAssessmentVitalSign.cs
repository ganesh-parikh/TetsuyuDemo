using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_InitialCareAssessmentVitalSign")]
    public partial class AuditInitialCareAssessmentVitalSign
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("InitialCareAssessmentID_FK")]
        public int InitialCareAssessmentIdFk { get; set; }
        [Column("VitalSignID_FK")]
        public int VitalSignIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeOfRecord { get; set; }
    }
}
