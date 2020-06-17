using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_MultiDisciplinaryMeetingDetail")]
    public partial class AuditMultiDisciplinaryMeetingDetail
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("MultiDisciplinaryMeetingDetailID")]
        public int MultiDisciplinaryMeetingDetailId { get; set; }
        [Column("MultiDisciplinaryMeetingID_FK")]
        public int MultiDisciplinaryMeetingIdFk { get; set; }
        [Column("IssueCatID")]
        public int IssueCatId { get; set; }
        [Required]
        public string IssueTitle { get; set; }
        [Required]
        public string IssueContent { get; set; }
        public int ActionPlan { get; set; }
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
