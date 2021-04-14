using Microsoft.EntityFrameworkCore.Migrations;

namespace awwcor_web_api.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Ad_AdId",
                table: "Photo");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Ad_Photo",
                table: "Photo");

            migrationBuilder.DropIndex(
                name: "IX_Photo_AdId",
                table: "Photo");

            migrationBuilder.DropIndex(
                name: "IX_Photo_Photo",
                table: "Photo");

            migrationBuilder.DropColumn(
                name: "AdId",
                table: "Photo");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "Photo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdId",
                table: "Photo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Photo",
                table: "Photo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Photo_AdId",
                table: "Photo",
                column: "AdId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_Photo",
                table: "Photo",
                column: "Photo");

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Ad_AdId",
                table: "Photo",
                column: "AdId",
                principalTable: "Ad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Ad_Photo",
                table: "Photo",
                column: "Photo",
                principalTable: "Ad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
