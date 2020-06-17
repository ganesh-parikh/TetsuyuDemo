using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class RegisteredDevice
    {
        [Column("DeviceID")]
        public int DeviceId { get; set; }
        public int? DeviceType { get; set; }
        [StringLength(300)]
        public string DeviceToken { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }
        public bool? Status { get; set; }
    }
}
