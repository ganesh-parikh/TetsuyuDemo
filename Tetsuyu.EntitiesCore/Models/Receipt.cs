using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class Receipt
    {
        public Receipt()
        {
            ReceiptForInvoice = new HashSet<ReceiptForInvoice>();
        }

        [Key]
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

        [ForeignKey(nameof(CreatedByFk))]
        [InverseProperty(nameof(Users.ReceiptCreatedByFkNavigation))]
        public virtual Users CreatedByFkNavigation { get; set; }
        [ForeignKey(nameof(CurrencyIdFk))]
        [InverseProperty(nameof(Code.ReceiptCurrencyIdFkNavigation))]
        public virtual Code CurrencyIdFkNavigation { get; set; }
        [ForeignKey(nameof(ModifiedByFk))]
        [InverseProperty(nameof(Users.ReceiptModifiedByFkNavigation))]
        public virtual Users ModifiedByFkNavigation { get; set; }
        [ForeignKey(nameof(PatientIdFk))]
        [InverseProperty(nameof(Patient.Receipt))]
        public virtual Patient PatientIdFkNavigation { get; set; }
        [ForeignKey(nameof(PaymentModeIdFk))]
        [InverseProperty(nameof(Code.ReceiptPaymentModeIdFkNavigation))]
        public virtual Code PaymentModeIdFkNavigation { get; set; }
        [InverseProperty("ReceiptIdFkNavigation")]
        public virtual ICollection<ReceiptForInvoice> ReceiptForInvoice { get; set; }
    }
}
