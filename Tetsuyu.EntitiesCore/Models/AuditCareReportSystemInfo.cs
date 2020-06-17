using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_CareReportSystemInfo")]
    public partial class AuditCareReportSystemInfo
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("CareReportSystemInfoID")]
        public int CareReportSystemInfoId { get; set; }
        public bool? IsUpdatePrimaryDoctor { get; set; }
        [Column("PrimaryDoctorUserID_FK")]
        public int? PrimaryDoctorUserIdFk { get; set; }
        [StringLength(255)]
        public string PrimaryDoctorName { get; set; }
        public bool? IsUpdateSecondaryDoctor { get; set; }
        [Column("SecondaryDoctorUserID_FK")]
        public int? SecondaryDoctorUserIdFk { get; set; }
        [StringLength(255)]
        public string SecondaryDoctorName { get; set; }
        public bool? IsUpdateKeyPerson1 { get; set; }
        [Column("KeyPerson1UserID_FK")]
        public int? KeyPerson1UserIdFk { get; set; }
        public bool? IsUpdateKeyPerson2 { get; set; }
        [Column("KeyPerson2UserID_FK")]
        public int? KeyPerson2UserIdFk { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsUpdateFamily { get; set; }
    }
}
