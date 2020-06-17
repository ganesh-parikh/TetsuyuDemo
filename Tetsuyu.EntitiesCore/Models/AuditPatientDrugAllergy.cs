using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_PatientDrugAllergy")]
    public partial class AuditPatientDrugAllergy
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("DrugAllergyID")]
        public int DrugAllergyId { get; set; }
        [Column("PatientID_FK")]
        public int? PatientIdFk { get; set; }
        [Column("InitialCareAssessmentID_FK")]
        public int? InitialCareAssessmentIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
        [Column("ReactionID_FK")]
        public int? ReactionIdFk { get; set; }
        [Column("MedicationID_FK")]
        public int? MedicationIdFk { get; set; }
        [Column("ReferID_FK")]
        public int? ReferIdFk { get; set; }
    }
}
