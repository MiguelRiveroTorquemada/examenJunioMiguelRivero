using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace examenJunioMiguelRivero.Migrations
{
    public partial class examenJunioMiguelRivero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LibroItem",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    categoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subgenero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    año = table.Column<int>(type: "int", nullable: false),
                    autor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    duracion = table.Column<int>(type: "int", nullable: false),
                    puntuacion = table.Column<int>(type: "int", nullable: false),
                    sinopsis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    director = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    actores = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    likes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibroItem", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LibroItem");
        }
    }
}
