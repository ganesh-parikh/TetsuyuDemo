using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class VwPatientBilling
    {
        [Column("PatientProfileID_FK")]
        public int? PatientProfileIdFk { get; set; }
        [Required]
        [StringLength(101)]
        public string PatientName { get; set; }
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
    }
}
