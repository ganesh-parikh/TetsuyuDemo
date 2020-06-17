using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class VwDoctors
    {
        public int? InternalId { get; set; }
        public int? ExternalId { get; set; }
        [Required]
        [StringLength(255)]
        public string DoctorName { get; set; }
    }
}
