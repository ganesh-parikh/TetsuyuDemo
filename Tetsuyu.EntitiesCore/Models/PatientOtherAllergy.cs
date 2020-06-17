using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientOtherAllergy
    {
        public PatientOtherAllergy()
        {
            InverseReferIdFkNavigation = new HashSet<PatientOtherAllergy>();
        }

        [Key]
        [Column("OtherAllergyID")]
        public int OtherAllergyId { get; set; }
        [Column("PatientID_FK")]
        public int? PatientIdFk { get; set; }
        [Column("InitialCareAssessmentID_FK")]
        public int? InitialCareAssessmentIdFk { get; set; }
        [Column("ReactionID_FK")]
        public int? ReactionIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
        [Column("DescriptionID_FK")]
        public int? DescriptionIdFk { get; set; }
        [StringLength(255)]
        public string OtherDescription { get; set; }
        [Column("ReferID_FK")]
        public int? ReferIdFk { get; set; }

        [ForeignKey(nameof(DescriptionIdFk))]
        [InverseProperty(nameof(Code.PatientOtherAllergyDescriptionIdFkNavigation))]
        public virtual Code DescriptionIdFkNavigation { get; set; }
        [ForeignKey(nameof(InitialCareAssessmentIdFk))]
        [InverseProperty(nameof(InitialCareAssessment.PatientOtherAllergy))]
        public virtual InitialCareAssessment InitialCareAssessmentIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientIdFk))]
        [InverseProperty(nameof(Patient.PatientOtherAllergy))]
        public virtual Patient PatientIdFkNavigation { get; set; }
        [ForeignKey(nameof(ReactionIdFk))]
        [InverseProperty(nameof(Code.PatientOtherAllergyReactionIdFkNavigation))]
        public virtual Code ReactionIdFkNavigation { get; set; }
        [ForeignKey(nameof(ReferIdFk))]
        [InverseProperty(nameof(PatientOtherAllergy.InverseReferIdFkNavigation))]
        public virtual PatientOtherAllergy ReferIdFkNavigation { get; set; }
        [InverseProperty(nameof(PatientOtherAllergy.ReferIdFkNavigation))]
        public virtual ICollection<PatientOtherAllergy> InverseReferIdFkNavigation { get; set; }
    }
}
