using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class VwPatientLatestVitalSigns
    {
        public int PatientId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime VitalSignDate { get; set; }
        public int VitalSignDetailId { get; set; }
        public int VitalSignTypeId { get; set; }
        [Required]
        [StringLength(200)]
        public string VitalSignTypeName { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Value { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ThresholdMinValue { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? ThresholdMaxValue { get; set; }
        [Column("ews_min_1", TypeName = "decimal(18, 2)")]
        public decimal? EwsMin1 { get; set; }
        [Column("ews_max_1", TypeName = "decimal(18, 2)")]
        public decimal? EwsMax1 { get; set; }
        [Column("ews_min_2", TypeName = "decimal(18, 2)")]
        public decimal? EwsMin2 { get; set; }
        [Column("ews_max_2", TypeName = "decimal(18, 2)")]
        public decimal? EwsMax2 { get; set; }
        [Column("ews_min_3", TypeName = "decimal(18, 2)")]
        public decimal? EwsMin3 { get; set; }
        [Column("ews_max_3", TypeName = "decimal(18, 2)")]
        public decimal? EwsMax3 { get; set; }
        [Column("ews_min_4", TypeName = "decimal(18, 2)")]
        public decimal? EwsMin4 { get; set; }
        [Column("ews_max_4", TypeName = "decimal(18, 2)")]
        public decimal? EwsMax4 { get; set; }
        [Column("ews_min_5", TypeName = "decimal(18, 2)")]
        public decimal? EwsMin5 { get; set; }
        [Column("ews_max_5", TypeName = "decimal(18, 2)")]
        public decimal? EwsMax5 { get; set; }
        [Column("ews_min_6", TypeName = "decimal(18, 2)")]
        public decimal? EwsMin6 { get; set; }
        [Column("ews_max_6", TypeName = "decimal(18, 2)")]
        public decimal? EwsMax6 { get; set; }
        [Column("ews_min_7", TypeName = "decimal(18, 2)")]
        public decimal? EwsMin7 { get; set; }
        [Column("ews_max_7", TypeName = "decimal(18, 2)")]
        public decimal? EwsMax7 { get; set; }
        public long? Index { get; set; }
    }
}
