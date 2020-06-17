using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientWound
    {
        public PatientWound()
        {
            PatientWoundVisit = new HashSet<PatientWoundVisit>();
        }

        [Key]
        [Column("PatientWoundID")]
        public int PatientWoundId { get; set; }
        [Column("PatientID_FK")]
        public int? PatientIdFk { get; set; }
        [Column("InitialCareAssessmentID_FK")]
        public int? InitialCareAssessmentIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? OccurDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? SeenDate { get; set; }
        [Required]
        [StringLength(50)]
        public string Site { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        [StringLength(50)]
        public string LocationOfWound { get; set; }
        [Column("CareReportID_FK")]
        public int? CareReportIdFk { get; set; }
        [StringLength(255)]
        public string ActionDescription { get; set; }
        [StringLength(255)]
        public string Remarks { get; set; }
        [StringLength(50)]
        public string Category { get; set; }
        [StringLength(50)]
        public string Stage { get; set; }
        [Column("WoundStatusID_FK")]
        public int? WoundStatusIdFk { get; set; }
        public string Comments { get; set; }

        [ForeignKey(nameof(CareReportIdFk))]
        [InverseProperty(nameof(CareReport.PatientWound))]
        public virtual CareReport CareReportIdFkNavigation { get; set; }
        [ForeignKey(nameof(InitialCareAssessmentIdFk))]
        [InverseProperty(nameof(InitialCareAssessment.PatientWound))]
        public virtual InitialCareAssessment InitialCareAssessmentIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientIdFk))]
        [InverseProperty(nameof(Patient.PatientWound))]
        public virtual Patient PatientIdFkNavigation { get; set; }
        [ForeignKey(nameof(WoundStatusIdFk))]
        [InverseProperty(nameof(Code.PatientWound))]
        public virtual Code WoundStatusIdFkNavigation { get; set; }
        [InverseProperty("PatientWoundIdFkNavigation")]
        public virtual ICollection<PatientWoundVisit> PatientWoundVisit { get; set; }
    }
}
