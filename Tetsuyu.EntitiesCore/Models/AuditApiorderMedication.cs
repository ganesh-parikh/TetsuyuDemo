using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    [Table("Audit_APIOrderMedication")]
    public partial class AuditApiorderMedication
    {
        [Required]
        [StringLength(5)]
        public string AuditAction { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [Column("APIOrderMedicationID")]
        public int ApiorderMedicationId { get; set; }
        [Column("APIOrderID_FK")]
        public int ApiorderIdFk { get; set; }
        [Column("MedicationID")]
        public int? MedicationId { get; set; }
        [StringLength(255)]
        public string MedicationName { get; set; }
        [StringLength(60)]
        public string MedicationStatus { get; set; }
        public int? MedicationQuantity { get; set; }
        [StringLength(60)]
        public string MedicationQuantityUnit { get; set; }
        [Column("MedicationFrequencyID")]
        public int? MedicationFrequencyId { get; set; }
        public int? MedicationFrequency { get; set; }
        public int? MedicationPeriod { get; set; }
        [StringLength(60)]
        public string MedicationPeriodUnit { get; set; }
        public bool? MedicationAsNeeded { get; set; }
        [StringLength(255)]
        public string MedicationDisplay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsDeleted { get; set; }
        [Column("DosageID_FK")]
        public int? DosageIdFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
    }
}
