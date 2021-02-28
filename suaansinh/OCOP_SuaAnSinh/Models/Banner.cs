using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCOP_SuaAnSinh.Models
{
    public class Banner
    {
        public Guid BannerId { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int Position { get; set; }
        public int OrderBy { get; set; }
        public string Language { get; set; }
    }
}
