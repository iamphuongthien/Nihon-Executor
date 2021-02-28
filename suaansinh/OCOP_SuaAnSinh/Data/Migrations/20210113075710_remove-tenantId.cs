using Microsoft.EntityFrameworkCore.Migrations;

namespace OCOP_SuaAnSinh.Data.Migrations
{
    public partial class removetenantId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "PostCategories");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Partners");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "MenuLists");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "FileUploads");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Banners");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Banners",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "Banners");

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "ProductCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "PostCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "Partners",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "MenuLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "FileUploads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "Banners",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
