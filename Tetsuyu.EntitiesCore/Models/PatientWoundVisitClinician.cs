using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientWoundVisitClinician
    {
        [Key]
        [Column("PatientWoundVisitClinicianID")]
        public int PatientWoundVisitClinicianId { get; set; }
        [Column("PatientWoundVisitID_FK")]
        public int? PatientWoundVisitIdFk { get; set; }
        [Column("UserID_FK")]
        public int? UserIdFk { get; set; }
        [Column("ExternalDoctorID_FK")]
        public int? ExternalDoctorIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(ExternalDoctorIdFk))]
        [InverseProperty(nameof(ExternalDoctor.PatientWoundVisitClinician))]
        public virtual ExternalDoctor ExternalDoctorIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientWoundVisitIdFk))]
        [InverseProperty(nameof(PatientWoundVisit.PatientWoundVisitClinician))]
        public virtual PatientWoundVisit PatientWoundVisitIdFkNavigation { get; set; }
        [ForeignKey(nameof(UserIdFk))]
        [InverseProperty(nameof(Users.PatientWoundVisitClinician))]
        public virtual Users UserIdFkNavigation { get; set; }
    }
}
