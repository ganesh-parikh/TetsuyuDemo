using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_MultiDisciplinaryMeeting")]
    public partial class AuditMultiDisciplinaryMeeting
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("MultiDisciplinaryMeetingID")]
        public int MultiDisciplinaryMeetingId { get; set; }
        [Column("PatientID_FK")]
        public int PatientIdFk { get; set; }
        [Required]
        public string IssuesOverall { get; set; }
        public int AssignedToFollowUp { get; set; }
        [Required]
        public string Remarks { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
    }
}
