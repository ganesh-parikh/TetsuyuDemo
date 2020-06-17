using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientMedicalHistory
    {
        [Key]
        [Column("PatientMedicalHistoryID")]
        public int PatientMedicalHistoryId { get; set; }
        [Column("PatientID_FK")]
        public int? PatientIdFk { get; set; }
        [Column("InitialCareAssessmentID_FK")]
        public int? InitialCareAssessmentIdFk { get; set; }
        [Column("ClinicianID_FK")]
        public int? ClinicianIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
        [Column("MedicalStatusID_FK")]
        public int? MedicalStatusIdFk { get; set; }

        [ForeignKey(nameof(ClinicianIdFk))]
        [InverseProperty(nameof(PatientClinician.PatientMedicalHistory))]
        public virtual PatientClinician ClinicianIdFkNavigation { get; set; }
        [ForeignKey(nameof(MedicalStatusIdFk))]
        [InverseProperty(nameof(Code.PatientMedicalHistory))]
        public virtual Code MedicalStatusIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientIdFk))]
        [InverseProperty(nameof(Patient.PatientMedicalHistory))]
        public virtual Patient PatientIdFkNavigation { get; set; }
    }
}
