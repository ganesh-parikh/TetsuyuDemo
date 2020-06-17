using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class VwAssessmentDue
    {
        [Column("patientId")]
        public int PatientId { get; set; }
        [Required]
        [Column("source")]
        [StringLength(200)]
        public string Source { get; set; }
        [Column("icaId")]
        public int IcaId { get; set; }
        [Column("createdDate", TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("createdBy")]
        public int? CreatedBy { get; set; }
        [Column("updatedDate", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
        [Column("updatedBy")]
        public int? UpdatedBy { get; set; }
        [Required]
        [StringLength(200)]
        public string AssessmentName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
    }
}
