using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_CarePlanSub")]
    public partial class AuditCarePlanSub
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("CarePlanSubID")]
        public int CarePlanSubId { get; set; }
        [Column("CarePlanID_FK")]
        public int CarePlanIdFk { get; set; }
        public int SubCarePlanName { get; set; }
        [StringLength(500)]
        public string Goal { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReviewDate { get; set; }
        public int? PersonInCharge { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApprovedDate { get; set; }
        public bool? IsDeleted { get; set; }
        public int? GroupCode { get; set; }
        [StringLength(100)]
        public string CarePlanGroupName { get; set; }
        [Column("DiseaseID_FK")]
        public int? DiseaseIdFk { get; set; }
        [StringLength(100)]
        public string InterventionStatus { get; set; }
        [StringLength(100)]
        public string GoalStatus { get; set; }
    }
}
