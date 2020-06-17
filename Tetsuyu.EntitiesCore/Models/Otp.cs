using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class Otp
    {
        [Key]
        public int OtpId { get; set; }
        public int UserId { get; set; }
        [Required]
        [StringLength(10)]
        public string Password { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
    }
}
