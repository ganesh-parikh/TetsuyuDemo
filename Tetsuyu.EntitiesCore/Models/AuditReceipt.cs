using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_Receipt")]
    public partial class AuditReceipt
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("ReceiptID")]
        public int ReceiptId { get; set; }
        [Required]
        [StringLength(20)]
        public string ReceiptNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ReceiptDate { get; set; }
        [Column("PatientID_FK")]
        public int PatientIdFk { get; set; }
        [Column("PaymentModeID_FK")]
        public int PaymentModeIdFk { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalAmt { get; set; }
        public string ReceivedFrom { get; set; }
        public string Remarks { get; set; }
        public bool? SendEmail { get; set; }
        public bool? EmailPatient { get; set; }
        public string EmailTo { get; set; }
        [Column("EmailCC")]
        public string EmailCc { get; set; }
        [Column("EmailBCC")]
        public string EmailBcc { get; set; }
        [Column("CurrencyID_FK")]
        public int CurrencyIdFk { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }
        [Required]
        [StringLength(10)]
        public string GroupNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
    }
}
