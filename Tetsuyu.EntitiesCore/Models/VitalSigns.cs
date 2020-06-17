using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class VitalSigns
    {
        public VitalSigns()
        {
            CareReport = new HashSet<CareReport>();
            InitialCareAssessment = new HashSet<InitialCareAssessment>();
            PatientWoundVisit = new HashSet<PatientWoundVisit>();
            VitalSignDetails = new HashSet<VitalSignDetails>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("patientId")]
        public int PatientId { get; set; }
        [Required]
        [Column("source")]
        [StringLength(200)]
        public string Source { get; set; }
        [Column("icaId")]
        public int IcaId { get; set; }
        [Column("isDeleted")]
        public bool IsDeleted { get; set; }
        [Column("createdBy")]
        public int? CreatedBy { get; set; }
        [Column("createdDate", TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("updatedBy")]
        public int? UpdatedBy { get; set; }
        [Column("updatedDate", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }

        [ForeignKey(nameof(PatientId))]
        [InverseProperty("VitalSigns")]
        public virtual Patient Patient { get; set; }
        [InverseProperty("VitalSignIdFkNavigation")]
        public virtual ICollection<CareReport> CareReport { get; set; }
        [InverseProperty("VitalSignIdFkNavigation")]
        public virtual ICollection<InitialCareAssessment> InitialCareAssessment { get; set; }
        [InverseProperty("VitalSignIdFkNavigation")]
        public virtual ICollection<PatientWoundVisit> PatientWoundVisit { get; set; }
        [InverseProperty("VitalSign")]
        public virtual ICollection<VitalSignDetails> VitalSignDetails { get; set; }
    }
}
