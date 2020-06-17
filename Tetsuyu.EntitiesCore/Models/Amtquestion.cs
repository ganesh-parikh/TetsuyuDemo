using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("AMTQuestion")]
    public partial class Amtquestion
    {
        public Amtquestion()
        {
            PatientAmtanswer = new HashSet<PatientAmtanswer>();
        }

        [Key]
        [Column("AMTQuestionId")]
        public int AmtquestionId { get; set; }
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

        [InverseProperty("AmtquestionIdFkNavigation")]
        public virtual ICollection<PatientAmtanswer> PatientAmtanswer { get; set; }
    }
}
