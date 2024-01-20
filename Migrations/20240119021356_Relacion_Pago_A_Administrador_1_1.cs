using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DHotelBack.Migrations
{
    /// <inheritdoc />
    public partial class RelacionPagoAAdministrador11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 20, 35, 41, 683, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 20, 35, 41, 683, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 20, 35, 41, 683, DateTimeKind.Local).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "HabitacionServicioOfrecido",
                keyColumns: new[] { "HabitacionId", "ServicioOfrecidoId" },
                keyValues: new object[] { 1, 1 },
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 20, 35, 41, 683, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "HabitacionServicioOfrecido",
                keyColumns: new[] { "HabitacionId", "ServicioOfrecidoId" },
                keyValues: new object[] { 1, 2 },
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 20, 35, 41, 683, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 20, 35, 41, 683, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 20, 35, 41, 683, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 20, 35, 41, 683, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 20, 35, 41, 683, DateTimeKind.Local).AddTicks(2228));

            migrationBuilder.UpdateData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 20, 35, 41, 683, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 20, 35, 41, 683, DateTimeKind.Local).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 20, 35, 41, 683, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 20, 35, 41, 683, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 18, 20, 35, 41, 683, DateTimeKind.Local).AddTicks(2251));
        }
    }
}
