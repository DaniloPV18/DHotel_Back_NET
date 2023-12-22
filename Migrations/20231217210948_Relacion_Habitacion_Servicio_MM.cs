using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DHotelBack.Migrations
{
    /// <inheritdoc />
    public partial class RelacionHabitacionServicioMM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Habitaciones_HabitacionId",
                table: "Pagos");

            migrationBuilder.AlterColumn<int>(
                name: "HabitacionId",
                table: "Pagos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "HabitacionServicioOfrecido",
                columns: table => new
                {
                    HabitacionId = table.Column<int>(type: "int", nullable: false),
                    ServicioOfrecidoId = table.Column<int>(type: "int", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabitacionServicioOfrecido", x => new { x.HabitacionId, x.ServicioOfrecidoId });
                    table.ForeignKey(
                        name: "FK_HabitacionServicioOfrecido_Habitaciones_HabitacionId",
                        column: x => x.HabitacionId,
                        principalTable: "Habitaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HabitacionServicioOfrecido_ServiciosOfrecidos_ServicioOfrecidoId",
                        column: x => x.ServicioOfrecidoId,
                        principalTable: "ServiciosOfrecidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HabitacionServicioOfrecido_ServicioOfrecidoId",
                table: "HabitacionServicioOfrecido",
                column: "ServicioOfrecidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Habitaciones_HabitacionId",
                table: "Pagos",
                column: "HabitacionId",
                principalTable: "Habitaciones",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Habitaciones_HabitacionId",
                table: "Pagos");

            migrationBuilder.DropTable(
                name: "HabitacionServicioOfrecido");

            migrationBuilder.AlterColumn<int>(
                name: "HabitacionId",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Habitaciones_HabitacionId",
                table: "Pagos",
                column: "HabitacionId",
                principalTable: "Habitaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
