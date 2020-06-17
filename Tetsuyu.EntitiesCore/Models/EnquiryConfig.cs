using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class EnquiryConfig
    {
        public EnquiryConfig()
        {
            EnquiryEscPerson = new HashSet<EnquiryEscPerson>();
            EnquiryScm = new HashSet<EnquiryScm>();
        }

        [Key]
        [Column("EnquiryConfigID")]
        public int EnquiryConfigId { get; set; }
        [Column("SCMID_FK")]
        public int? ScmidFk { get; set; }
        public string EmailContent { get; set; }
        [Column("EscalatingPersonID_FK")]
        public int? EscalatingPersonIdFk { get; set; }
        [Column(TypeName = "decimal(2, 0)")]
        public decimal? EscalationPeriod { get; set; }
        public string EscalationEmail { get; set; }
        [Column("EmailtoCMContent")]
        public string EmailtoCmcontent { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool? IsDeleted { get; set; }

        [ForeignKey(nameof(EscalatingPersonIdFk))]
        [InverseProperty(nameof(Users.EnquiryConfigEscalatingPersonIdFkNavigation))]
        public virtual Users EscalatingPersonIdFkNavigation { get; set; }
        [ForeignKey(nameof(ScmidFk))]
        [InverseProperty(nameof(Users.EnquiryConfigScmidFkNavigation))]
        public virtual Users ScmidFkNavigation { get; set; }
        [InverseProperty("EnquiryConfig")]
        public virtual ICollection<EnquiryEscPerson> EnquiryEscPerson { get; set; }
        [InverseProperty("EnquiryConfigIdFkNavigation")]
        public virtual ICollection<EnquiryScm> EnquiryScm { get; set; }
    }
}
