using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class VwTeleconsultation
    {
        [Column("TaskID")]
        public int TaskId { get; set; }
        [Column("UserID")]
        public int UserId { get; set; }
        [Column("PatientID")]
        public int? PatientId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EndDate { get; set; }
    }
}
