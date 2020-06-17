using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_PatientWoundVisitClinician")]
    public partial class AuditPatientWoundVisitClinician
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("PatientWoundVisitClinicianID")]
        public int PatientWoundVisitClinicianId { get; set; }
        [Column("PatientWoundVisitID_FK")]
        public int? PatientWoundVisitIdFk { get; set; }
        [Column("UserID_FK")]
        public int? UserIdFk { get; set; }
        [Column("ExternalDoctorID_FK")]
        public int? ExternalDoctorIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
    }
}
