﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizApp_Data.Migrations
{
    public partial class AddFieldsToUserAnswers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoTakes",
                table: "UserExams");

            migrationBuilder.AddColumn<int>(
                name: "NoTakes",
                table: "UserAnswers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoTakes",
                table: "UserAnswers");

            migrationBuilder.AddColumn<int>(
                name: "NoTakes",
                table: "UserExams",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
