using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("PatientEBASDEP")]
    public partial class PatientEbasdep
    {
        public PatientEbasdep()
        {
            PatientEbasdepanswer = new HashSet<PatientEbasdepanswer>();
        }

        [Key]
        [Column("PatientEBASDEPID")]
        public int PatientEbasdepid { get; set; }
        [Column("PatientID_FK")]
        public int? PatientIdFk { get; set; }
        [Column("InitialCareAssessmentID_FK")]
        public int? InitialCareAssessmentIdFk { get; set; }
        [StringLength(50)]
        public string Alertness { get; set; }
        public int? Score { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
        [Column("CareReportID_FK")]
        public int? CareReportIdFk { get; set; }
        [Column("VitalSignDetailId_FK")]
        public int? VitalSignDetailIdFk { get; set; }

        [ForeignKey(nameof(CareReportIdFk))]
        [InverseProperty(nameof(CareReport.PatientEbasdep))]
        public virtual CareReport CareReportIdFkNavigation { get; set; }
        [ForeignKey(nameof(InitialCareAssessmentIdFk))]
        [InverseProperty(nameof(InitialCareAssessment.PatientEbasdep))]
        public virtual InitialCareAssessment InitialCareAssessmentIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientIdFk))]
        [InverseProperty(nameof(Patient.PatientEbasdep))]
        public virtual Patient PatientIdFkNavigation { get; set; }
        [ForeignKey(nameof(VitalSignDetailIdFk))]
        [InverseProperty(nameof(VitalSignDetails.PatientEbasdep))]
        public virtual VitalSignDetails VitalSignDetailIdFkNavigation { get; set; }
        [InverseProperty("PatientEbasdepidFkNavigation")]
        public virtual ICollection<PatientEbasdepanswer> PatientEbasdepanswer { get; set; }
    }
}
