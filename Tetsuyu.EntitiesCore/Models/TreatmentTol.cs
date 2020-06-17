using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("TreatmentTOL")]
    public partial class TreatmentTol
    {
        [Key]
        [Column("TreatmentTOLID")]
        public int TreatmentTolid { get; set; }
        [Key]
        [Column("TListItemID_FK")]
        public int TlistItemIdFk { get; set; }

        [ForeignKey(nameof(TlistItemIdFk))]
        [InverseProperty(nameof(TreatmentListItem.TreatmentTol))]
        public virtual TreatmentListItem TlistItemIdFkNavigation { get; set; }
    }
}
