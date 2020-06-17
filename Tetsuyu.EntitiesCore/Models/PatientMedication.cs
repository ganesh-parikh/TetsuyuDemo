using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientMedication
    {
        public PatientMedication()
        {
            InitialCareAssessment = new HashSet<InitialCareAssessment>();
            Patient = new HashSet<Patient>();
            PatientMedicationConsume = new HashSet<PatientMedicationConsume>();
            PatientMedicationSupply = new HashSet<PatientMedicationSupply>();
        }

        [Key]
        [Column("PatientMedicationID")]
        public int PatientMedicationId { get; set; }
        [StringLength(255)]
        public string Allergies { get; set; }
        public bool? SelfAdminister { get; set; }
        public bool? Compliant { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }

        [InverseProperty("PatientMedicationIdFkNavigation")]
        public virtual ICollection<InitialCareAssessment> InitialCareAssessment { get; set; }
        [InverseProperty("PatientMedicationIdFkNavigation")]
        public virtual ICollection<Patient> Patient { get; set; }
        [InverseProperty("PatientMedicationIdFkNavigation")]
        public virtual ICollection<PatientMedicationConsume> PatientMedicationConsume { get; set; }
        [InverseProperty("PatientMedicationIdFkNavigation")]
        public virtual ICollection<PatientMedicationSupply> PatientMedicationSupply { get; set; }
    }
}
