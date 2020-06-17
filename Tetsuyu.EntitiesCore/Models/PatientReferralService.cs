using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientReferralService
    {
        [Key]
        [Column("PatientReferralID_FK")]
        public int PatientReferralIdFk { get; set; }
        [Key]
        [Column("ServiceID_FK")]
        public int ServiceIdFk { get; set; }

        [ForeignKey(nameof(PatientReferralIdFk))]
        [InverseProperty(nameof(PatientReferral.PatientReferralService))]
        public virtual PatientReferral PatientReferralIdFkNavigation { get; set; }
        [ForeignKey(nameof(ServiceIdFk))]
        [InverseProperty(nameof(Code.PatientReferralService))]
        public virtual Code ServiceIdFkNavigation { get; set; }
    }
}
