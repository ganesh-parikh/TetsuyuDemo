using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_PatientMedicationConsume")]
    public partial class AuditPatientMedicationConsume
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("PatientMedicationConsumeID")]
        public int PatientMedicationConsumeId { get; set; }
        [Column("PatientMedicationID_FK")]
        public int PatientMedicationIdFk { get; set; }
        [Column("MedicationID_FK")]
        public int? MedicationIdFk { get; set; }
        [Column("RouteID_FK")]
        public int? RouteIdFk { get; set; }
        [Column("DosageID_FK")]
        public int? DosageIdFk { get; set; }
        [Column("FrequencyID_FK")]
        public int? FrequencyIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        [StringLength(255)]
        public string Indication { get; set; }
        [StringLength(200)]
        public string ReasonOfDiscontinue { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
        [Column("ChronicDiseaseID_FK")]
        public int? ChronicDiseaseIdFk { get; set; }
        [Column("ChronicDiseaseSubInfoID_FK")]
        public int? ChronicDiseaseSubInfoIdFk { get; set; }
        [Column("AcutePRNIndicationID_FK")]
        public int? AcutePrnindicationIdFk { get; set; }
        [Column("ReferID_FK")]
        public int? ReferIdFk { get; set; }
        [Column("InstructedByID_FK")]
        public int? InstructedByIdFk { get; set; }
        [StringLength(50)]
        public string DrName { get; set; }
        [StringLength(50)]
        public string DrContact { get; set; }
        [Column("MCRNo")]
        [StringLength(50)]
        public string Mcrno { get; set; }
        [StringLength(50)]
        public string ClinicHosp { get; set; }
        [Column("InstructedBy2ID_FK")]
        public int? InstructedBy2IdFk { get; set; }
        [Column("DrNameED")]
        [StringLength(50)]
        public string DrNameEd { get; set; }
        [Column("DrContactED")]
        [StringLength(50)]
        public string DrContactEd { get; set; }
        [Column("MCRNoED")]
        [StringLength(50)]
        public string McrnoEd { get; set; }
        [Column("ClinicHospED")]
        [StringLength(50)]
        public string ClinicHospEd { get; set; }
    }
}
