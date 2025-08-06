using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DuneLibrary.Migrations
{
    /// <inheritdoc />
    public partial class passageNameChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pssg",
                table: "Passage",
                newName: "Passages");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Passages",
                table: "Passage",
                newName: "Pssg");
        }
    }
}
