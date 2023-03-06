using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MathGamesApp.Infrastructure.Migrations
{
    public partial class diffLevel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageRating",
                table: "Problems");

            migrationBuilder.DropColumn(
                name: "CorrectAnswer",
                table: "Problems");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Problems");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Problems");

            migrationBuilder.RenameColumn(
                name: "DifficultyLevel",
                table: "Problems",
                newName: "DifficultyLevelId");

            migrationBuilder.AddColumn<int>(
                name: "Answer",
                table: "Problems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DifficultyLevels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DifficultyLevels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "DifficultyLevels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "1st Grade" },
                    { 2, "2nd Grade" },
                    { 3, "3th Grade" },
                    { 4, "4th Grade" },
                    { 5, "5th Grade" },
                    { 6, "6th Grade" },
                    { 7, "7th Grade" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Problems_DifficultyLevelId",
                table: "Problems",
                column: "DifficultyLevelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Problems_DifficultyLevels_DifficultyLevelId",
                table: "Problems",
                column: "DifficultyLevelId",
                principalTable: "DifficultyLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Problems_DifficultyLevels_DifficultyLevelId",
                table: "Problems");

            migrationBuilder.DropTable(
                name: "DifficultyLevels");

            migrationBuilder.DropIndex(
                name: "IX_Problems_DifficultyLevelId",
                table: "Problems");

            migrationBuilder.DropColumn(
                name: "Answer",
                table: "Problems");

            migrationBuilder.RenameColumn(
                name: "DifficultyLevelId",
                table: "Problems",
                newName: "DifficultyLevel");

            migrationBuilder.AddColumn<double>(
                name: "AverageRating",
                table: "Problems",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "CorrectAnswer",
                table: "Problems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Problems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Problems",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
