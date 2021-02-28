using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCOP_SuaAnSinh.Models
{
    public class Partner
    {
        public Guid PartnerId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
        public int OrderBy { get; set; }
        public string PathUrl { get; set; }
        public string Language { get; set; }
    }
}
