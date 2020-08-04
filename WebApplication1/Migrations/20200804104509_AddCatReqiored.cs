using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovies.Migrations
{
    public partial class AddCatReqiored : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Movie");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Movie",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Director",
                table: "Movie",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Movie",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category_1",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_CategoryId",
                table: "Movie",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Category_1_CategoryId",
                table: "Movie",
                column: "CategoryId",
                principalTable: "Category_1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Category_1_CategoryId",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_CategoryId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Movie");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Director",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Movie",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category_1",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
