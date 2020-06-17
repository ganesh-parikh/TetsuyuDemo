using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientMedicationConsumeAttachment
    {
        [Key]
        [Column("PatientMedicationConsumeAttachmentID")]
        public int PatientMedicationConsumeAttachmentId { get; set; }
        [Column("PatientMedicationConsumeID_FK")]
        public int PatientMedicationConsumeIdFk { get; set; }
        [StringLength(255)]
        public string Filename { get; set; }
        [StringLength(50)]
        public string Physical { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsEndDate { get; set; }

        [ForeignKey(nameof(PatientMedicationConsumeIdFk))]
        [InverseProperty(nameof(PatientMedicationConsume.PatientMedicationConsumeAttachment))]
        public virtual PatientMedicationConsume PatientMedicationConsumeIdFkNavigation { get; set; }
    }
}
