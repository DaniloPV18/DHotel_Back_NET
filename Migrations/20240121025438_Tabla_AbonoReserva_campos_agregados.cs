using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DHotelBack.Migrations
{
    /// <inheritdoc />
    public partial class TablaAbonoReservacamposagregados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                table: "AbonosReservas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 20, 21, 54, 37, 891, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 20, 21, 54, 37, 891, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 20, 21, 54, 37, 891, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "HabitacionServicioOfrecido",
                keyColumns: new[] { "HabitacionId", "ServicioOfrecidoId" },
                keyValues: new object[] { 1, 1 },
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 20, 21, 54, 37, 891, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "HabitacionServicioOfrecido",
                keyColumns: new[] { "HabitacionId", "ServicioOfrecidoId" },
                keyValues: new object[] { 1, 2 },
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 20, 21, 54, 37, 891, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 20, 21, 54, 37, 891, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 20, 21, 54, 37, 891, DateTimeKind.Local).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 20, 21, 54, 37, 891, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 20, 21, 54, 37, 891, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 20, 21, 54, 37, 891, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 20, 21, 54, 37, 891, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 20, 21, 54, 37, 891, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 20, 21, 54, 37, 891, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 20, 21, 54, 37, 891, DateTimeKind.Local).AddTicks(847));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "AbonosReservas");

            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 21, 13, 56, 442, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 21, 13, 56, 442, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 21, 13, 56, 442, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "HabitacionServicioOfrecido",
                keyColumns: new[] { "HabitacionId", "ServicioOfrecidoId" },
                keyValues: new object[] { 1, 1 },
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 21, 13, 56, 442, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "HabitacionServicioOfrecido",
                keyColumns: new[] { "HabitacionId", "ServicioOfrecidoId" },
                keyValues: new object[] { 1, 2 },
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 21, 13, 56, 442, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 21, 13, 56, 442, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 21, 13, 56, 442, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 21, 13, 56, 442, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 21, 13, 56, 442, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 21, 13, 56, 442, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 21, 13, 56, 442, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 21, 13, 56, 442, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 21, 13, 56, 442, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 21, 13, 56, 442, DateTimeKind.Local).AddTicks(4692));
        }
    }
}
