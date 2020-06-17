using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class CarePlanStatus
    {
        public CarePlanStatus()
        {
            CarePlan = new HashSet<CarePlan>();
        }

        [Key]
        [Column("CarePlanStatusID")]
        public int CarePlanStatusId { get; set; }
        [Column("CarePlanStatus")]
        [StringLength(50)]
        public string CarePlanStatus1 { get; set; }
        [StringLength(50)]
        public string CareReviewFrequency { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }

        [InverseProperty("CarePlanStatusIdFkNavigation")]
        public virtual ICollection<CarePlan> CarePlan { get; set; }
    }
}
