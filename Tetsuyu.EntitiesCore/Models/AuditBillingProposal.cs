using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_BillingProposal")]
    public partial class AuditBillingProposal
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
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
    }
}
