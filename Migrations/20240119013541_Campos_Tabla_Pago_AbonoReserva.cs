using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DHotelBack.Migrations
{
    /// <inheritdoc />
    public partial class CamposTablaPagoAbonoReserva : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdTipoPago",
                table: "Pagos",
                newName: "TipoPagoId");

            migrationBuilder.AddColumn<int>(
                name: "EstadoId",
                table: "Pagos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstadoId",
                table: "AbonosReservas",
                type: "int",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstadoId",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "EstadoId",
                table: "AbonosReservas");

            migrationBuilder.RenameColumn(
                name: "TipoPagoId",
                table: "Pagos",
                newName: "IdTipoPago");

            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 17, 23, 12, 20, 302, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 17, 23, 12, 20, 302, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 17, 23, 12, 20, 302, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "HabitacionServicioOfrecido",
                keyColumns: new[] { "HabitacionId", "ServicioOfrecidoId" },
                keyValues: new object[] { 1, 1 },
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 17, 23, 12, 20, 302, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "HabitacionServicioOfrecido",
                keyColumns: new[] { "HabitacionId", "ServicioOfrecidoId" },
                keyValues: new object[] { 1, 2 },
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 17, 23, 12, 20, 302, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 17, 23, 12, 20, 302, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 17, 23, 12, 20, 302, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 17, 23, 12, 20, 302, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 17, 23, 12, 20, 302, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 17, 23, 12, 20, 302, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 17, 23, 12, 20, 302, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 17, 23, 12, 20, 302, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 17, 23, 12, 20, 302, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 17, 23, 12, 20, 302, DateTimeKind.Local).AddTicks(1681));
        }
    }
}
