using Microsoft.EntityFrameworkCore.Migrations;

namespace awwcor_web_api.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainPhotoID",
                table: "Ad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MainPhotoID",
                table: "Ad",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
