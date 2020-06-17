using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class TeleconsultationRecording
    {
        [Key]
        [Column("RecordingID")]
        public int RecordingId { get; set; }
        [Column("RecordingType_FK")]
        public int RecordingTypeFk { get; set; }
        [Column("PatientID_FK")]
        public int PatientIdFk { get; set; }
        [Required]
        [StringLength(36)]
        public string Sid { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EndTime { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }

        [ForeignKey(nameof(PatientIdFk))]
        [InverseProperty(nameof(Patient.TeleconsultationRecording))]
        public virtual Patient PatientIdFkNavigation { get; set; }
        [ForeignKey(nameof(RecordingTypeFk))]
        [InverseProperty(nameof(Code.TeleconsultationRecording))]
        public virtual Code RecordingTypeFkNavigation { get; set; }
    }
}
