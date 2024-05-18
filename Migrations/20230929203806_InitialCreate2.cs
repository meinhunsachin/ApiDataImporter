using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiDataImporter.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Articles",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Articles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
