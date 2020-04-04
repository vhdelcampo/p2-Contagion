using Microsoft.EntityFrameworkCore.Migrations;

namespace Contagion.Storage.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserPhone = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lat = table.Column<decimal>(nullable: false),
                    Long = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserPhone);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserPhone", "Lat", "Long" },
                values: new object[] { 1234567890, -13.12m, 16.32m });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserPhone", "Lat", "Long" },
                values: new object[] { 987653432, 43.54m, -78.65m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
