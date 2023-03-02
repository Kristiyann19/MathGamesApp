using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MathGamesApp.Infrastructure.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProblemTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProblemCategoryId",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProblemTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "ProblemCategoryId",
                value: 2);
        }
    }
}
