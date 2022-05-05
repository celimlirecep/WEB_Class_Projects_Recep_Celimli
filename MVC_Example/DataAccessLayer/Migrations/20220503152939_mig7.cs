using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Headings_HeadingId",
                table: "Contents");

            migrationBuilder.DropIndex(
                name: "IX_Contents_HeadingId",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "WriterID",
                table: "Contents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WriterID",
                table: "Contents",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contents_HeadingId",
                table: "Contents",
                column: "HeadingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Headings_HeadingId",
                table: "Contents",
                column: "HeadingId",
                principalTable: "Headings",
                principalColumn: "HeadingId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
