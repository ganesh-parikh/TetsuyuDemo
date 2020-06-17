using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_CarePlan")]
    public partial class AuditCarePlan
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("CarePlanID")]
        public int CarePlanId { get; set; }
        [Column("PatientID_FK")]
        public int? PatientIdFk { get; set; }
        [Column("DiagnosisID_FK")]
        public int? DiagnosisIdFk { get; set; }
        [Column("CarePlanStatusID_FK")]
        public int? CarePlanStatusIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool? IsDeleted { get; set; }
        [Column("InitialCareAssessmentID_FK")]
        public int? InitialCareAssessmentIdFk { get; set; }
        [Column("CarePlanDetailID_FK")]
        public int? CarePlanDetailIdFk { get; set; }
        [StringLength(50)]
        public string CarePlanName { get; set; }
        public bool? IsClosed { get; set; }
        public int? PersonInCharge { get; set; }
        [StringLength(50)]
        public string CarePlanType { get; set; }
        [StringLength(500)]
        public string Remark { get; set; }
    }
}
