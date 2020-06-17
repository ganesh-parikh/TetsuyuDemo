using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_PatientAdditionalInfo")]
    public partial class AuditPatientAdditionalInfo
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("PatientAdditionalInfoID")]
        public int PatientAdditionalInfoId { get; set; }
        [Column("AICD")]
        public bool? Aicd { get; set; }
        [Column("AICD_InsertDate", TypeName = "datetime")]
        public DateTime? AicdInsertDate { get; set; }
        [Column("AICD_InsertedBy")]
        [StringLength(255)]
        public string AicdInsertedBy { get; set; }
        [Column("AICD_ReviewDate", TypeName = "datetime")]
        public DateTime? AicdReviewDate { get; set; }
        [Column("ACP")]
        public bool? Acp { get; set; }
        [Column("ACP_DoneDate", TypeName = "datetime")]
        public DateTime? AcpDoneDate { get; set; }
        [Column("ACP_ReviewDate", TypeName = "datetime")]
        public DateTime? AcpReviewDate { get; set; }
        [Column("DNR")]
        public bool? Dnr { get; set; }
        public bool? Pacemaker { get; set; }
        [Column("Pacemaker_InsertDate", TypeName = "datetime")]
        public DateTime? PacemakerInsertDate { get; set; }
        [Column("Pacemaker_InsertedBy")]
        [StringLength(255)]
        public string PacemakerInsertedBy { get; set; }
        [Column("Pacemaker_ReviewDate", TypeName = "datetime")]
        public DateTime? PacemakerReviewDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        [Column("DNR_DateInitiated", TypeName = "datetime")]
        public DateTime? DnrDateInitiated { get; set; }
        [Column("DNR_InitiatedBy")]
        [StringLength(255)]
        public string DnrInitiatedBy { get; set; }
        [Column("DNR_DateTerminated", TypeName = "datetime")]
        public DateTime? DnrDateTerminated { get; set; }
        [Column("DNR_TerminatedBy")]
        [StringLength(255)]
        public string DnrTerminatedBy { get; set; }
        [Column("CVCLine")]
        public bool? Cvcline { get; set; }
        [Column("CVCLine_InsertDate", TypeName = "datetime")]
        public DateTime? CvclineInsertDate { get; set; }
        [Column("CVCLine_InsertedBy")]
        [StringLength(255)]
        public string CvclineInsertedBy { get; set; }
        [Column("CVCLine_ReviewDate", TypeName = "datetime")]
        public DateTime? CvclineReviewDate { get; set; }
        [Column("PICCLine")]
        public bool? Piccline { get; set; }
        [Column("PICCLine_InsertDate", TypeName = "datetime")]
        public DateTime? PicclineInsertDate { get; set; }
        [Column("PICCLine_InsertedBy")]
        [StringLength(255)]
        public string PicclineInsertedBy { get; set; }
        [Column("PICCLine_ReviewDate", TypeName = "datetime")]
        public DateTime? PicclineReviewDate { get; set; }
        [Column("IVLine")]
        public bool? Ivline { get; set; }
        [Column("IVLine_InsertDate", TypeName = "datetime")]
        public DateTime? IvlineInsertDate { get; set; }
        [Column("IVLine_InsertedBy")]
        [StringLength(255)]
        public string IvlineInsertedBy { get; set; }
        [Column("IVLine_ReviewDate", TypeName = "datetime")]
        public DateTime? IvlineReviewDate { get; set; }
    }
}
