using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class PatientProfile
    {
        public PatientProfile()
        {
            InitialCareAssessment = new HashSet<InitialCareAssessment>();
            Patient = new HashSet<Patient>();
        }

        [Key]
        [Column("PatientProfileID")]
        public int PatientProfileId { get; set; }
        [Column("BloodTypeID_FK")]
        public int? BloodTypeIdFk { get; set; }
        [Column("ReligionID_FK")]
        public int? ReligionIdFk { get; set; }
        [StringLength(20)]
        public string MobilePhone { get; set; }
        [StringLength(20)]
        public string HomePhone { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string BillingAddress1 { get; set; }
        [StringLength(255)]
        public string BillingAddress2 { get; set; }
        [StringLength(255)]
        public string BillingAddress3 { get; set; }
        [StringLength(10)]
        public string BillingPostalCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        [StringLength(255)]
        public string OtherReligion { get; set; }
        [StringLength(255)]
        public string Organization { get; set; }
        [StringLength(255)]
        public string Location { get; set; }
        [StringLength(255)]
        public string Ward { get; set; }
        [StringLength(255)]
        public string Bed { get; set; }
        [StringLength(500)]
        public string Note { get; set; }

        [ForeignKey(nameof(BloodTypeIdFk))]
        [InverseProperty(nameof(Code.PatientProfileBloodTypeIdFkNavigation))]
        public virtual Code BloodTypeIdFkNavigation { get; set; }
        [ForeignKey(nameof(ReligionIdFk))]
        [InverseProperty(nameof(Code.PatientProfileReligionIdFkNavigation))]
        public virtual Code ReligionIdFkNavigation { get; set; }
        [InverseProperty("PatientProfileIdFkNavigation")]
        public virtual ICollection<InitialCareAssessment> InitialCareAssessment { get; set; }
        [InverseProperty("PatientProfileIdFkNavigation")]
        public virtual ICollection<Patient> Patient { get; set; }
    }
}
