using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientReferral
    {
        public PatientReferral()
        {
            InitialCareAssessment = new HashSet<InitialCareAssessment>();
            Patient = new HashSet<Patient>();
            PatientReferralService = new HashSet<PatientReferralService>();
        }

        [Key]
        [Column("PatientReferralID")]
        public int PatientReferralId { get; set; }
        [Column("PrimaryClinicianID_FK")]
        public int? PrimaryClinicianIdFk { get; set; }
        [Column("SecondaryClinicianID_FK")]
        public int? SecondaryClinicianIdFk { get; set; }
        public bool? PatientAwareDiagnose { get; set; }
        public bool? FamilyAwareDiagnose { get; set; }
        public bool? PatientAwarePrognosis { get; set; }
        public bool? FamilyAwarePrognosis { get; set; }
        [StringLength(255)]
        public string PatientAwareDiagnoseReason { get; set; }
        [StringLength(255)]
        public string FamilyAwareDiagnoseReason { get; set; }
        [StringLength(255)]
        public string PatientAwarePrognosisReason { get; set; }
        [StringLength(255)]
        public string FamilyAwarePrognosisReason { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        [Column("PrimaryNurseID_FK")]
        public int? PrimaryNurseIdFk { get; set; }
        [Column("SecondaryNurseID_FK")]
        public int? SecondaryNurseIdFk { get; set; }

        [ForeignKey(nameof(PrimaryClinicianIdFk))]
        [InverseProperty(nameof(PatientClinician.PatientReferralPrimaryClinicianIdFkNavigation))]
        public virtual PatientClinician PrimaryClinicianIdFkNavigation { get; set; }
        [ForeignKey(nameof(PrimaryNurseIdFk))]
        [InverseProperty(nameof(PatientClinician.PatientReferralPrimaryNurseIdFkNavigation))]
        public virtual PatientClinician PrimaryNurseIdFkNavigation { get; set; }
        [ForeignKey(nameof(SecondaryClinicianIdFk))]
        [InverseProperty(nameof(PatientClinician.PatientReferralSecondaryClinicianIdFkNavigation))]
        public virtual PatientClinician SecondaryClinicianIdFkNavigation { get; set; }
        [ForeignKey(nameof(SecondaryNurseIdFk))]
        [InverseProperty(nameof(PatientClinician.PatientReferralSecondaryNurseIdFkNavigation))]
        public virtual PatientClinician SecondaryNurseIdFkNavigation { get; set; }
        [InverseProperty("PatientReferralIdFkNavigation")]
        public virtual ICollection<InitialCareAssessment> InitialCareAssessment { get; set; }
        [InverseProperty("PatientReferralIdFkNavigation")]
        public virtual ICollection<Patient> Patient { get; set; }
        [InverseProperty("PatientReferralIdFkNavigation")]
        public virtual ICollection<PatientReferralService> PatientReferralService { get; set; }
    }
}
