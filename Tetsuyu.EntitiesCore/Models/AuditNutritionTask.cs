using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_NutritionTask")]
    public partial class AuditNutritionTask
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("NutritionTaskID")]
        public int NutritionTaskId { get; set; }
        [Column("ActionTypeID_FK")]
        public int ActionTypeIdFk { get; set; }
        [Column("PatientID_FK")]
        public int? PatientIdFk { get; set; }
        [StringLength(255)]
        public string Food { get; set; }
        [StringLength(50)]
        public string Liquid { get; set; }
        [StringLength(50)]
        public string Method { get; set; }
        [StringLength(50)]
        public string BeforeImage { get; set; }
        [StringLength(50)]
        public string AfterImage { get; set; }
        [StringLength(255)]
        public string Remarks { get; set; }
        [Column("TypeReferenceID_FK")]
        public int? TypeReferenceIdFk { get; set; }
        [Column("AmountReferenceID_FK")]
        public int? AmountReferenceIdFk { get; set; }
        [Column("ColorReferenceID_FK")]
        public int? ColorReferenceIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
        public int? GivenAmount { get; set; }
        public int? TakenAmount { get; set; }
        [StringLength(10)]
        public string Unit { get; set; }
    }
}
