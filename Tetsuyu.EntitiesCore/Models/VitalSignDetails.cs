using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class VitalSignDetails
    {
        public VitalSignDetails()
        {
            NotificationVitalSignDetails = new HashSet<NotificationVitalSignDetails>();
            PatientAmt = new HashSet<PatientAmt>();
            PatientBradenScale = new HashSet<PatientBradenScale>();
            PatientEbasdep = new HashSet<PatientEbasdep>();
            PatientGcs = new HashSet<PatientGcs>();
            PatientMbi = new HashSet<PatientMbi>();
            PatientMfs = new HashSet<PatientMfs>();
            PatientMmse = new HashSet<PatientMmse>();
            PatientRaf = new HashSet<PatientRaf>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("vitalSignTypeId")]
        public int VitalSignTypeId { get; set; }
        [Column("vitalSignId")]
        public int VitalSignId { get; set; }
        [Column("detailValue", TypeName = "decimal(18, 2)")]
        public decimal DetailValue { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(VitalSignId))]
        [InverseProperty(nameof(VitalSigns.VitalSignDetails))]
        public virtual VitalSigns VitalSign { get; set; }
        [ForeignKey(nameof(VitalSignTypeId))]
        [InverseProperty(nameof(VitalSignTypes.VitalSignDetails))]
        public virtual VitalSignTypes VitalSignType { get; set; }
        [InverseProperty("VitalSignDetail")]
        public virtual ICollection<NotificationVitalSignDetails> NotificationVitalSignDetails { get; set; }
        [InverseProperty("VitalSignDetailIdFkNavigation")]
        public virtual ICollection<PatientAmt> PatientAmt { get; set; }
        [InverseProperty("VitalSignDetailIdFkNavigation")]
        public virtual ICollection<PatientBradenScale> PatientBradenScale { get; set; }
        [InverseProperty("VitalSignDetailIdFkNavigation")]
        public virtual ICollection<PatientEbasdep> PatientEbasdep { get; set; }
        [InverseProperty("VitalSignDetailIdFkNavigation")]
        public virtual ICollection<PatientGcs> PatientGcs { get; set; }
        [InverseProperty("VitalSignDetailIdFkNavigation")]
        public virtual ICollection<PatientMbi> PatientMbi { get; set; }
        [InverseProperty("VitalSignDetailIdFkNavigation")]
        public virtual ICollection<PatientMfs> PatientMfs { get; set; }
        [InverseProperty("VitalSignDetailIdFkNavigation")]
        public virtual ICollection<PatientMmse> PatientMmse { get; set; }
        [InverseProperty("VitalSignDetailIdFkNavigation")]
        public virtual ICollection<PatientRaf> PatientRaf { get; set; }
    }
}
