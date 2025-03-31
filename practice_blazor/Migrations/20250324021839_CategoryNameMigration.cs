using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace practice_blazor.Migrations
{
    /// <inheritdoc />
    public partial class CategoryNameMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "category",
                table: "Tools",
                newName: "CategoryName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Tools",
                newName: "category");
        }
    }
}
