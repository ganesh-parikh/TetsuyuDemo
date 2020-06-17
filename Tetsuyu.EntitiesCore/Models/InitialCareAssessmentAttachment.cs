﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class InitialCareAssessmentAttachment
    {
        [Key]
        [Column("InitialCareAssessmentAttachmentID")]
        public int InitialCareAssessmentAttachmentId { get; set; }
        [Column("InitialCareAssessmentID_FK")]
        public int InitialCareAssessmentIdFk { get; set; }
        [StringLength(255)]
        public string Filename { get; set; }
        [StringLength(50)]
        public string Physical { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("CreatedBy_FK")]
        public int? CreatedByFk { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("ModifiedBy_FK")]
        public int? ModifiedByFk { get; set; }
        public bool IsReferralAssessment { get; set; }
        public bool IsDischargeAssessment { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey(nameof(InitialCareAssessmentIdFk))]
        [InverseProperty(nameof(InitialCareAssessment.InitialCareAssessmentAttachment))]
        public virtual InitialCareAssessment InitialCareAssessmentIdFkNavigation { get; set; }
    }
}
