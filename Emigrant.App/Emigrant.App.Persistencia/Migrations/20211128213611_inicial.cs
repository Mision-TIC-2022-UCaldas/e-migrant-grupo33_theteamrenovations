using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Emigrant.App.Persistencia.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entidades",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nit = table.Column<int>(type: "int", nullable: false),
                    razon_Social = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefonoEntidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correoEntidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    web = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sector = table.Column<int>(type: "int", nullable: false),
                    tipoServicio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entidades", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Migrantes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipo_documento = table.Column<int>(type: "int", nullable: false),
                    identificacion = table.Column<int>(type: "int", nullable: false),
                    pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha_nacimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ciudad = table.Column<int>(type: "int", nullable: false),
                    sit_laboral = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Migrantes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Novedades",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoNovedad = table.Column<int>(type: "int", nullable: false),
                    ciudad = table.Column<int>(type: "int", nullable: false),
                    fechaNovedad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numeroDias = table.Column<int>(type: "int", nullable: false),
                    novedad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false),
                    id_entidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novedades", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreServicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numCupos = table.Column<int>(type: "int", nullable: false),
                    fechaIni = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    prioridad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    identificacion = table.Column<int>(type: "int", nullable: false),
                    parentesco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_migrante = table.Column<int>(type: "int", nullable: false),
                    Migranteid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Grupos_Migrantes_Migranteid",
                        column: x => x.Migranteid,
                        principalTable: "Migrantes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Necesidades",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    detalles = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoServicio = table.Column<int>(type: "int", nullable: false),
                    prioridad = table.Column<int>(type: "int", nullable: false),
                    Migrante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Migranteid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Necesidades", x => x.id);
                    table.ForeignKey(
                        name: "FK_Necesidades_Migrantes_Migranteid",
                        column: x => x.Migranteid,
                        principalTable: "Migrantes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grupos_Migranteid",
                table: "Grupos",
                column: "Migranteid");

            migrationBuilder.CreateIndex(
                name: "IX_Necesidades_Migranteid",
                table: "Necesidades",
                column: "Migranteid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entidades");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Necesidades");

            migrationBuilder.DropTable(
                name: "Novedades");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "Migrantes");
        }
    }
}
