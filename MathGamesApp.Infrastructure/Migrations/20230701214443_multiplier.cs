using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MathGamesApp.Infrastructure.Migrations
{
    public partial class multiplier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProblemTypes",
                columns: new[] { "Id", "ImageUrl", "Instruction", "IsActive", "Name", "ProblemCategoryId" },
                values: new object[] { 3, "https://www.pngwing.com/en/free-png-mloer", "Multiply the first number with the second", false, "Multiplication", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProblemTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
