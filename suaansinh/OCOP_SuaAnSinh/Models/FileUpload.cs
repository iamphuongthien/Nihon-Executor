using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OCOP_SuaAnSinh.Models
{
    public class FileUpload
    {
        public Guid FileUploadId { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public string FileName { get; set; }
        public long? FileSize { get; set; }
        public bool IsFile { get; set; }
        public DateTime UploadDate { get; set; }
        public Guid? UserId { get; set; }
        public Guid? ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
