using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("PatientAMT")]
    public partial class PatientAmt
    {
        public PatientAmt()
        {
            PatientAmtanswer = new HashSet<PatientAmtanswer>();
        }

        [Key]
        [Column("PatientAMTID")]
        public int PatientAmtid { get; set; }
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
        [InverseProperty(nameof(CareReport.PatientAmt))]
        public virtual CareReport CareReportIdFkNavigation { get; set; }
        [ForeignKey(nameof(InitialCareAssessmentIdFk))]
        [InverseProperty(nameof(InitialCareAssessment.PatientAmt))]
        public virtual InitialCareAssessment InitialCareAssessmentIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientIdFk))]
        [InverseProperty(nameof(Patient.PatientAmt))]
        public virtual Patient PatientIdFkNavigation { get; set; }
        [ForeignKey(nameof(VitalSignDetailIdFk))]
        [InverseProperty(nameof(VitalSignDetails.PatientAmt))]
        public virtual VitalSignDetails VitalSignDetailIdFkNavigation { get; set; }
        [InverseProperty("PatientAmtidFkNavigation")]
        public virtual ICollection<PatientAmtanswer> PatientAmtanswer { get; set; }
    }
}
