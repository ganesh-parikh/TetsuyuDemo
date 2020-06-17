using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_CarePlanSubProblemList")]
    public partial class AuditCarePlanSubProblemList
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("CarePlanSubProblemListID")]
        public int CarePlanSubProblemListId { get; set; }
        [Column("CarePlanSubID_FK")]
        public int CarePlanSubIdFk { get; set; }
        [Column("ProblemListID_FK")]
        public int ProblemListIdFk { get; set; }
        [Column("PLReviewDate", TypeName = "datetime")]
        public DateTime? PlreviewDate { get; set; }
        [Column("PLStatus")]
        [StringLength(250)]
        public string Plstatus { get; set; }
        [Column("PersonInChargeID_FK")]
        public int? PersonInChargeIdFk { get; set; }
        public int? TypeOfGoal { get; set; }
        [StringLength(500)]
        public string Goal { get; set; }
    }
}
