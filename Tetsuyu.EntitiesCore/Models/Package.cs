using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class Package
    {
        public Package()
        {
            PatientPackage = new HashSet<PatientPackage>();
        }

        [Key]
        [Column("PackageID")]
        public int PackageId { get; set; }
        [StringLength(255)]
        public string PackageName { get; set; }
        [StringLength(255)]
        public string PackageDetails { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }

        [InverseProperty("PackageIdFkNavigation")]
        public virtual ICollection<PatientPackage> PatientPackage { get; set; }
    }
}
