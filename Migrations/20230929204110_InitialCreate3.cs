using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiDataImporter.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddPrimaryKey(
                name: "PK_Articles",
                table: "Articles",
                column: "Journal");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Articles",
                table: "Articles");
        }
    }
}
