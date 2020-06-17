using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("PatientGCS")]
    public partial class PatientGcs
    {
        [Key]
        [Column("PatientGCSID")]
        public int PatientGcsid { get; set; }
        [Required]
        [StringLength(20)]
        public string Type { get; set; }
        [Column("VitalSignDetailID_FK")]
        public int? VitalSignDetailIdFk { get; set; }
        public int? Score1 { get; set; }
        public int? Score2 { get; set; }
        public int? Score3 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(VitalSignDetailIdFk))]
        [InverseProperty(nameof(VitalSignDetails.PatientGcs))]
        public virtual VitalSignDetails VitalSignDetailIdFkNavigation { get; set; }
    }
}
