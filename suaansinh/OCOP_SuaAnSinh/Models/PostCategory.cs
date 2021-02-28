using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OCOP_SuaAnSinh.Models
{
    public class PostCategory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid PostCategoryId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int OrderBy { get; set; }
        public string PathUrl { get; set; }
        public string Language { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}
