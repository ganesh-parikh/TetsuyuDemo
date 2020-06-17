using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class Thresholds
    {
        public Thresholds()
        {
            VitalSignRelationships = new HashSet<VitalSignRelationships>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(200)]
        public string Name { get; set; }
        [Column("minValue", TypeName = "decimal(18, 2)")]
        public decimal MinValue { get; set; }
        [Column("maxValue", TypeName = "decimal(18, 2)")]
        public decimal MaxValue { get; set; }
        [Column("isDeleted")]
        public bool IsDeleted { get; set; }
        [Column("createdBy")]
        public int? CreatedBy { get; set; }
        [Column("createdDate", TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("updatedBy")]
        public int? UpdatedBy { get; set; }
        [Column("updatedDate", TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
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

        [InverseProperty("Threshold")]
        public virtual ICollection<VitalSignRelationships> VitalSignRelationships { get; set; }
    }
}
