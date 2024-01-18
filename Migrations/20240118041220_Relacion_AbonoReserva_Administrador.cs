using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DHotelBack.Migrations
{
    /// <inheritdoc />
    public partial class RelacionAbonoReservaAdministrador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdAdminRegistro",
                table: "AbonosReservas",
                newName: "AdministradorId");

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

            migrationBuilder.CreateIndex(
                name: "IX_AbonosReservas_AdministradorId",
                table: "AbonosReservas",
                column: "AdministradorId");

            migrationBuilder.AddForeignKey(
                name: "FK_AbonosReservas_Administradores_AdministradorId",
                table: "AbonosReservas",
                column: "AdministradorId",
                principalTable: "Administradores",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbonosReservas_Administradores_AdministradorId",
                table: "AbonosReservas");

            migrationBuilder.DropIndex(
                name: "IX_AbonosReservas_AdministradorId",
                table: "AbonosReservas");

            migrationBuilder.RenameColumn(
                name: "AdministradorId",
                table: "AbonosReservas",
                newName: "IdAdminRegistro");

            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "HabitacionServicioOfrecido",
                keyColumns: new[] { "HabitacionId", "ServicioOfrecidoId" },
                keyValues: new object[] { 1, 1 },
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "HabitacionServicioOfrecido",
                keyColumns: new[] { "HabitacionId", "ServicioOfrecidoId" },
                keyValues: new object[] { 1, 2 },
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7782));
        }
    }
}
