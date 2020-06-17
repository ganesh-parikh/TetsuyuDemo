using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientWoundVisitTreatmentList
    {
        [Key]
        [Column("PatientWoundVisitTListID")]
        public int PatientWoundVisitTlistId { get; set; }
        [Column("PatientWoundVisitID_FK")]
        public int PatientWoundVisitIdFk { get; set; }
        [Column("TListItemID_FK")]
        public int TlistItemIdFk { get; set; }
        [StringLength(500)]
        public string Remarks { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }

        [ForeignKey(nameof(PatientWoundVisitIdFk))]
        [InverseProperty(nameof(PatientWoundVisit.PatientWoundVisitTreatmentList))]
        public virtual PatientWoundVisit PatientWoundVisitIdFkNavigation { get; set; }
        [ForeignKey(nameof(TlistItemIdFk))]
        [InverseProperty(nameof(TreatmentListItem.PatientWoundVisitTreatmentList))]
        public virtual TreatmentListItem TlistItemIdFkNavigation { get; set; }
    }
}
