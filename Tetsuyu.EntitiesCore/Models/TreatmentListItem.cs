using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class TreatmentListItem
    {
        public TreatmentListItem()
        {
            PatientWoundVisitTreatmentList = new HashSet<PatientWoundVisitTreatmentList>();
            TreatmentTol = new HashSet<TreatmentTol>();
        }

        [Key]
        [Column("TListItemID")]
        public int TlistItemId { get; set; }
        [Required]
        [StringLength(255)]
        public string ItemName { get; set; }
        [Column("TListTypeID_FK")]
        public int TlistTypeIdFk { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsSystemUsed { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }

        [ForeignKey(nameof(TlistTypeIdFk))]
        [InverseProperty(nameof(Code.TreatmentListItem))]
        public virtual Code TlistTypeIdFkNavigation { get; set; }
        [InverseProperty("TlistItemIdFkNavigation")]
        public virtual ICollection<PatientWoundVisitTreatmentList> PatientWoundVisitTreatmentList { get; set; }
        [InverseProperty("TlistItemIdFkNavigation")]
        public virtual ICollection<TreatmentTol> TreatmentTol { get; set; }
    }
}
