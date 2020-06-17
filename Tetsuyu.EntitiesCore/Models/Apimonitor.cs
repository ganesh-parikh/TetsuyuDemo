using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("APIMonitor")]
    public partial class Apimonitor
    {
        [Key]
        [Column("MonitorID")]
        public int MonitorId { get; set; }
        [Required]
        [Column("UUID")]
        [StringLength(36)]
        public string Uuid { get; set; }
        [Required]
        [Column("APIName")]
        [StringLength(50)]
        public string Apiname { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
    }
}
