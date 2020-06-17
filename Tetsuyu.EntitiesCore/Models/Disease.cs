using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class Disease
    {
        public Disease()
        {
            Activity = new HashSet<Activity>();
            CarePlanDetail = new HashSet<CarePlanDetail>();
            CarePlanSubGoal = new HashSet<CarePlanSubGoal>();
            Cpgoals = new HashSet<Cpgoals>();
            DiseaseInfo = new HashSet<DiseaseInfo>();
            DiseaseSubInfo = new HashSet<DiseaseSubInfo>();
            DiseaseVitalSignType = new HashSet<DiseaseVitalSignType>();
            Intervention = new HashSet<Intervention>();
            PatientClinician = new HashSet<PatientClinician>();
            PatientFamilyHistory = new HashSet<PatientFamilyHistory>();
            PatientMedicationConsume = new HashSet<PatientMedicationConsume>();
            ProblemList = new HashSet<ProblemList>();
        }

        [Key]
        [Column("DiseaseID")]
        public int DiseaseId { get; set; }
        [Required]
        [StringLength(255)]
        public string DiseaseName { get; set; }
        [Column("SystemID_FK")]
        public int SystemIdFk { get; set; }
        public bool IsAdditionalInfo { get; set; }
        public bool IsSuggestPalliativeCare { get; set; }
        public bool IsSystemUsed { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public string AdditionalInfo { get; set; }
        [StringLength(60)]
        public string DiseaseCode { get; set; }

        [ForeignKey(nameof(SystemIdFk))]
        [InverseProperty(nameof(SystemForDisease.Disease))]
        public virtual SystemForDisease SystemIdFkNavigation { get; set; }
        [InverseProperty("DiseaseIdFkNavigation")]
        public virtual ICollection<Activity> Activity { get; set; }
        [InverseProperty("DiseaseIdFkNavigation")]
        public virtual ICollection<CarePlanDetail> CarePlanDetail { get; set; }
        [InverseProperty("DiseaseIdFkNavigation")]
        public virtual ICollection<CarePlanSubGoal> CarePlanSubGoal { get; set; }
        [InverseProperty("DiseaseIdFkNavigation")]
        public virtual ICollection<Cpgoals> Cpgoals { get; set; }
        [InverseProperty("DiseaseIdFkNavigation")]
        public virtual ICollection<DiseaseInfo> DiseaseInfo { get; set; }
        [InverseProperty("DiseaseIdFkNavigation")]
        public virtual ICollection<DiseaseSubInfo> DiseaseSubInfo { get; set; }
        [InverseProperty("DiseaseIdFkNavigation")]
        public virtual ICollection<DiseaseVitalSignType> DiseaseVitalSignType { get; set; }
        [InverseProperty("DiseaseIdFkNavigation")]
        public virtual ICollection<Intervention> Intervention { get; set; }
        [InverseProperty("DiseaseIdFkNavigation")]
        public virtual ICollection<PatientClinician> PatientClinician { get; set; }
        [InverseProperty("DiseaseIdFkNavigation")]
        public virtual ICollection<PatientFamilyHistory> PatientFamilyHistory { get; set; }
        [InverseProperty("ChronicDiseaseIdFkNavigation")]
        public virtual ICollection<PatientMedicationConsume> PatientMedicationConsume { get; set; }
        [InverseProperty("DiseaseIdFkNavigation")]
        public virtual ICollection<ProblemList> ProblemList { get; set; }
    }
}
