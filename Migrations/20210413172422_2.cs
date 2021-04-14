using Microsoft.EntityFrameworkCore.Migrations;

namespace awwcor_web_api.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Photo",
                table: "Photo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Photo_Photo",
                table: "Photo",
                column: "Photo");

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Ad_Photo",
                table: "Photo",
                column: "Photo",
                principalTable: "Ad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Ad_Photo",
                table: "Photo");

            migrationBuilder.DropIndex(
                name: "IX_Photo_Photo",
                table: "Photo");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Photo");
        }
    }
}
