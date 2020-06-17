using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("PatientMBI")]
    public partial class PatientMbi
    {
        public PatientMbi()
        {
            InitialCareAssessment = new HashSet<InitialCareAssessment>();
        }

        [Key]
        [Column("PatientMBIID")]
        public int PatientMbiid { get; set; }
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
        [InverseProperty(nameof(VitalSignDetails.PatientMbi))]
        public virtual VitalSignDetails VitalSignDetailIdFkNavigation { get; set; }
        [InverseProperty("PatientMbiidFkNavigation")]
        public virtual ICollection<InitialCareAssessment> InitialCareAssessment { get; set; }
    }
}
