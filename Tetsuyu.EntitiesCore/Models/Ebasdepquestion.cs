using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("EBASDEPQuestion")]
    public partial class Ebasdepquestion
    {
        public Ebasdepquestion()
        {
            PatientEbasdepanswer = new HashSet<PatientEbasdepanswer>();
        }

        [Key]
        [Column("EBASDEPQuestionId")]
        public int EbasdepquestionId { get; set; }
        [Required]
        [StringLength(255)]
        public string Question { get; set; }
        public int? Ordering { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }

        [InverseProperty("EbasdepquestionIdFkNavigation")]
        public virtual ICollection<PatientEbasdepanswer> PatientEbasdepanswer { get; set; }
    }
}
