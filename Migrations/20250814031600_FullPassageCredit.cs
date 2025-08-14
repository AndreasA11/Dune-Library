using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DuneLibrary.Migrations
{
    /// <inheritdoc />
    public partial class FullPassageCredit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullPassageCredit",
                table: "Passage",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullPassageCredit",
                table: "Passage");
        }
    }
}
