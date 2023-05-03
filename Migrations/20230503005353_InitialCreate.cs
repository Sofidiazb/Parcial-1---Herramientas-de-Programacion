using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parcial1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Categoria = table.Column<int>(type: "INTEGER", nullable: false),
                    Duracion = table.Column<string>(type: "TEXT", nullable: false),
                    Precio = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estudiante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CursoId = table.Column<int>(type: "INTEGER", nullable: false),
                    NombreAlumno = table.Column<string>(type: "TEXT", nullable: false),
                    ApellidoAlumno = table.Column<string>(type: "TEXT", nullable: false),
                    Dni = table.Column<int>(type: "INTEGER", nullable: false),
                    CursoElegido = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiante", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Curso");

            migrationBuilder.DropTable(
                name: "Estudiante");
        }
    }
}
