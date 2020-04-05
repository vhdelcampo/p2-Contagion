using Microsoft.EntityFrameworkCore.Migrations;

namespace Contagion.API.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserPhone = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Long = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserPhone1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserPhone);
                    table.ForeignKey(
                        name: "FK_User_User_UserPhone1",
                        column: x => x.UserPhone1,
                        principalTable: "User",
                        principalColumn: "UserPhone",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserPhone", "Lat", "Long", "UserPhone1" },
                values: new object[] { 1234567890, -13.12m, 16.32m, null });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserPhone", "Lat", "Long", "UserPhone1" },
                values: new object[] { 987653432, 43.54m, -78.65m, null });

            migrationBuilder.CreateIndex(
                name: "IX_User_UserPhone1",
                table: "User",
                column: "UserPhone1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
