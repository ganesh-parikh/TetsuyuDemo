using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_Code")]
    public partial class AuditCode
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        public int CodeId { get; set; }
        [Column("CodeTypeId_FK")]
        public int CodeTypeIdFk { get; set; }
        [Required]
        [StringLength(255)]
        public string CodeName { get; set; }
        public int? Ordering { get; set; }
        public bool IsSystemUsed { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        [Column("Indication_Acute")]
        public bool? IndicationAcute { get; set; }
        [Column("Indication_PRN")]
        public bool? IndicationPrn { get; set; }
        [Column("Referral_Code")]
        [StringLength(3)]
        public string ReferralCode { get; set; }
        [Column("AllergyReaction_Drug")]
        public bool? AllergyReactionDrug { get; set; }
        [Column("AllergyReaction_Others")]
        public bool? AllergyReactionOthers { get; set; }
        [Column("MedicationGroupID_FK")]
        public int? MedicationGroupIdFk { get; set; }
        [StringLength(15)]
        public string Status { get; set; }
        [StringLength(3)]
        public string CurrencyCodeA { get; set; }
        [StringLength(3)]
        public string CurrencyCodeN { get; set; }
        public string CurrencyInvoiceFooter { get; set; }
        public bool? Critical { get; set; }
    }
}
