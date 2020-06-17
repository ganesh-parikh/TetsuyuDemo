using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class Diagnosis
    {
        public Diagnosis()
        {
            CarePlan = new HashSet<CarePlan>();
        }

        [Key]
        [Column("DiagnosisID")]
        public int DiagnosisId { get; set; }
        [Required]
        [Column("Diagnosis")]
        [StringLength(255)]
        public string Diagnosis1 { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }

        [InverseProperty("DiagnosisIdFkNavigation")]
        public virtual ICollection<CarePlan> CarePlan { get; set; }
    }
}
