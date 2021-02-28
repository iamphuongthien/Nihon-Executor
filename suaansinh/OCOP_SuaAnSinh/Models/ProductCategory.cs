using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCOP_SuaAnSinh.Models
{
    public class ProductCategory
    {
        public Guid ProductCategoryId { get; set; }
        public string Name { get; set; }
        public string PathUrl { get; set; }
        public int OrderBy { get; set; }
        public string Language { get; set; }
        public string CoverImage { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
