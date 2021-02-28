using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OCOP_SuaAnSinh.Models
{
    public class Post
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid PostId { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập trường thông tin")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập trường thông tin")]
        public string Abstract { get; set; }
        public string Content { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập trường thông tin")]
        [AllowHtml]
        public string ContentHTML { get; set; }
        public string Tags { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập trường thông tin")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập trường thông tin")]
        public Guid PostCategoryId { get; set; }
        public Guid? UserId { get; set; }
        public bool IsPublish { get; set; }
        public bool IsHot { get; set; }
        public string ImageUrl { get; set; }
        public string PathUrl { get; set; }
        public virtual PostCategory PostCategory { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập trường thông tin")]
        public DateTime Date { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public Guid? ModifyBy { get; set; }
        public string Language { get; set; }
        public int Status { get; set; }
        public bool IsActive { get; set; }
        public bool IsConstance { get; set; }

        public int NumberOfView { get; set; }
    }
}
