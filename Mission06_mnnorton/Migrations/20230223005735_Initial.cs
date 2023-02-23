using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_mnnorton.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieTitle = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    YearRelease = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: true),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieID);
                    table.ForeignKey(
                        name: "FK_Responses_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Comedy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "Family" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Horror" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 4, "Action" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 5, "Drama" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 6, "Adventure" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "CategoryID", "Director", "Edited", "LentTo", "MovieTitle", "Notes", "Rating", "YearRelease" },
                values: new object[] { 1, 1, null, false, null, "Legally Blonde", "This one makes me want to be a girl boss.", "PG-13", 2007 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "CategoryID", "Director", "Edited", "LentTo", "MovieTitle", "Notes", "Rating", "YearRelease" },
                values: new object[] { 3, 1, null, false, null, "How to Lose a Guy in Ten Days", "Caleb likes this one too.", "PG-13", 2007 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "CategoryID", "Director", "Edited", "LentTo", "MovieTitle", "Notes", "Rating", "YearRelease" },
                values: new object[] { 2, 2, null, false, null, "Cars", null, "G", 2003 });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_CategoryID",
                table: "Responses",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
