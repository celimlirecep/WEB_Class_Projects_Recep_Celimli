using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class g1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Writers_WriterId",
                table: "Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_Headings_Writers_WriterId",
                table: "Headings");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Writers_WriterId",
                table: "Contents",
                column: "WriterId",
                principalTable: "Writers",
                principalColumn: "WriterId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Headings_Writers_WriterId",
                table: "Headings",
                column: "WriterId",
                principalTable: "Writers",
                principalColumn: "WriterId",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Writers_WriterId",
                table: "Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_Headings_Writers_WriterId",
                table: "Headings");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Writers_WriterId",
                table: "Contents",
                column: "WriterId",
                principalTable: "Writers",
                principalColumn: "WriterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Headings_Writers_WriterId",
                table: "Headings",
                column: "WriterId",
                principalTable: "Writers",
                principalColumn: "WriterId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
