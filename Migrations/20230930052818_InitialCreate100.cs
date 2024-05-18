using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiDataImporter.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate100 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArticleType",
                table: "Articles",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Eissn",
                table: "Articles",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Journal",
                table: "Articles",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "PublicationDate",
                table: "Articles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "Score",
                table: "Articles",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "TitleDisplay",
                table: "Articles",
                type: "TEXT",
                maxLength: 255,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArticleType",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Eissn",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Journal",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "PublicationDate",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "TitleDisplay",
                table: "Articles");
        }
    }
}
