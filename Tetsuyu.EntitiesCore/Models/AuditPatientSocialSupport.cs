using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_PatientSocialSupport")]
    public partial class AuditPatientSocialSupport
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("PatientSocialSupportID")]
        public int PatientSocialSupportId { get; set; }
        [Column("PatientID_FK")]
        public int? PatientIdFk { get; set; }
        [Column("InitialCareAssessmentID_FK")]
        public int? InitialCareAssessmentIdFk { get; set; }
        [StringLength(255)]
        public string Firstname { get; set; }
        [StringLength(255)]
        public string Lastname { get; set; }
        [Column("GenderID_FK")]
        public int? GenderIdFk { get; set; }
        [Column("MaritalStatusID_FK")]
        public int? MaritalStatusIdFk { get; set; }
        [Column("RelationshipID_FK")]
        public int? RelationshipIdFk { get; set; }
        [Column("NationalityID_FK")]
        public int? NationalityIdFk { get; set; }
        [StringLength(255)]
        public string Contact { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        public bool? NotifyEmail { get; set; }
        [Column("NotifySMS")]
        public bool? NotifySms { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
        public bool? NotifyPhoneCall { get; set; }
        public bool? Spokeperson { get; set; }
        public bool? CanLogin { get; set; }
        public bool? BillTo { get; set; }
        [StringLength(255)]
        public string UserType { get; set; }
    }
}
