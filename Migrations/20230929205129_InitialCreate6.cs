using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiDataImporter.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Articles",
                table: "Articles");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Articles",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Articles",
                table: "Articles",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Articles",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Articles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Articles",
                table: "Articles",
                column: "Journal");
        }
    }
}
