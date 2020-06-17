using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class Item
    {
        public Item()
        {
            BillingInvoiceConsumable = new HashSet<BillingInvoiceConsumable>();
            ItemStock = new HashSet<ItemStock>();
            PatientWoundVisitTreatment = new HashSet<PatientWoundVisitTreatment>();
        }

        [Key]
        [Column("ItemID")]
        public int ItemId { get; set; }
        [Required]
        [StringLength(255)]
        public string ItemName { get; set; }
        [Column("CategoryID_FK")]
        public int CategoryIdFk { get; set; }
        [Column("ItemUnitID_FK")]
        public int ItemUnitIdFk { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal UnitPrice { get; set; }
        public bool? AvailableInBilling { get; set; }
        public bool IsDeleted { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }

        [ForeignKey(nameof(CategoryIdFk))]
        [InverseProperty(nameof(Code.ItemCategoryIdFkNavigation))]
        public virtual Code CategoryIdFkNavigation { get; set; }
        [ForeignKey(nameof(ItemUnitIdFk))]
        [InverseProperty(nameof(Code.ItemItemUnitIdFkNavigation))]
        public virtual Code ItemUnitIdFkNavigation { get; set; }
        [InverseProperty("ItemIdFkNavigation")]
        public virtual ICollection<BillingInvoiceConsumable> BillingInvoiceConsumable { get; set; }
        [InverseProperty("ItemIdFkNavigation")]
        public virtual ICollection<ItemStock> ItemStock { get; set; }
        [InverseProperty("ItemIdFkNavigation")]
        public virtual ICollection<PatientWoundVisitTreatment> PatientWoundVisitTreatment { get; set; }
    }
}
