using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("PatientMMSE")]
    public partial class PatientMmse
    {
        [Key]
        [Column("PatientMMSEID")]
        public int PatientMmseid { get; set; }
        [Required]
        [StringLength(20)]
        public string Type { get; set; }
        [Column("VitalSignDetailID_FK")]
        public int? VitalSignDetailIdFk { get; set; }
        public int? Score1 { get; set; }
        public int? Score2 { get; set; }
        public int? Score3 { get; set; }
        public int? Score4 { get; set; }
        public int? Score5 { get; set; }
        public int? Score6 { get; set; }
        public int? Score7 { get; set; }
        public int? Score8 { get; set; }
        public int? Score9 { get; set; }
        public int? Score10 { get; set; }
        public int? Score11 { get; set; }
        public int? Score12 { get; set; }
        public int? Score13 { get; set; }
        public int? Score14 { get; set; }
        public int? Score15 { get; set; }
        public int? Score16 { get; set; }
        public int? Score17 { get; set; }
        public int? Score18 { get; set; }
        public int? Score19 { get; set; }
        public int? Score20 { get; set; }
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
        [InverseProperty(nameof(VitalSignDetails.PatientMmse))]
        public virtual VitalSignDetails VitalSignDetailIdFkNavigation { get; set; }
    }
}
