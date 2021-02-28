using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OCOP_SuaAnSinh.Models;

namespace OCOP_SuaAnSinh.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<MenuList> MenuLists { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<FileUpload> FileUploads { get; set; }
    }
}
