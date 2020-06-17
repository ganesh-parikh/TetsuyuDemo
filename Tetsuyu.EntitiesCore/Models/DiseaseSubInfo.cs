using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class DiseaseSubInfo
    {
        public DiseaseSubInfo()
        {
            PatientClinician = new HashSet<PatientClinician>();
            PatientFamilyHistory = new HashSet<PatientFamilyHistory>();
            PatientMedicationConsume = new HashSet<PatientMedicationConsume>();
        }

        [Key]
        [Column("DiseaseSubInfoID")]
        public int DiseaseSubInfoId { get; set; }
        [Required]
        [Column("DiseaseSubInfo")]
        [StringLength(50)]
        public string DiseaseSubInfo1 { get; set; }
        [Column("DiseaseID_FK")]
        public int DiseaseIdFk { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }

        [ForeignKey(nameof(DiseaseIdFk))]
        [InverseProperty(nameof(Disease.DiseaseSubInfo))]
        public virtual Disease DiseaseIdFkNavigation { get; set; }
        [InverseProperty("DiseaseSubInfoIdFkNavigation")]
        public virtual ICollection<PatientClinician> PatientClinician { get; set; }
        [InverseProperty("DiseaseSubInfoIdFkNavigation")]
        public virtual ICollection<PatientFamilyHistory> PatientFamilyHistory { get; set; }
        [InverseProperty("ChronicDiseaseSubInfoIdFkNavigation")]
        public virtual ICollection<PatientMedicationConsume> PatientMedicationConsume { get; set; }
    }
}
