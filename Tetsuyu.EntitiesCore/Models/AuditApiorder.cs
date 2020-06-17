using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_APIOrder")]
    public partial class AuditApiorder
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("APIOrderId")]
        public int ApiorderId { get; set; }
        [Column("OrderID")]
        [StringLength(60)]
        public string OrderId { get; set; }
        [StringLength(255)]
        public string ResourceType { get; set; }
        [Column("PatientID")]
        public int? PatientId { get; set; }
        [Column("PatientNRIC")]
        [StringLength(60)]
        public string PatientNric { get; set; }
        [StringLength(60)]
        public string PatientFirstName { get; set; }
        [StringLength(60)]
        public string PatientLastName { get; set; }
        [Column("OrderedByID")]
        public int? OrderedById { get; set; }
        [StringLength(255)]
        public string OrderedByName { get; set; }
        [StringLength(255)]
        public string OrderedByInstitution { get; set; }
        [Column("OrderedByInstitutionID")]
        public int? OrderedByInstitutionId { get; set; }
        [Column("DoctorMCR")]
        [StringLength(255)]
        public string DoctorMcr { get; set; }
        public int? AcceptedBy { get; set; }
        [StringLength(255)]
        public string AcceptedByName { get; set; }
        [StringLength(255)]
        public string AcceptedInstitutionName { get; set; }
        [Column("AcceptedInstitutionID")]
        public int? AcceptedInstitutionId { get; set; }
        public string Clinicalsynopsis { get; set; }
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
