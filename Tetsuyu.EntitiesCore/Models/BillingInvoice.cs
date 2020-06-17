using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class BillingInvoice
    {
        public BillingInvoice()
        {
            BillingInvoiceConsumable = new HashSet<BillingInvoiceConsumable>();
            BillingInvoiceService = new HashSet<BillingInvoiceService>();
            ReceiptForInvoice = new HashSet<ReceiptForInvoice>();
        }

        [Key]
        [Column("BillingInvoiceID")]
        public int BillingInvoiceId { get; set; }
        [Column("PatientID_FK")]
        public int PatientIdFk { get; set; }
        [Required]
        [StringLength(20)]
        public string InvoiceNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDueDate { get; set; }
        [StringLength(20)]
        public string CaseNumber { get; set; }
        [Column("InitialCareAssessmentID_FK")]
        public int? InitialCareAssessmentIdFk { get; set; }
        [Column("CareReportID_FK")]
        public int? CareReportIdFk { get; set; }
        public bool? Consumable { get; set; }
        public bool? SendEmail { get; set; }
        public bool? EmailPatient { get; set; }
        public string EmailTo { get; set; }
        [Column("EmailCC")]
        public string EmailCc { get; set; }
        [Column("EmailBCC")]
        public string EmailBcc { get; set; }
        [Column("CurrencyID_FK")]
        public int CurrencyIdFk { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalCost { get; set; }
        [Required]
        [StringLength(15)]
        public string Status { get; set; }
        [Required]
        [StringLength(10)]
        public string GroupNumber { get; set; }
        public short Version { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvoiceDate { get; set; }

        [ForeignKey(nameof(CareReportIdFk))]
        [InverseProperty(nameof(CareReport.BillingInvoice))]
        public virtual CareReport CareReportIdFkNavigation { get; set; }
        [ForeignKey(nameof(CreatedByFk))]
        [InverseProperty(nameof(Users.BillingInvoiceCreatedByFkNavigation))]
        public virtual Users CreatedByFkNavigation { get; set; }
        [ForeignKey(nameof(CurrencyIdFk))]
        [InverseProperty(nameof(Code.BillingInvoice))]
        public virtual Code CurrencyIdFkNavigation { get; set; }
        [ForeignKey(nameof(ModifiedByFk))]
        [InverseProperty(nameof(Users.BillingInvoiceModifiedByFkNavigation))]
        public virtual Users ModifiedByFkNavigation { get; set; }
        [ForeignKey(nameof(PatientIdFk))]
        [InverseProperty(nameof(Patient.BillingInvoice))]
        public virtual Patient PatientIdFkNavigation { get; set; }
        [InverseProperty("BillingInvoiceIdFkNavigation")]
        public virtual ICollection<BillingInvoiceConsumable> BillingInvoiceConsumable { get; set; }
        [InverseProperty("BillingInvoiceIdFkNavigation")]
        public virtual ICollection<BillingInvoiceService> BillingInvoiceService { get; set; }
        [InverseProperty("BillingInvoiceIdFkNavigation")]
        public virtual ICollection<ReceiptForInvoice> ReceiptForInvoice { get; set; }
    }
}
