using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class ExternalDoctor
    {
        public ExternalDoctor()
        {
            PatientClinician = new HashSet<PatientClinician>();
            PatientWoundVisitClinician = new HashSet<PatientWoundVisitClinician>();
        }

        [Key]
        [Column("ExternalDoctorID")]
        public int ExternalDoctorId { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("ClinicianTypeID_FK")]
        public int? ClinicianTypeIdFk { get; set; }
        [StringLength(255)]
        public string Contact { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(ClinicianTypeIdFk))]
        [InverseProperty(nameof(UserType.ExternalDoctor))]
        public virtual UserType ClinicianTypeIdFkNavigation { get; set; }
        [InverseProperty("ExternalDoctorIdFkNavigation")]
        public virtual ICollection<PatientClinician> PatientClinician { get; set; }
        [InverseProperty("ExternalDoctorIdFkNavigation")]
        public virtual ICollection<PatientWoundVisitClinician> PatientWoundVisitClinician { get; set; }
    }
}
