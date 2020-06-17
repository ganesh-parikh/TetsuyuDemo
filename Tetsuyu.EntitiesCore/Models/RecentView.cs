using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class RecentView
    {
        [Key]
        [Column("UserID_FK")]
        public int UserIdFk { get; set; }
        [Key]
        [Column("PatientID_FK")]
        public int PatientIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateView { get; set; }

        [ForeignKey(nameof(PatientIdFk))]
        [InverseProperty(nameof(Patient.RecentView))]
        public virtual Patient PatientIdFkNavigation { get; set; }
        [ForeignKey(nameof(UserIdFk))]
        [InverseProperty(nameof(Users.RecentView))]
        public virtual Users UserIdFkNavigation { get; set; }
    }
}
