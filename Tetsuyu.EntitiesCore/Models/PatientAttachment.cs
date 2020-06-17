using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientAttachment
    {
        [Key]
        [Column("PatientAttachmentID")]
        public int PatientAttachmentId { get; set; }
        [Column("PatientID_FK")]
        public int PatientIdFk { get; set; }
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
        [Column("FileTypeID")]
        public int? FileTypeId { get; set; }

        [ForeignKey(nameof(PatientIdFk))]
        [InverseProperty(nameof(Patient.PatientAttachment))]
        public virtual Patient PatientIdFkNavigation { get; set; }
    }
}
