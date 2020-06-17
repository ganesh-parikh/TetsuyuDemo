using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class ProblemList
    {
        public ProblemList()
        {
            Activity = new HashSet<Activity>();
            CarePlanSubProblemList = new HashSet<CarePlanSubProblemList>();
            ProblemListGoal = new HashSet<ProblemListGoal>();
        }

        [Key]
        [Column("ProblemListID")]
        public int ProblemListId { get; set; }
        [Column("DiseaseID_FK")]
        public int DiseaseIdFk { get; set; }
        [Required]
        [StringLength(255)]
        public string ProblemInfo { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public int? TypeOfGoal { get; set; }
        [Column("DiseaseSubInfoID_FK")]
        public int? DiseaseSubInfoIdFk { get; set; }

        [ForeignKey(nameof(DiseaseIdFk))]
        [InverseProperty(nameof(Disease.ProblemList))]
        public virtual Disease DiseaseIdFkNavigation { get; set; }
        [InverseProperty("ProblemListIdFkNavigation")]
        public virtual ICollection<Activity> Activity { get; set; }
        [InverseProperty("ProblemListIdFkNavigation")]
        public virtual ICollection<CarePlanSubProblemList> CarePlanSubProblemList { get; set; }
        [InverseProperty("ProblemListIdFkNavigation")]
        public virtual ICollection<ProblemListGoal> ProblemListGoal { get; set; }
    }
}
