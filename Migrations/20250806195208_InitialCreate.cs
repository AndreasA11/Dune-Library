using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DuneLibrary.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Passage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Pssg = table.Column<string>(type: "TEXT", nullable: true),
                    Book = table.Column<string>(type: "TEXT", nullable: true),
                    ChapterNum = table.Column<int>(type: "INTEGER", nullable: false),
                    Author = table.Column<string>(type: "TEXT", nullable: true),
                    Series = table.Column<string>(type: "TEXT", nullable: true),
                    Organization = table.Column<string>(type: "TEXT", nullable: true),
                    WordCount = table.Column<int>(type: "INTEGER", nullable: true),
                    AverageRating = table.Column<float>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passage", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Passage");
        }
    }
}
