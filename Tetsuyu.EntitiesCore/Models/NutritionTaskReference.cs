using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class NutritionTaskReference
    {
        public NutritionTaskReference()
        {
            NutritionTaskAmountReferenceIdFkNavigation = new HashSet<NutritionTask>();
            NutritionTaskColorReferenceIdFkNavigation = new HashSet<NutritionTask>();
            NutritionTaskTypeReferenceIdFkNavigation = new HashSet<NutritionTask>();
        }

        [Key]
        [Column("ReferenceID")]
        public int ReferenceId { get; set; }
        [Column("CodeId_FK")]
        public int CodeIdFk { get; set; }
        [StringLength(50)]
        public string ReferenceImage { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
        public int? Value { get; set; }

        [ForeignKey(nameof(CodeIdFk))]
        [InverseProperty(nameof(Code.NutritionTaskReference))]
        public virtual Code CodeIdFkNavigation { get; set; }
        [InverseProperty(nameof(NutritionTask.AmountReferenceIdFkNavigation))]
        public virtual ICollection<NutritionTask> NutritionTaskAmountReferenceIdFkNavigation { get; set; }
        [InverseProperty(nameof(NutritionTask.ColorReferenceIdFkNavigation))]
        public virtual ICollection<NutritionTask> NutritionTaskColorReferenceIdFkNavigation { get; set; }
        [InverseProperty(nameof(NutritionTask.TypeReferenceIdFkNavigation))]
        public virtual ICollection<NutritionTask> NutritionTaskTypeReferenceIdFkNavigation { get; set; }
    }
}
