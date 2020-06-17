using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientImmunisation
    {
        [Key]
        [Column("ImmunisationID")]
        public int ImmunisationId { get; set; }
        [Column("PatientID_FK")]
        public int? PatientIdFk { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(255)]
        public string Place { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? NextDate { get; set; }
        public string Remarks { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }

        [ForeignKey(nameof(PatientIdFk))]
        [InverseProperty(nameof(Patient.PatientImmunisation))]
        public virtual Patient PatientIdFkNavigation { get; set; }
    }
}
