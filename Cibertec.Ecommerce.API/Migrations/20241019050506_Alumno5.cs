using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cibertec.Ecommerce.API.Migrations
{
    /// <inheritdoc />
    public partial class Alumno5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_Curso",
                columns: table => new
                {
                    IdCurso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantidadHoras = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Silabo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Curso", x => x.IdCurso);
                });

            migrationBuilder.CreateTable(
                name: "T_Venta",
                columns: table => new
                {
                    IdVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAlumno = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Venta", x => x.IdVenta);
                    table.ForeignKey(
                        name: "FK_T_Venta_T_Alumno_IdAlumno",
                        column: x => x.IdAlumno,
                        principalTable: "T_Alumno",
                        principalColumn: "IdAlumno",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_DetalleVenta",
                columns: table => new
                {
                    IdDetalleVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCurso = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VentaIdVenta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_DetalleVenta", x => x.IdDetalleVenta);
                    table.ForeignKey(
                        name: "FK_T_DetalleVenta_T_Curso_IdCurso",
                        column: x => x.IdCurso,
                        principalTable: "T_Curso",
                        principalColumn: "IdCurso",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_DetalleVenta_T_Venta_VentaIdVenta",
                        column: x => x.VentaIdVenta,
                        principalTable: "T_Venta",
                        principalColumn: "IdVenta",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_DetalleVenta_IdCurso",
                table: "T_DetalleVenta",
                column: "IdCurso");

            migrationBuilder.CreateIndex(
                name: "IX_T_DetalleVenta_VentaIdVenta",
                table: "T_DetalleVenta",
                column: "VentaIdVenta");

            migrationBuilder.CreateIndex(
                name: "IX_T_Venta_IdAlumno",
                table: "T_Venta",
                column: "IdAlumno");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_DetalleVenta");

            migrationBuilder.DropTable(
                name: "T_Curso");

            migrationBuilder.DropTable(
                name: "T_Venta");
        }
    }
}
