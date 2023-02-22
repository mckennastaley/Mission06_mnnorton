using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_mnnorton.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieTitle = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "Edited", "LentTo", "MovieTitle", "Notes", "Rating" },
                values: new object[] { 1, false, null, "Legally Blonde", "This one makes me want to be a girl boss.", "PG-13" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "Edited", "LentTo", "MovieTitle", "Notes", "Rating" },
                values: new object[] { 2, false, null, "Cars", null, "G" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "Edited", "LentTo", "MovieTitle", "Notes", "Rating" },
                values: new object[] { 3, false, null, "How to Lose a Guy in Ten Days", "Caleb likes this one too.", "PG-13" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
