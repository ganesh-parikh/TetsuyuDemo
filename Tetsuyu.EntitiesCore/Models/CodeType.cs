using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class CodeType
    {
        public CodeType()
        {
            Code = new HashSet<Code>();
        }

        [Key]
        public int CodeTypeId { get; set; }
        [Required]
        [StringLength(255)]
        public string CodeTypeName { get; set; }
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

        [InverseProperty("CodeTypeIdFkNavigation")]
        public virtual ICollection<Code> Code { get; set; }
    }
}
