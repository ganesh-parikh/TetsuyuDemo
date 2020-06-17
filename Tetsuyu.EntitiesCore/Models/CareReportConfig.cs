using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class CareReportConfig
    {
        [Key]
        [Column("CareReportConfigID")]
        public int CareReportConfigId { get; set; }
        [Column("UserTypeID_FK")]
        public int UserTypeIdFk { get; set; }
        [StringLength(30)]
        public string SectionAccess { get; set; }
        public bool IsDefault { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }

        [ForeignKey(nameof(UserTypeIdFk))]
        [InverseProperty(nameof(UserType.CareReportConfig))]
        public virtual UserType UserTypeIdFkNavigation { get; set; }
    }
}
