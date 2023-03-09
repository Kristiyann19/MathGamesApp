using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MathGamesApp.Infrastructure.Migrations
{
    public partial class additionproblem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Problems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FirstDigit",
                table: "Problems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrect",
                table: "Problems",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecondDigit",
                table: "Problems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserAnswer",
                table: "Problems",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Problems");

            migrationBuilder.DropColumn(
                name: "FirstDigit",
                table: "Problems");

            migrationBuilder.DropColumn(
                name: "IsCorrect",
                table: "Problems");

            migrationBuilder.DropColumn(
                name: "SecondDigit",
                table: "Problems");

            migrationBuilder.DropColumn(
                name: "UserAnswer",
                table: "Problems");
        }
    }
}
