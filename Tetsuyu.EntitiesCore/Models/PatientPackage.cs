using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientPackage
    {
        [Key]
        [Column("PatientID_FK")]
        public int PatientIdFk { get; set; }
        [Key]
        [Column("PackageID_FK")]
        public int PackageIdFk { get; set; }

        [ForeignKey(nameof(PackageIdFk))]
        [InverseProperty(nameof(Package.PatientPackage))]
        public virtual Package PackageIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientIdFk))]
        [InverseProperty(nameof(Patient.PatientPackage))]
        public virtual Patient PatientIdFkNavigation { get; set; }
    }
}
