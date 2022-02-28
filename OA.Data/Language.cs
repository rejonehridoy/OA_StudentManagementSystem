using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace OA.Data
{
    [Table("Language")]
    public partial class Language
    {
        public Language()
        {
            LocalizedProperties = new HashSet<LocalizedProperty>();
        }
        [Key]
        public int LanguageId { get; set; }
        [Required]
        [StringLength(20)]
        [DisplayName("Language Name")]
        public string Name { get; set; }

        [InverseProperty(nameof(LocalizedProperty.Language))]
        public virtual ICollection<LocalizedProperty> LocalizedProperties { get; set; }
    }
}
