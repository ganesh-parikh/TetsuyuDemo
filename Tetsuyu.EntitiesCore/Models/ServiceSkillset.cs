using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class ServiceSkillset
    {
        [Key]
        [Column("ServiceID_FK")]
        public int ServiceIdFk { get; set; }
        [Key]
        [Column("SkillsetID_FK")]
        public int SkillsetIdFk { get; set; }

        [ForeignKey(nameof(ServiceIdFk))]
        [InverseProperty(nameof(Code.ServiceSkillsetServiceIdFkNavigation))]
        public virtual Code ServiceIdFkNavigation { get; set; }
        [ForeignKey(nameof(SkillsetIdFk))]
        [InverseProperty(nameof(Code.ServiceSkillsetSkillsetIdFkNavigation))]
        public virtual Code SkillsetIdFkNavigation { get; set; }
    }
}
