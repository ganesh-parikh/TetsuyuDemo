using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class SystemForDisease
    {
        public SystemForDisease()
        {
            CarePlanDetail = new HashSet<CarePlanDetail>();
            Disease = new HashSet<Disease>();
        }

        [Key]
        [Column("SystemID")]
        public int SystemId { get; set; }
        [StringLength(255)]
        public string System { get; set; }
        public bool IsSystemUsed { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public int? GroupCode { get; set; }

        [InverseProperty("SystemIdFkNavigation")]
        public virtual ICollection<CarePlanDetail> CarePlanDetail { get; set; }
        [InverseProperty("SystemIdFkNavigation")]
        public virtual ICollection<Disease> Disease { get; set; }
    }
}
