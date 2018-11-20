using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalesItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    Tags = table.Column<string>(nullable: true),
                    PublishDate = table.Column<string>(nullable: true),
                    UpvoteCount = table.Column<int>(nullable: false),
                    Links = table.Column<string>(nullable: true),
                    Width = table.Column<string>(nullable: true),
                    Height = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesItem", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesItem");
        }
    }
}
