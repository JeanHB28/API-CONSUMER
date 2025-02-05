using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoBibliotecaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddTableBibliotecarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bibliotecario",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Permisos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BibliotecasAsignada = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bibliotecario", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Autor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Género = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AñoDePublicación = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Editorial = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Disponibilidad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Calificación = table.Column<int>(type: "int", nullable: true),
                    Popularidad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HistorialDePrestamos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Preferencias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Rol = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Prestamos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<int>(type: "int", nullable: true),
                    LibroID = table.Column<int>(type: "int", nullable: true),
                    FechaPrestamo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaDevolucion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Renovaciones = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Prestamos_Libros_LibroID",
                        column: x => x.LibroID,
                        principalTable: "Libros",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Prestamos_Usuario_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuario",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Recomendacion",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioID = table.Column<int>(type: "int", nullable: true),
                    LibroID = table.Column<int>(type: "int", nullable: true),
                    TipoRecomendacion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FechaGeneracion = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recomendacion", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Recomendacion_Libros_LibroID",
                        column: x => x.LibroID,
                        principalTable: "Libros",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Recomendacion_Usuario_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuario",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuariosID = table.Column<int>(type: "int", nullable: true),
                    LibroID = table.Column<int>(type: "int", nullable: true),
                    FechaReserva = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Estados = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Prioridad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Reserva_Libros_LibroID",
                        column: x => x.LibroID,
                        principalTable: "Libros",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Reserva_Usuario_UsuariosID",
                        column: x => x.UsuariosID,
                        principalTable: "Usuario",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_LibroID",
                table: "Prestamos",
                column: "LibroID");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_UsuarioID",
                table: "Prestamos",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Recomendacion_LibroID",
                table: "Recomendacion",
                column: "LibroID");

            migrationBuilder.CreateIndex(
                name: "IX_Recomendacion_UsuarioID",
                table: "Recomendacion",
                column: "UsuarioID");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_LibroID",
                table: "Reserva",
                column: "LibroID");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_UsuariosID",
                table: "Reserva",
                column: "UsuariosID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bibliotecario");

            migrationBuilder.DropTable(
                name: "Prestamos");

            migrationBuilder.DropTable(
                name: "Recomendacion");

            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
