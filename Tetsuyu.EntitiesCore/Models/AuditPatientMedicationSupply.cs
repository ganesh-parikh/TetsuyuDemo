using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_PatientMedicationSupply")]
    public partial class AuditPatientMedicationSupply
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("PatientMedicationID_FK")]
        public int PatientMedicationIdFk { get; set; }
        [Column("SupplyID_FK")]
        public int SupplyIdFk { get; set; }
    }
}
