using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Headings_Categories_CategoryId",
                table: "Headings");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Headings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "WriterId",
                table: "Headings",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HeadingId",
                table: "Contents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "WriterID",
                table: "Contents",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Headings_WriterId",
                table: "Headings",
                column: "WriterId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_HeadingId",
                table: "Contents",
                column: "HeadingId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_WriterID",
                table: "Contents",
                column: "WriterID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Headings_HeadingId",
                table: "Contents",
                column: "HeadingId",
                principalTable: "Headings",
                principalColumn: "HeadingId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contents_Writers_WriterID",
                table: "Contents",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Headings_Categories_CategoryId",
                table: "Headings",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Headings_Writers_WriterId",
                table: "Headings",
                column: "WriterId",
                principalTable: "Writers",
                principalColumn: "WriterId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Headings_HeadingId",
                table: "Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_Contents_Writers_WriterID",
                table: "Contents");

            migrationBuilder.DropForeignKey(
                name: "FK_Headings_Categories_CategoryId",
                table: "Headings");

            migrationBuilder.DropForeignKey(
                name: "FK_Headings_Writers_WriterId",
                table: "Headings");

            migrationBuilder.DropIndex(
                name: "IX_Headings_WriterId",
                table: "Headings");

            migrationBuilder.DropIndex(
                name: "IX_Contents_HeadingId",
                table: "Contents");

            migrationBuilder.DropIndex(
                name: "IX_Contents_WriterID",
                table: "Contents");

            migrationBuilder.DropColumn(
                name: "WriterId",
                table: "Headings");

            migrationBuilder.DropColumn(
                name: "WriterID",
                table: "Contents");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Headings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HeadingId",
                table: "Contents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Headings_Categories_CategoryId",
                table: "Headings",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
