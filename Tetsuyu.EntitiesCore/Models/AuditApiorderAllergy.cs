using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_APIOrderAllergy")]
    public partial class AuditApiorderAllergy
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("APIOrderAllergyID")]
        public int ApiorderAllergyId { get; set; }
        [Column("APIOrderID_FK")]
        public int ApiorderIdFk { get; set; }
        [Column("AllergyAgentID")]
        public int? AllergyAgentId { get; set; }
        [StringLength(255)]
        public string AllergyAgent { get; set; }
        [Column("AllergyReactionID")]
        public int? AllergyReactionId { get; set; }
        [StringLength(255)]
        public string AllergyReaction { get; set; }
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
