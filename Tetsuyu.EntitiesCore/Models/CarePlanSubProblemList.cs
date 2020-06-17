using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class CarePlanSubProblemList
    {
        public CarePlanSubProblemList()
        {
            CarePlanSubProblemListGoal = new HashSet<CarePlanSubProblemListGoal>();
        }

        [Key]
        [Column("CarePlanSubProblemListID")]
        public int CarePlanSubProblemListId { get; set; }
        [Column("CarePlanSubID_FK")]
        public int CarePlanSubIdFk { get; set; }
        [Column("ProblemListID_FK")]
        public int ProblemListIdFk { get; set; }
        [Column("PLReviewDate", TypeName = "datetime")]
        public DateTime? PlreviewDate { get; set; }
        [Column("PLStatus")]
        [StringLength(250)]
        public string Plstatus { get; set; }
        [Column("PersonInChargeID_FK")]
        public int? PersonInChargeIdFk { get; set; }
        public int? TypeOfGoal { get; set; }
        [StringLength(500)]
        public string Goal { get; set; }

        [ForeignKey(nameof(CarePlanSubIdFk))]
        [InverseProperty(nameof(CarePlanSub.CarePlanSubProblemList))]
        public virtual CarePlanSub CarePlanSubIdFkNavigation { get; set; }
        [ForeignKey(nameof(ProblemListIdFk))]
        [InverseProperty(nameof(ProblemList.CarePlanSubProblemList))]
        public virtual ProblemList ProblemListIdFkNavigation { get; set; }
        [InverseProperty("CarePlanSubProblemListIdFkNavigation")]
        public virtual ICollection<CarePlanSubProblemListGoal> CarePlanSubProblemListGoal { get; set; }
    }
}
