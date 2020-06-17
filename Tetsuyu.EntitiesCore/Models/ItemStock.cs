using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class ItemStock
    {
        [Key]
        [Column("ItemStockID")]
        public int ItemStockId { get; set; }
        [Column("ItemID_FK")]
        public int ItemIdFk { get; set; }
        public int Quantity { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }

        [ForeignKey(nameof(ItemIdFk))]
        [InverseProperty(nameof(Item.ItemStock))]
        public virtual Item ItemIdFkNavigation { get; set; }
    }
}
