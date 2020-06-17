using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class AuditTrail
    {
        [Key]
        public int AuditTrailId { get; set; }
        [Required]
        public string AuditAction { get; set; }
        [StringLength(255)]
        public string Module { get; set; }
        [Required]
        [StringLength(50)]
        public string Event { get; set; }
        [Column("IPAddress")]
        [StringLength(20)]
        public string Ipaddress { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column("APIRequest")]
        public string Apirequest { get; set; }

        [ForeignKey(nameof(CreatedByFk))]
        [InverseProperty(nameof(Users.AuditTrail))]
        public virtual Users CreatedByFkNavigation { get; set; }
    }
}
