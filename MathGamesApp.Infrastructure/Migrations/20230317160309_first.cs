﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MathGamesApp.Infrastructure.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProblemCategories",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[] { 1, "Traditional operations on numbers - addition, subtraction, multiplication, division, exponentiation", "https://media.proprofs.com/images/QM/user_images/2169923/1514977691.jpg", "Arithmetic" });

            migrationBuilder.InsertData(
                table: "ProblemCategories",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[] { 2, "Algebra deals with the manipulation of variables and the rules for manipulating these variables in formulas", "https://st3.depositphotos.com/3591429/13656/i/450/depositphotos_136562916-stock-photo-creative-website-banner.jpg", "Algebra" });

            migrationBuilder.InsertData(
                table: "ProblemCategories",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[] { 3, "Geometry is concerned with the shapes of individual objects or shapes and their properties", "https://www.gyanipandit.com/en/wp-content/uploads/2021/06/Geometry-2cde81a7.jpg", "Geometry" });

            migrationBuilder.InsertData(
                table: "ProblemTypes",
                columns: new[] { "Id", "ImageUrl", "Instruction", "IsActive", "Name", "ProblemCategoryId" },
                values: new object[] { 1, "https://www.theschoolrun.com/sites/theschoolrun.com/files/article_images/addition.jpg", "Add numbers together", false, "Addition", 1 });

            migrationBuilder.InsertData(
                table: "ProblemTypes",
                columns: new[] { "Id", "ImageUrl", "Instruction", "IsActive", "Name", "ProblemCategoryId" },
                values: new object[] { 2, "https://www.theschoolrun.com/sites/theschoolrun.com/files/article_images/subtraction.png", "Take away one number from another", false, "Subtraction", 1 });

            migrationBuilder.InsertData(
                table: "DifficultyLevels",
                columns: new[] { "Id", "Name", "ProblemTypeId" },
                values: new object[,]
                {
                    { 1, "1st Grade", 1 },
                    { 2, "2nd Grade", 1 },
                    { 3, "3th Grade", 1 },
                    { 4, "4th Grade", 1 },
                    { 5, "5th Grade", 1 },
                    { 6, "6th Grade", 1 },
                    { 7, "7th Grade", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DifficultyLevels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProblemCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProblemCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProblemTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProblemTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProblemCategories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
