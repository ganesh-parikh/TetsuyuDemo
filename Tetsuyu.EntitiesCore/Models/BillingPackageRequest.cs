using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class BillingPackageRequest
    {
        [Key]
        [Column("PackageRequestID")]
        public int PackageRequestId { get; set; }
        [Required]
        [StringLength(255)]
        public string PackageRequestNo { get; set; }
        [Column("PatientID_FK")]
        public int PatientIdFk { get; set; }
        [Required]
        [StringLength(100)]
        public string PatientName { get; set; }
        [Required]
        [StringLength(10)]
        public string SendBillTo { get; set; }
        [Column(TypeName = "date")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }
        public bool Discount { get; set; }
        [StringLength(100)]
        public string DiscountType { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal DiscountAmt { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal DiscountPercentage { get; set; }
        [Required]
        public string Remarks { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
        [StringLength(255)]
        public string BillingAddress1 { get; set; }
        [StringLength(255)]
        public string BillingAddress2 { get; set; }
        [StringLength(255)]
        public string BillingAddress3 { get; set; }
        [StringLength(10)]
        public string BillingPostalCode { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalPackageAmount { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(50)]
        public string PackageList { get; set; }
    }
}
