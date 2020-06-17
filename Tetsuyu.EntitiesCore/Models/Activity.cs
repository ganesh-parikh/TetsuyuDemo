using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class Activity
    {
        public Activity()
        {
            CarePlanSubActivity = new HashSet<CarePlanSubActivity>();
        }

        [Key]
        [Column("ActivityID")]
        public int ActivityId { get; set; }
        [Column("ProblemListID_FK")]
        public int ProblemListIdFk { get; set; }
        [StringLength(255)]
        public string ActivityDetail { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        [Column("DiseaseID_FK")]
        public int DiseaseIdFk { get; set; }
        [Column("DiseaseSubInfoID_FK")]
        public int? DiseaseSubInfoIdFk { get; set; }

        [ForeignKey(nameof(DiseaseIdFk))]
        [InverseProperty(nameof(Disease.Activity))]
        public virtual Disease DiseaseIdFkNavigation { get; set; }
        [ForeignKey(nameof(ProblemListIdFk))]
        [InverseProperty(nameof(ProblemList.Activity))]
        public virtual ProblemList ProblemListIdFkNavigation { get; set; }
        [InverseProperty("ActivityIdFkNavigation")]
        public virtual ICollection<CarePlanSubActivity> CarePlanSubActivity { get; set; }
    }
}
