using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_PatientWoundVisitTreatment")]
    public partial class AuditPatientWoundVisitTreatment
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("PatientWoundVisitTreatmentID")]
        public int PatientWoundVisitTreatmentId { get; set; }
        [Column("PatientWoundVisitID_FK")]
        public int PatientWoundVisitIdFk { get; set; }
        [Column("ItemID_FK")]
        public int ItemIdFk { get; set; }
        public int Quantity { get; set; }
        public bool IsChargeable { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
    }
}
