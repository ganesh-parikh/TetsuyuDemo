using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class BillingProposal
    {
        public BillingProposal()
        {
            BillingInvoiceService = new HashSet<BillingInvoiceService>();
            BillingProposalService = new HashSet<BillingProposalService>();
        }

        [Key]
        [Column("BillingProposalID")]
        public int BillingProposalId { get; set; }
        [Column("PatientID_FK")]
        public int PatientIdFk { get; set; }
        [Required]
        [StringLength(20)]
        public string ProposalNumber { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
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
        [Required]
        [StringLength(15)]
        public string ProposalType { get; set; }

        [ForeignKey(nameof(CreatedByFk))]
        [InverseProperty(nameof(Users.BillingProposalCreatedByFkNavigation))]
        public virtual Users CreatedByFkNavigation { get; set; }
        [ForeignKey(nameof(CurrencyIdFk))]
        [InverseProperty(nameof(Code.BillingProposal))]
        public virtual Code CurrencyIdFkNavigation { get; set; }
        [ForeignKey(nameof(ModifiedByFk))]
        [InverseProperty(nameof(Users.BillingProposalModifiedByFkNavigation))]
        public virtual Users ModifiedByFkNavigation { get; set; }
        [ForeignKey(nameof(PatientIdFk))]
        [InverseProperty(nameof(Patient.BillingProposal))]
        public virtual Patient PatientIdFkNavigation { get; set; }
        [InverseProperty("ProposalIdFkNavigation")]
        public virtual ICollection<BillingInvoiceService> BillingInvoiceService { get; set; }
        [InverseProperty("BillingProposalIdFkNavigation")]
        public virtual ICollection<BillingProposalService> BillingProposalService { get; set; }
    }
}
