using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class UserType
    {
        public UserType()
        {
            CareReportConfig = new HashSet<CareReportConfig>();
            ExternalDoctor = new HashSet<ExternalDoctor>();
            UserUserType = new HashSet<UserUserType>();
        }

        [Key]
        [Column("UserTypeID")]
        public int UserTypeId { get; set; }
        [Required]
        [Column("UserType")]
        [StringLength(50)]
        public string UserType1 { get; set; }
        [Column("UserCategoryID_FK")]
        public int UserCategoryIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(UserCategoryIdFk))]
        [InverseProperty(nameof(UserCategory.UserType))]
        public virtual UserCategory UserCategoryIdFkNavigation { get; set; }
        [InverseProperty("UserTypeIdFkNavigation")]
        public virtual ICollection<CareReportConfig> CareReportConfig { get; set; }
        [InverseProperty("ClinicianTypeIdFkNavigation")]
        public virtual ICollection<ExternalDoctor> ExternalDoctor { get; set; }
        [InverseProperty("UserTypeIdFkNavigation")]
        public virtual ICollection<UserUserType> UserUserType { get; set; }
    }
}
