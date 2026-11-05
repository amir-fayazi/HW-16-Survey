using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Survey.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedSurveyTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "SurveyParticipations");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Options");

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "CreatedAt", "SurveyId", "Text" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Which backend topic do you enjoy most?" },
                    { 2, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Which database do you use most?" },
                    { 3, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Which version control system do you use?" },
                    { 4, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "How do you usually test your code?" },
                    { 5, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Which framework would you learn next?" },
                    { 6, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Which cloud platform interests you?" },
                    { 7, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "What learning format do you prefer?" },
                    { 8, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Which day suits a community meetup?" }
                });

            migrationBuilder.InsertData(
                table: "SurveyParticipations",
                columns: new[] { "Id", "CreatedAt", "PersonId", "SurveyId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 2, new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 3, new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 4, new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 5, new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 6, new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "CreatedAt", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "LINQ" },
                    { 2, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "EF Core" },
                    { 3, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "ASP.NET Core" },
                    { 4, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "OOP" },
                    { 5, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "SQL Server" },
                    { 6, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "PostgreSQL" },
                    { 7, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "MySQL" },
                    { 8, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "SQLite" },
                    { 9, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Git" },
                    { 10, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "SVN" },
                    { 11, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Mercurial" },
                    { 12, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "None" },
                    { 13, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Unit Tests" },
                    { 14, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Manual Tests" },
                    { 15, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Integration Tests" },
                    { 16, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Rarely Test" },
                    { 17, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "ASP.NET Core" },
                    { 18, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Blazor" },
                    { 19, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Angular" },
                    { 20, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "React" },
                    { 21, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Azure" },
                    { 22, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "AWS" },
                    { 23, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Google Cloud" },
                    { 24, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "None" },
                    { 25, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Video" },
                    { 26, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Documentation" },
                    { 27, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Workshops" },
                    { 28, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Projects" },
                    { 29, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Monday" },
                    { 30, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Wednesday" },
                    { 31, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Friday" },
                    { 32, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Weekend" }
                });

            migrationBuilder.InsertData(
                table: "Votes",
                columns: new[] { "Id", "CreatedAt", "OptionId", "PersonId", "QuestionId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 1 },
                    { 2, new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, 1 },
                    { 3, new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 4, 1 },
                    { 4, new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 5, 1 },
                    { 5, new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 2, 2 },
                    { 6, new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3, 2 },
                    { 7, new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4, 2 },
                    { 8, new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5, 2 },
                    { 9, new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 2, 3 },
                    { 10, new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3, 3 },
                    { 11, new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 2, 4 },
                    { 12, new DateTime(2026, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 3, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SurveyParticipations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SurveyParticipations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SurveyParticipations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SurveyParticipations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SurveyParticipations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SurveyParticipations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Votes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Options",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Votes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Surveys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "SurveyParticipations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Persons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Options",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1,
                column: "DeletedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2,
                column: "DeletedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3,
                column: "DeletedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4,
                column: "DeletedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 5,
                column: "DeletedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 6,
                column: "DeletedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 7,
                column: "DeletedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 8,
                column: "DeletedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 1,
                column: "DeletedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 2,
                column: "DeletedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 3,
                column: "DeletedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "Id",
                keyValue: 4,
                column: "DeletedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
