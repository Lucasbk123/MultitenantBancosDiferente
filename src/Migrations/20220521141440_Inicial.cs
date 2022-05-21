using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Multitenant.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Pessoa 1" });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "Pessoa 2" });

            migrationBuilder.InsertData(
                table: "Pessoas",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 3, "Pessoa 3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
