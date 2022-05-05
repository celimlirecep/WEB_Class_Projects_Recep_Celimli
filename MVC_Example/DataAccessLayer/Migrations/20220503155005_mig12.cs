using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Writers_WriterID",
                table: "Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_Headings_Writers_WriterId",
                table: "Headings");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Writers_WriterID",
                table: "Contents",
                column: "WriterID",
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
                name: "FK_Contents_Writers_WriterID",
                table: "Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_Headings_Writers_WriterId",
                table: "Headings");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Writers_WriterID",
                table: "Contents",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Headings_Writers_WriterId",
                table: "Headings",
                column: "WriterId",
                principalTable: "Writers",
                principalColumn: "WriterId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
