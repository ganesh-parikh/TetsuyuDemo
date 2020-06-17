using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class VwPatientWoundImageDownload
    {
        [StringLength(265)]
        public string NewImageName { get; set; }
        [Column("PatientID")]
        public int PatientId { get; set; }
        [Required]
        [StringLength(50)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }
        [Column("PatientWoundID")]
        public int PatientWoundId { get; set; }
        [StringLength(50)]
        public string LocationOfWound { get; set; }
        [Required]
        [StringLength(50)]
        public string Site { get; set; }
        [Column("PatientWoundVisitID")]
        public int PatientWoundVisitId { get; set; }
        [StringLength(30)]
        public string ImageDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? VisitDate { get; set; }
        [StringLength(50)]
        public string ImageUpload { get; set; }
    }
}
