using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DHotelBack.Migrations
{
    /// <inheritdoc />
    public partial class Aumentarprecisiondecimales2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ValorPagado",
                table: "Pagos",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(7,4)",
                oldPrecision: 7,
                oldScale: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorAPagar",
                table: "Pagos",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(7,4)",
                oldPrecision: 7,
                oldScale: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorPagado",
                table: "AbonosReservas",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(7,4)",
                oldPrecision: 7,
                oldScale: 4,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 40, 34, 671, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 40, 34, 671, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 40, 34, 671, DateTimeKind.Local).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "HabitacionServicioOfrecido",
                keyColumns: new[] { "HabitacionId", "ServicioOfrecidoId" },
                keyValues: new object[] { 1, 1 },
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 40, 34, 671, DateTimeKind.Local).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "HabitacionServicioOfrecido",
                keyColumns: new[] { "HabitacionId", "ServicioOfrecidoId" },
                keyValues: new object[] { 1, 2 },
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 40, 34, 671, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 40, 34, 671, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 40, 34, 671, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 40, 34, 671, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 40, 34, 671, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 40, 34, 671, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 40, 34, 671, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 40, 34, 671, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 40, 34, 671, DateTimeKind.Local).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 40, 34, 671, DateTimeKind.Local).AddTicks(7508));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ValorPagado",
                table: "Pagos",
                type: "decimal(7,4)",
                precision: 7,
                scale: 4,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorAPagar",
                table: "Pagos",
                type: "decimal(7,4)",
                precision: 7,
                scale: 4,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorPagado",
                table: "AbonosReservas",
                type: "decimal(7,4)",
                precision: 7,
                scale: 4,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)",
                oldPrecision: 10,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 37, 3, 184, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 37, 3, 184, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 37, 3, 184, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "HabitacionServicioOfrecido",
                keyColumns: new[] { "HabitacionId", "ServicioOfrecidoId" },
                keyValues: new object[] { 1, 1 },
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 37, 3, 184, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "HabitacionServicioOfrecido",
                keyColumns: new[] { "HabitacionId", "ServicioOfrecidoId" },
                keyValues: new object[] { 1, 2 },
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 37, 3, 184, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 37, 3, 184, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 37, 3, 184, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 37, 3, 184, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 37, 3, 184, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 37, 3, 184, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 37, 3, 184, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 37, 3, 184, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 37, 3, 184, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaRegistro",
                value: new DateTime(2024, 1, 23, 23, 37, 3, 184, DateTimeKind.Local).AddTicks(9150));
        }
    }
}
