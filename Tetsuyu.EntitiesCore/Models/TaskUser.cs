using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class TaskUser
    {
        [Key]
        [Column("TaskUserID")]
        public int TaskUserId { get; set; }
        [Column("TaskID_FK")]
        public int TaskIdFk { get; set; }
        [Column("UserID_FK")]
        public int UserIdFk { get; set; }
        [Required]
        [StringLength(20)]
        public string UserType { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(TaskIdFk))]
        [InverseProperty(nameof(Task.TaskUser))]
        public virtual Task TaskIdFkNavigation { get; set; }
        [ForeignKey(nameof(UserIdFk))]
        [InverseProperty(nameof(Users.TaskUser))]
        public virtual Users UserIdFkNavigation { get; set; }
    }
}
