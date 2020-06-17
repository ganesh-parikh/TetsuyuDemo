using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class CarePlanSub
    {
        public CarePlanSub()
        {
            CarePlanDetail = new HashSet<CarePlanDetail>();
            CarePlanSubActivity = new HashSet<CarePlanSubActivity>();
            CarePlanSubCpgoals = new HashSet<CarePlanSubCpgoals>();
            CarePlanSubGoal = new HashSet<CarePlanSubGoal>();
            CarePlanSubIntervention = new HashSet<CarePlanSubIntervention>();
            CarePlanSubProblemList = new HashSet<CarePlanSubProblemList>();
        }

        [Key]
        [Column("CarePlanSubID")]
        public int CarePlanSubId { get; set; }
        [Column("CarePlanID_FK")]
        public int CarePlanIdFk { get; set; }
        public int SubCarePlanName { get; set; }
        [StringLength(500)]
        public string Goal { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReviewDate { get; set; }
        public int? PersonInCharge { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ApprovedDate { get; set; }
        public bool? IsDeleted { get; set; }
        public int? GroupCode { get; set; }
        [StringLength(100)]
        public string CarePlanGroupName { get; set; }
        [Column("DiseaseID_FK")]
        public int? DiseaseIdFk { get; set; }
        [StringLength(100)]
        public string InterventionStatus { get; set; }
        [StringLength(100)]
        public string GoalStatus { get; set; }

        [ForeignKey(nameof(CarePlanIdFk))]
        [InverseProperty(nameof(CarePlan.CarePlanSub))]
        public virtual CarePlan CarePlanIdFkNavigation { get; set; }
        [InverseProperty("CarePlanSubIdFkNavigation")]
        public virtual ICollection<CarePlanDetail> CarePlanDetail { get; set; }
        [InverseProperty("CarePlanSubIdFkNavigation")]
        public virtual ICollection<CarePlanSubActivity> CarePlanSubActivity { get; set; }
        [InverseProperty("CarePlanSubIdFkNavigation")]
        public virtual ICollection<CarePlanSubCpgoals> CarePlanSubCpgoals { get; set; }
        [InverseProperty("CarePlanSubIdFkNavigation")]
        public virtual ICollection<CarePlanSubGoal> CarePlanSubGoal { get; set; }
        [InverseProperty("CarePlanSubIdFkNavigation")]
        public virtual ICollection<CarePlanSubIntervention> CarePlanSubIntervention { get; set; }
        [InverseProperty("CarePlanSubIdFkNavigation")]
        public virtual ICollection<CarePlanSubProblemList> CarePlanSubProblemList { get; set; }
    }
}
