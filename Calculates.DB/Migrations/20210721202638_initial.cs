using Microsoft.EntityFrameworkCore.Migrations;

namespace Calculates.DB.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calculates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number1 = table.Column<double>(type: "float", nullable: false),
                    Number2 = table.Column<double>(type: "float", nullable: false),
                    Operation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Result = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calculates", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calculates");
        }
    }
}
