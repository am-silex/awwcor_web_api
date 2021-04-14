using Microsoft.EntityFrameworkCore.Migrations;

namespace awwcor_web_api.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdId",
                table: "Photo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Photo_AdId",
                table: "Photo",
                column: "AdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Ad_AdId",
                table: "Photo",
                column: "AdId",
                principalTable: "Ad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Ad_AdId",
                table: "Photo");

            migrationBuilder.DropIndex(
                name: "IX_Photo_AdId",
                table: "Photo");

            migrationBuilder.DropColumn(
                name: "AdId",
                table: "Photo");
        }
    }
}
