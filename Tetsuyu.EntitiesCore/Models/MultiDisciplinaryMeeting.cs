using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class MultiDisciplinaryMeeting
    {
        public MultiDisciplinaryMeeting()
        {
            MultiDisciplinaryMeetingDetail = new HashSet<MultiDisciplinaryMeetingDetail>();
        }

        [Key]
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

        [ForeignKey(nameof(PatientIdFk))]
        [InverseProperty(nameof(Patient.MultiDisciplinaryMeeting))]
        public virtual Patient PatientIdFkNavigation { get; set; }
        [InverseProperty("MultiDisciplinaryMeetingIdFkNavigation")]
        public virtual ICollection<MultiDisciplinaryMeetingDetail> MultiDisciplinaryMeetingDetail { get; set; }
    }
}
