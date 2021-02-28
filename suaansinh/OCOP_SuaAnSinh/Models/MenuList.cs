using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OCOP_SuaAnSinh.Models
{
    public class MenuList
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid MenuListId { get; set; }
        public string Name { get; set; }
        public Guid? ParentId { get; set; }
        public bool IsActive { get; set; }
        public string Link { get; set; }
        public int OrderBy { get; set; }
        public int Position { get; set; }
        public int Level { get; set; }
        public string Language { get; set; }
        public string Icon { get; set; }
        //1: post; 2: product; 3: link; 4: custom
        public int CategoryType { get; set; }
    }
}
