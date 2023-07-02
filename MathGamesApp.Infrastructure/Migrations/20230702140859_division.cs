using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MathGamesApp.Infrastructure.Migrations
{
    public partial class division : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProblemTypes",
                columns: new[] { "Id", "ImageUrl", "Instruction", "IsActive", "Name", "ProblemCategoryId" },
                values: new object[] { 4, "https://www.pngwing.com/en/free-png-mloer", "Divise the first number with the second", false, "Division", 1 });

            migrationBuilder.InsertData(
                table: "DifficultyLevels",
                columns: new[] { "Id", "Name", "ProblemTypeId" },
                values: new object[,]
                {
                    { 22, "1st Grade", 4 },
                    { 23, "2nd Grade", 4 },
                    { 24, "3th Grade", 4 },
                    { 25, "4th Grade", 4 },
                    { 26, "5th Grade", 4 },
                    { 27, "6th Grade", 4 },
                    { 28, "7th Grade", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProblemTypes",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
