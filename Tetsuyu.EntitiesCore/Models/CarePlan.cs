using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class CarePlan
    {
        public CarePlan()
        {
            CarePlanSub = new HashSet<CarePlanSub>();
            CareReport = new HashSet<CareReport>();
        }

        [Key]
        [Column("CarePlanID")]
        public int CarePlanId { get; set; }
        [Column("PatientID_FK")]
        public int? PatientIdFk { get; set; }
        [Column("DiagnosisID_FK")]
        public int? DiagnosisIdFk { get; set; }
        [Column("CarePlanStatusID_FK")]
        public int? CarePlanStatusIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool? IsDeleted { get; set; }
        [Column("InitialCareAssessmentID_FK")]
        public int? InitialCareAssessmentIdFk { get; set; }
        [Column("CarePlanDetailID_FK")]
        public int? CarePlanDetailIdFk { get; set; }
        [StringLength(50)]
        public string CarePlanName { get; set; }
        public bool? IsClosed { get; set; }
        public int? PersonInCharge { get; set; }
        [StringLength(50)]
        public string CarePlanType { get; set; }
        [StringLength(500)]
        public string Remark { get; set; }

        [ForeignKey(nameof(CarePlanStatusIdFk))]
        [InverseProperty(nameof(CarePlanStatus.CarePlan))]
        public virtual CarePlanStatus CarePlanStatusIdFkNavigation { get; set; }
        [ForeignKey(nameof(DiagnosisIdFk))]
        [InverseProperty(nameof(Diagnosis.CarePlan))]
        public virtual Diagnosis DiagnosisIdFkNavigation { get; set; }
        [ForeignKey(nameof(PatientIdFk))]
        [InverseProperty(nameof(Patient.CarePlan))]
        public virtual Patient PatientIdFkNavigation { get; set; }
        [InverseProperty("CarePlanIdFkNavigation")]
        public virtual ICollection<CarePlanSub> CarePlanSub { get; set; }
        [InverseProperty("CarePlanIdFkNavigation")]
        public virtual ICollection<CareReport> CareReport { get; set; }
    }
}
