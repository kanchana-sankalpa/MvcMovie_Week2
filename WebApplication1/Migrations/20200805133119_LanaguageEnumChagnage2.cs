using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovies.Migrations
{
    public partial class LanaguageEnumChagnage2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Language",
                table: "Movie");

            migrationBuilder.AddColumn<int>(
                name: "Languages",
                table: "Movie",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Languages",
                table: "Movie");

            migrationBuilder.AddColumn<int>(
                name: "Language",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
