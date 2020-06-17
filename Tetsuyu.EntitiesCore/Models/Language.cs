using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tetsuyu.EntitiesCore.Models
{
    public partial class Language
    {
        public Language()
        {
            Resource = new HashSet<Resource>();
        }

        [Key]
        public int LanguageId { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [StringLength(500)]
        public string FullName { get; set; }

        [InverseProperty("Language")]
        public virtual ICollection<Resource> Resource { get; set; }
    }
}
