using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class VwPatientDisease
    {
        [Column("PatientID")]
        public int PatientId { get; set; }
        [Required]
        [StringLength(50)]
        public string Lastname { get; set; }
        [Required]
        [StringLength(50)]
        public string Firstname { get; set; }
        [Column("InitialCareAssessmentID")]
        public int InitialCareAssessmentId { get; set; }
        [Column("DiseaseID")]
        public int DiseaseId { get; set; }
        [Required]
        [StringLength(255)]
        public string DiseaseName { get; set; }
        [Column("SystemID_FK")]
        public int SystemIdFk { get; set; }
        [StringLength(255)]
        public string System { get; set; }
        [Required]
        [StringLength(20)]
        public string Status { get; set; }
        public bool IsDeleted { get; set; }
        [Column("DiseaseSubInfoID")]
        public int? DiseaseSubInfoId { get; set; }
        [StringLength(50)]
        public string DiseaseSubInfo { get; set; }
    }
}
