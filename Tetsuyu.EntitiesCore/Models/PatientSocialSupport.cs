using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientSocialSupport
    {
        public PatientSocialSupport()
        {
            CareReportSocialSupport = new HashSet<CareReportSocialSupport>();
        }

        [Key]
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

        [ForeignKey(nameof(GenderIdFk))]
        [InverseProperty(nameof(Code.PatientSocialSupportGenderIdFkNavigation))]
        public virtual Code GenderIdFkNavigation { get; set; }
        [ForeignKey(nameof(InitialCareAssessmentIdFk))]
        [InverseProperty(nameof(InitialCareAssessment.PatientSocialSupport))]
        public virtual InitialCareAssessment InitialCareAssessmentIdFkNavigation { get; set; }
        [ForeignKey(nameof(MaritalStatusIdFk))]
        [InverseProperty(nameof(Code.PatientSocialSupportMaritalStatusIdFkNavigation))]
        public virtual Code MaritalStatusIdFkNavigation { get; set; }
        [ForeignKey(nameof(NationalityIdFk))]
        [InverseProperty(nameof(Code.PatientSocialSupportNationalityIdFkNavigation))]
        public virtual Code NationalityIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientIdFk))]
        [InverseProperty(nameof(Patient.PatientSocialSupport))]
        public virtual Patient PatientIdFkNavigation { get; set; }
        [ForeignKey(nameof(RelationshipIdFk))]
        [InverseProperty(nameof(Code.PatientSocialSupportRelationshipIdFkNavigation))]
        public virtual Code RelationshipIdFkNavigation { get; set; }
        [InverseProperty("PatientSocialSupportIdFkNavigation")]
        public virtual ICollection<CareReportSocialSupport> CareReportSocialSupport { get; set; }
    }
}
