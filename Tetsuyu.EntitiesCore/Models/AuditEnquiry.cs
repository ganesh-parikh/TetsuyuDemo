using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_Enquiry")]
    public partial class AuditEnquiry
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("EnquiryID")]
        public int EnquiryId { get; set; }
        [Column("CareManagerAssignedID_FK")]
        public int? CareManagerAssignedIdFk { get; set; }
        [Column("EnquirySourceID_FK")]
        public int? EnquirySourceIdFk { get; set; }
        [StringLength(255)]
        public string FirstName { get; set; }
        [StringLength(255)]
        public string LastName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateOfBirth { get; set; }
        [Column("RaceID_FK")]
        public int? RaceIdFk { get; set; }
        [StringLength(255)]
        public string IdentificationNumber { get; set; }
        [Column("PreferredLanguageID_FK")]
        public int? PreferredLanguageIdFk { get; set; }
        [Column("GenderID_FK")]
        public int? GenderIdFk { get; set; }
        [StringLength(255)]
        public string PatientAddress1 { get; set; }
        [StringLength(255)]
        public string PatientAddress2 { get; set; }
        [StringLength(255)]
        public string PatientAddress3 { get; set; }
        [StringLength(10)]
        public string PostalCode { get; set; }
        [StringLength(255)]
        public string NameOfCaller { get; set; }
        [StringLength(20)]
        public string ContactNumberOfCaller { get; set; }
        [StringLength(200)]
        public string EmailOfCaller { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? PreferredAppointmentDateTime { get; set; }
        [StringLength(500)]
        public string MedicalHistory { get; set; }
        [Column("CaregiverAtHomeID_FK")]
        public int? CaregiverAtHomeIdFk { get; set; }
        [Column("ServicesRequiredID_FK")]
        public int? ServicesRequiredIdFk { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        [StringLength(500)]
        public string Remarks { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool? IsDeleted { get; set; }
        [StringLength(255)]
        public string OtherRace { get; set; }
        [StringLength(50)]
        public string OtherPreferredLanguage { get; set; }
        [Column("UserOrganizationID_FK")]
        public int? UserOrganizationIdFk { get; set; }
        [StringLength(50)]
        public string CaseNumber { get; set; }
        [StringLength(255)]
        public string Note { get; set; }
        [Column("OrderID")]
        [StringLength(60)]
        public string OrderId { get; set; }
    }
}
