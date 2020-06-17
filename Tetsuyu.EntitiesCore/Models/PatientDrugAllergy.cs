using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientDrugAllergy
    {
        public PatientDrugAllergy()
        {
            InverseReferIdFkNavigation = new HashSet<PatientDrugAllergy>();
        }

        [Key]
        [Column("DrugAllergyID")]
        public int DrugAllergyId { get; set; }
        [Column("PatientID_FK")]
        public int? PatientIdFk { get; set; }
        [Column("InitialCareAssessmentID_FK")]
        public int? InitialCareAssessmentIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
        [Column("ReactionID_FK")]
        public int? ReactionIdFk { get; set; }
        [Column("MedicationID_FK")]
        public int? MedicationIdFk { get; set; }
        [Column("ReferID_FK")]
        public int? ReferIdFk { get; set; }

        [ForeignKey(nameof(InitialCareAssessmentIdFk))]
        [InverseProperty(nameof(InitialCareAssessment.PatientDrugAllergy))]
        public virtual InitialCareAssessment InitialCareAssessmentIdFkNavigation { get; set; }
        [ForeignKey(nameof(MedicationIdFk))]
        [InverseProperty(nameof(Code.PatientDrugAllergyMedicationIdFkNavigation))]
        public virtual Code MedicationIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientIdFk))]
        [InverseProperty(nameof(Patient.PatientDrugAllergy))]
        public virtual Patient PatientIdFkNavigation { get; set; }
        [ForeignKey(nameof(ReactionIdFk))]
        [InverseProperty(nameof(Code.PatientDrugAllergyReactionIdFkNavigation))]
        public virtual Code ReactionIdFkNavigation { get; set; }
        [ForeignKey(nameof(ReferIdFk))]
        [InverseProperty(nameof(PatientDrugAllergy.InverseReferIdFkNavigation))]
        public virtual PatientDrugAllergy ReferIdFkNavigation { get; set; }
        [InverseProperty(nameof(PatientDrugAllergy.ReferIdFkNavigation))]
        public virtual ICollection<PatientDrugAllergy> InverseReferIdFkNavigation { get; set; }
    }
}
