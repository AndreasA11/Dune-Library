using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DuneLibrary.Migrations
{
    /// <inheritdoc />
    public partial class rating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullPassageCredit",
                table: "Passage");

            migrationBuilder.AddColumn<float>(
                name: "AverageRating",
                table: "Passage",
                type: "REAL",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AverageRating",
                table: "Passage");

            migrationBuilder.AddColumn<string>(
                name: "FullPassageCredit",
                table: "Passage",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
