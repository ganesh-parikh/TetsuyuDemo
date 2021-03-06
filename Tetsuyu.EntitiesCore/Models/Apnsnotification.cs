﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("APNSNotification")]
    public partial class Apnsnotification
    {
        [Key]
        public int Id { get; set; }
        [StringLength(1000)]
        public string NotificationMessage { get; set; }
        [StringLength(300)]
        public string NotificationTitle { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }
        public bool? SentStatus { get; set; }
        public bool? IsCritical { get; set; }
        [Column("TaskID")]
        public int? TaskId { get; set; }
    }
}
