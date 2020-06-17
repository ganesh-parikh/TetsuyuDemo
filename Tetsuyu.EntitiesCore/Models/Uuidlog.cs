using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("UUIDLog")]
    public partial class Uuidlog
    {
        [Key]
        [Column("UUIDLogID")]
        public int UuidlogId { get; set; }
        [Column("UUID")]
        [StringLength(255)]
        public string Uuid { get; set; }
        public bool? IsUpdated { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column("PatientWoundVisitID")]
        public int? PatientWoundVisitId { get; set; }
    }
}
