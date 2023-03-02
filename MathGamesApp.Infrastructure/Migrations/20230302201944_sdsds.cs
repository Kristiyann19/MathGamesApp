using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MathGamesApp.Infrastructure.Migrations
{
    public partial class sdsds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProblemTypes_ProblemCategories_ProblemCategoryId",
                table: "ProblemTypes");

            migrationBuilder.AddForeignKey(
                name: "FK_ProblemTypes_ProblemCategories_ProblemCategoryId",
                table: "ProblemTypes",
                column: "ProblemCategoryId",
                principalTable: "ProblemCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProblemTypes_ProblemCategories_ProblemCategoryId",
                table: "ProblemTypes");

            migrationBuilder.AddForeignKey(
                name: "FK_ProblemTypes_ProblemCategories_ProblemCategoryId",
                table: "ProblemTypes",
                column: "ProblemCategoryId",
                principalTable: "ProblemCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
