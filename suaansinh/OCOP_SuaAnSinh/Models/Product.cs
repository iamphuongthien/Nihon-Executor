using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OCOP_SuaAnSinh.Models
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public int Star { get; set; }
        public string BusinessAddress { get; set; }
        public string Manufacture { get; set; }
        public string Abstract { get; set; }
        [AllowHtml]
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsHot { get; set; }
        public string ImageUrl { get; set; }
        public string Contact { get; set; }
        public string SupplyOutput { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ProductCategoryId { get; set; }
        public int? OrganizationId { get; set; }
        public string Language { get; set; }
        public string PathUrl { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public virtual List<FileUpload> FileUploads { get; set; }


        public int NumberOfView { get; set; }
        public int NumberOfFavorite { get; set; }
    }
}
