using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("CPGoals")]
    public partial class Cpgoals
    {
        public Cpgoals()
        {
            CarePlanSubCpgoals = new HashSet<CarePlanSubCpgoals>();
        }

        [Key]
        [Column("CPGoalsID")]
        public int CpgoalsId { get; set; }
        [Column("DiseaseID_FK")]
        public int DiseaseIdFk { get; set; }
        [Required]
        [Column("CPGoalsInfo")]
        [StringLength(255)]
        public string CpgoalsInfo { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }

        [ForeignKey(nameof(DiseaseIdFk))]
        [InverseProperty(nameof(Disease.Cpgoals))]
        public virtual Disease DiseaseIdFkNavigation { get; set; }
        [InverseProperty("CpgoalsIdFkNavigation")]
        public virtual ICollection<CarePlanSubCpgoals> CarePlanSubCpgoals { get; set; }
    }
}
