using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientClinician
    {
        public PatientClinician()
        {
            CareReportSystemInfoPrimaryDoctorUserIdFkNavigation = new HashSet<CareReportSystemInfo>();
            CareReportSystemInfoSecondaryDoctorUserIdFkNavigation = new HashSet<CareReportSystemInfo>();
            PatientMedicalHistory = new HashSet<PatientMedicalHistory>();
            PatientReferralPrimaryClinicianIdFkNavigation = new HashSet<PatientReferral>();
            PatientReferralPrimaryNurseIdFkNavigation = new HashSet<PatientReferral>();
            PatientReferralSecondaryClinicianIdFkNavigation = new HashSet<PatientReferral>();
            PatientReferralSecondaryNurseIdFkNavigation = new HashSet<PatientReferral>();
        }

        [Key]
        [Column("PatientClinicianID")]
        public int PatientClinicianId { get; set; }
        [Column("PatientID_FK")]
        public int? PatientIdFk { get; set; }
        [Column("InitialCareAssessmentID_FK")]
        public int? InitialCareAssessmentIdFk { get; set; }
        [Column("UserID_FK")]
        public int? UserIdFk { get; set; }
        [Column("ExternalDoctorID_FK")]
        public int? ExternalDoctorIdFk { get; set; }
        [Column("DiseaseID_FK")]
        public int? DiseaseIdFk { get; set; }
        [Column("DiseaseSubInfoID_FK")]
        public int? DiseaseSubInfoIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(DiseaseIdFk))]
        [InverseProperty(nameof(Disease.PatientClinician))]
        public virtual Disease DiseaseIdFkNavigation { get; set; }
        [ForeignKey(nameof(DiseaseSubInfoIdFk))]
        [InverseProperty(nameof(DiseaseSubInfo.PatientClinician))]
        public virtual DiseaseSubInfo DiseaseSubInfoIdFkNavigation { get; set; }
        [ForeignKey(nameof(ExternalDoctorIdFk))]
        [InverseProperty(nameof(ExternalDoctor.PatientClinician))]
        public virtual ExternalDoctor ExternalDoctorIdFkNavigation { get; set; }
        [ForeignKey(nameof(InitialCareAssessmentIdFk))]
        [InverseProperty(nameof(InitialCareAssessment.PatientClinician))]
        public virtual InitialCareAssessment InitialCareAssessmentIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientIdFk))]
        [InverseProperty(nameof(Patient.PatientClinician))]
        public virtual Patient PatientIdFkNavigation { get; set; }
        [ForeignKey(nameof(UserIdFk))]
        [InverseProperty(nameof(Users.PatientClinician))]
        public virtual Users UserIdFkNavigation { get; set; }
        [InverseProperty(nameof(CareReportSystemInfo.PrimaryDoctorUserIdFkNavigation))]
        public virtual ICollection<CareReportSystemInfo> CareReportSystemInfoPrimaryDoctorUserIdFkNavigation { get; set; }
        [InverseProperty(nameof(CareReportSystemInfo.SecondaryDoctorUserIdFkNavigation))]
        public virtual ICollection<CareReportSystemInfo> CareReportSystemInfoSecondaryDoctorUserIdFkNavigation { get; set; }
        [InverseProperty("ClinicianIdFkNavigation")]
        public virtual ICollection<PatientMedicalHistory> PatientMedicalHistory { get; set; }
        [InverseProperty(nameof(PatientReferral.PrimaryClinicianIdFkNavigation))]
        public virtual ICollection<PatientReferral> PatientReferralPrimaryClinicianIdFkNavigation { get; set; }
        [InverseProperty(nameof(PatientReferral.PrimaryNurseIdFkNavigation))]
        public virtual ICollection<PatientReferral> PatientReferralPrimaryNurseIdFkNavigation { get; set; }
        [InverseProperty(nameof(PatientReferral.SecondaryClinicianIdFkNavigation))]
        public virtual ICollection<PatientReferral> PatientReferralSecondaryClinicianIdFkNavigation { get; set; }
        [InverseProperty(nameof(PatientReferral.SecondaryNurseIdFkNavigation))]
        public virtual ICollection<PatientReferral> PatientReferralSecondaryNurseIdFkNavigation { get; set; }
    }
}
