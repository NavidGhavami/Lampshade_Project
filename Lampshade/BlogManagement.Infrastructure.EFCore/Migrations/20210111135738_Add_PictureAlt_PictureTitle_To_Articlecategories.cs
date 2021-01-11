using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogManagement.Infrastructure.EFCore.Migrations
{
    public partial class Add_PictureAlt_PictureTitle_To_Articlecategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PictureAlt",
                table: "ArticleCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PictureTitle",
                table: "ArticleCategories",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureAlt",
                table: "ArticleCategories");

            migrationBuilder.DropColumn(
                name: "PictureTitle",
                table: "ArticleCategories");
        }
    }
}
