using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class Resource
    {
        [Key]
        public int ResourceId { get; set; }
        public int CodeId { get; set; }
        public int LanguageId { get; set; }
        public string CodeValue { get; set; }
        public string Details { get; set; }

        [ForeignKey(nameof(CodeId))]
        [InverseProperty("Resource")]
        public virtual Code Code { get; set; }
        [ForeignKey(nameof(LanguageId))]
        [InverseProperty("Resource")]
        public virtual Language Language { get; set; }
    }
}
