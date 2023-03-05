using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MathGamesApp.Infrastructure.Migrations
{
    public partial class correctAnswer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Problems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "CorrectAnswer",
                table: "Problems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorrectAnswer",
                table: "Problems");

            migrationBuilder.InsertData(
                table: "Problems",
                columns: new[] { "Id", "AverageRating", "Description", "DifficultyLevel", "ImageUrl", "Instruction", "IsActive", "ProblemCategoryId", "ProblemTypeId" },
                values: new object[] { 1, 5.0, "s", 1, "https://www.theschoolrun.com/sites/theschoolrun.com/files/article_images/addition.jpg", "test", true, 1, 1 });
        }
    }
}
