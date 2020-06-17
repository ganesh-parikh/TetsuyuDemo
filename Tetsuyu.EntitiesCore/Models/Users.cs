using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class Users
    {
        public Users()
        {
            AuditTrail = new HashSet<AuditTrail>();
            BillingInvoiceCreatedByFkNavigation = new HashSet<BillingInvoice>();
            BillingInvoiceModifiedByFkNavigation = new HashSet<BillingInvoice>();
            BillingProposalCreatedByFkNavigation = new HashSet<BillingProposal>();
            BillingProposalModifiedByFkNavigation = new HashSet<BillingProposal>();
            CareReport = new HashSet<CareReport>();
            CareReportSystemInfoKeyPerson1UserIdFkNavigation = new HashSet<CareReportSystemInfo>();
            CareReportSystemInfoKeyPerson2UserIdFkNavigation = new HashSet<CareReportSystemInfo>();
            Chat = new HashSet<Chat>();
            Enquiry = new HashSet<Enquiry>();
            EnquiryConfigEscalatingPersonIdFkNavigation = new HashSet<EnquiryConfig>();
            EnquiryConfigScmidFkNavigation = new HashSet<EnquiryConfig>();
            EnquiryEscPerson = new HashSet<EnquiryEscPerson>();
            EnquiryScm = new HashSet<EnquiryScm>();
            Event = new HashSet<Event>();
            EventUser = new HashSet<EventUser>();
            EventUserLog = new HashSet<EventUserLog>();
            Notifications = new HashSet<Notifications>();
            PatientClinician = new HashSet<PatientClinician>();
            PatientWoundVisit = new HashSet<PatientWoundVisit>();
            PatientWoundVisitClinician = new HashSet<PatientWoundVisitClinician>();
            ReceiptCreatedByFkNavigation = new HashSet<Receipt>();
            ReceiptModifiedByFkNavigation = new HashSet<Receipt>();
            RecentView = new HashSet<RecentView>();
            Task = new HashSet<Task>();
            TaskUser = new HashSet<TaskUser>();
            TaskUserLog = new HashSet<TaskUserLog>();
            UserAddress = new HashSet<UserAddress>();
            UserBranch = new HashSet<UserBranch>();
            UserLanguage = new HashSet<UserLanguage>();
            UserOrganization = new HashSet<UserOrganization>();
            UserRole = new HashSet<UserRole>();
            UserSkillset = new HashSet<UserSkillset>();
            UserUserType = new HashSet<UserUserType>();
        }

        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }
        [StringLength(255)]
        public string Remarks { get; set; }
        [StringLength(50)]
        public string Photo { get; set; }
        [StringLength(255)]
        public string Contact { get; set; }
        [StringLength(255)]
        public string Designation { get; set; }
        [Required]
        [StringLength(15)]
        public string Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastLoginDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastLogoutDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastActivityDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastLockoutDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastPasswordChangedDate { get; set; }
        [StringLength(1000)]
        public string PreviousPasswords { get; set; }
        [StringLength(50)]
        public string SessionKey { get; set; }
        public bool? ResetPassword { get; set; }
        public bool IsDeleted { get; set; }
        [StringLength(255)]
        public string LocationNow1 { get; set; }
        [StringLength(255)]
        public string LocationNow2 { get; set; }
        [StringLength(255)]
        public string LocationNow3 { get; set; }
        [StringLength(10)]
        public string PostalCodeNow { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LocationNowModifiedDate { get; set; }
        [Column("PatientID_FK")]
        public int? PatientIdFk { get; set; }
        public bool IsExternal { get; set; }
        [Column("UserOrganizationID_FK")]
        public int? UserOrganizationIdFk { get; set; }
        [Column("IsTCAccepted")]
        public bool? IsTcaccepted { get; set; }
        [StringLength(60)]
        public string UserName { get; set; }
        public int? PreferredLanguage { get; set; }

        [ForeignKey(nameof(PatientIdFk))]
        [InverseProperty(nameof(Patient.Users))]
        public virtual Patient PatientIdFkNavigation { get; set; }
        [InverseProperty("CreatedByFkNavigation")]
        public virtual ICollection<AuditTrail> AuditTrail { get; set; }
        [InverseProperty(nameof(BillingInvoice.CreatedByFkNavigation))]
        public virtual ICollection<BillingInvoice> BillingInvoiceCreatedByFkNavigation { get; set; }
        [InverseProperty(nameof(BillingInvoice.ModifiedByFkNavigation))]
        public virtual ICollection<BillingInvoice> BillingInvoiceModifiedByFkNavigation { get; set; }
        [InverseProperty(nameof(BillingProposal.CreatedByFkNavigation))]
        public virtual ICollection<BillingProposal> BillingProposalCreatedByFkNavigation { get; set; }
        [InverseProperty(nameof(BillingProposal.ModifiedByFkNavigation))]
        public virtual ICollection<BillingProposal> BillingProposalModifiedByFkNavigation { get; set; }
        [InverseProperty("VisitedByFkNavigation")]
        public virtual ICollection<CareReport> CareReport { get; set; }
        [InverseProperty(nameof(CareReportSystemInfo.KeyPerson1UserIdFkNavigation))]
        public virtual ICollection<CareReportSystemInfo> CareReportSystemInfoKeyPerson1UserIdFkNavigation { get; set; }
        [InverseProperty(nameof(CareReportSystemInfo.KeyPerson2UserIdFkNavigation))]
        public virtual ICollection<CareReportSystemInfo> CareReportSystemInfoKeyPerson2UserIdFkNavigation { get; set; }
        [InverseProperty("CreatedByFkNavigation")]
        public virtual ICollection<Chat> Chat { get; set; }
        [InverseProperty("CareManagerAssignedIdFkNavigation")]
        public virtual ICollection<Enquiry> Enquiry { get; set; }
        [InverseProperty(nameof(EnquiryConfig.EscalatingPersonIdFkNavigation))]
        public virtual ICollection<EnquiryConfig> EnquiryConfigEscalatingPersonIdFkNavigation { get; set; }
        [InverseProperty(nameof(EnquiryConfig.ScmidFkNavigation))]
        public virtual ICollection<EnquiryConfig> EnquiryConfigScmidFkNavigation { get; set; }
        [InverseProperty("UserIdFkNavigation")]
        public virtual ICollection<EnquiryEscPerson> EnquiryEscPerson { get; set; }
        [InverseProperty("UserIdFkNavigation")]
        public virtual ICollection<EnquiryScm> EnquiryScm { get; set; }
        [InverseProperty("CreatedByFkNavigation")]
        public virtual ICollection<Event> Event { get; set; }
        [InverseProperty("UserIdFkNavigation")]
        public virtual ICollection<EventUser> EventUser { get; set; }
        [InverseProperty("UserIdFkNavigation")]
        public virtual ICollection<EventUserLog> EventUserLog { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Notifications> Notifications { get; set; }
        [InverseProperty("UserIdFkNavigation")]
        public virtual ICollection<PatientClinician> PatientClinician { get; set; }
        [InverseProperty("AssignedToIdFkNavigation")]
        public virtual ICollection<PatientWoundVisit> PatientWoundVisit { get; set; }
        [InverseProperty("UserIdFkNavigation")]
        public virtual ICollection<PatientWoundVisitClinician> PatientWoundVisitClinician { get; set; }
        [InverseProperty(nameof(Receipt.CreatedByFkNavigation))]
        public virtual ICollection<Receipt> ReceiptCreatedByFkNavigation { get; set; }
        [InverseProperty(nameof(Receipt.ModifiedByFkNavigation))]
        public virtual ICollection<Receipt> ReceiptModifiedByFkNavigation { get; set; }
        [InverseProperty("UserIdFkNavigation")]
        public virtual ICollection<RecentView> RecentView { get; set; }
        [InverseProperty("CreatedByFkNavigation")]
        public virtual ICollection<Task> Task { get; set; }
        [InverseProperty("UserIdFkNavigation")]
        public virtual ICollection<TaskUser> TaskUser { get; set; }
        [InverseProperty("UserIdFkNavigation")]
        public virtual ICollection<TaskUserLog> TaskUserLog { get; set; }
        [InverseProperty("UserIdFkNavigation")]
        public virtual ICollection<UserAddress> UserAddress { get; set; }
        [InverseProperty("UserIdFkNavigation")]
        public virtual ICollection<UserBranch> UserBranch { get; set; }
        [InverseProperty("UserIdFkNavigation")]
        public virtual ICollection<UserLanguage> UserLanguage { get; set; }
        [InverseProperty("UserIdFkNavigation")]
        public virtual ICollection<UserOrganization> UserOrganization { get; set; }
        [InverseProperty("UserIdFkNavigation")]
        public virtual ICollection<UserRole> UserRole { get; set; }
        [InverseProperty("UserIdFkNavigation")]
        public virtual ICollection<UserSkillset> UserSkillset { get; set; }
        [InverseProperty("UserIdFkNavigation")]
        public virtual ICollection<UserUserType> UserUserType { get; set; }
    }
}
