using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_Users")]
    public partial class AuditUsers
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
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
        public bool? IsExternal { get; set; }
        [Column("UserOrganizationID_FK")]
        public int? UserOrganizationIdFk { get; set; }
        [Column("IsTCAccepted")]
        public bool? IsTcaccepted { get; set; }
        [StringLength(60)]
        public string UserName { get; set; }
    }
}
