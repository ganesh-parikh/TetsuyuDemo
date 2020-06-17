using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class CareReportSocialSupport
    {
        [Key]
        [Column("CareReportSocialSupportID")]
        public int CareReportSocialSupportId { get; set; }
        [Column("CareReportID_FK")]
        public int CareReportIdFk { get; set; }
        [Column("PatientSocialSupportID_FK")]
        public int PatientSocialSupportIdFk { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }

        [ForeignKey(nameof(CareReportIdFk))]
        [InverseProperty(nameof(CareReport.CareReportSocialSupport))]
        public virtual CareReport CareReportIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientSocialSupportIdFk))]
        [InverseProperty(nameof(PatientSocialSupport.CareReportSocialSupport))]
        public virtual PatientSocialSupport PatientSocialSupportIdFkNavigation { get; set; }
    }
}
