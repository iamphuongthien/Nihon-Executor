using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OCOP_SuaAnSinh.Data.Migrations
{
    public partial class addtableentitytodb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    BannerId = table.Column<Guid>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TenantId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    OrderBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.BannerId);
                });

            migrationBuilder.CreateTable(
                name: "MenuLists",
                columns: table => new
                {
                    MenuListId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ParentId = table.Column<Guid>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Link = table.Column<string>(nullable: true),
                    OrderBy = table.Column<int>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    TenantId = table.Column<int>(nullable: false),
                    Language = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    CategoryType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuLists", x => x.MenuListId);
                });

            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    PartnerId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    OrderBy = table.Column<int>(nullable: false),
                    PathUrl = table.Column<string>(nullable: true),
                    TenantId = table.Column<int>(nullable: false),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.PartnerId);
                });

            migrationBuilder.CreateTable(
                name: "PostCategories",
                columns: table => new
                {
                    PostCategoryId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    OrderBy = table.Column<int>(nullable: false),
                    PathUrl = table.Column<string>(nullable: true),
                    TenantId = table.Column<int>(nullable: false),
                    Language = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCategories", x => x.PostCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductCategoryId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PathUrl = table.Column<string>(nullable: true),
                    OrderBy = table.Column<int>(nullable: false),
                    TenantId = table.Column<int>(nullable: false),
                    Language = table.Column<string>(nullable: true),
                    CoverImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.ProductCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Abstract = table.Column<string>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    ContentHTML = table.Column<string>(nullable: false),
                    Tags = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: false),
                    PostCategoryId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true),
                    IsPublish = table.Column<bool>(nullable: false),
                    IsHot = table.Column<bool>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    PathUrl = table.Column<string>(nullable: true),
                    TenantId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    ModifyDate = table.Column<DateTime>(nullable: true),
                    ModifyBy = table.Column<Guid>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsConstance = table.Column<bool>(nullable: false),
                    NumberOfView = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_PostCategories_PostCategoryId",
                        column: x => x.PostCategoryId,
                        principalTable: "PostCategories",
                        principalColumn: "PostCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Star = table.Column<int>(nullable: false),
                    BusinessAddress = table.Column<string>(nullable: true),
                    Manufacture = table.Column<string>(nullable: true),
                    Abstract = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsHot = table.Column<bool>(nullable: false),
                    TenantId = table.Column<int>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    SupplyOutput = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ProductCategoryId = table.Column<Guid>(nullable: false),
                    OrganizationId = table.Column<int>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    PathUrl = table.Column<string>(nullable: true),
                    NumberOfView = table.Column<int>(nullable: false),
                    NumberOfFavorite = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "ProductCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FileUploads",
                columns: table => new
                {
                    FileUploadId = table.Column<Guid>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(nullable: true),
                    FileSize = table.Column<long>(nullable: true),
                    IsFile = table.Column<bool>(nullable: false),
                    TenantId = table.Column<int>(nullable: false),
                    UploadDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true),
                    ProductId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileUploads", x => x.FileUploadId);
                    table.ForeignKey(
                        name: "FK_FileUploads_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FileUploads_ProductId",
                table: "FileUploads",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostCategoryId",
                table: "Posts",
                column: "PostCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "FileUploads");

            migrationBuilder.DropTable(
                name: "MenuLists");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "PostCategories");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
