using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DHotelBack.Migrations
{
    /// <inheritdoc />
    public partial class DatosSeedingInicialTablas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbonosReservas_Pagos_PagoId",
                table: "AbonosReservas");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorPagado",
                table: "Pagos",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldPrecision: 5,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorAPagar",
                table: "Pagos",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldPrecision: 5,
                oldScale: 2);

            migrationBuilder.AlterColumn<string>(
                name: "ServiciosHabitacion",
                table: "Pagos",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<int>(
                name: "IdTipoPago",
                table: "Pagos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HuespedId",
                table: "Pagos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HabitacionId",
                table: "Pagos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Pagos",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaModificacion",
                table: "Pagos",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaInicio",
                table: "Pagos",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaFin",
                table: "Pagos",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorPagado",
                table: "AbonosReservas",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldPrecision: 5,
                oldScale: 2);

            migrationBuilder.AlterColumn<int>(
                name: "PagoId",
                table: "AbonosReservas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdAdminRegistro",
                table: "AbonosReservas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "AbonosReservas",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Administradores",
                columns: new[] { "Id", "AdministradorId", "Apellidos", "Cedula", "Celular", "Email", "EstadoId", "FechaModificacion", "FechaNacimiento", "FechaRegistro", "GeneroId", "Nombres", "Pwd", "RolId", "UltimaActividad" },
                values: new object[,]
                {
                    { 1, null, "Zambrano", "0931600548", "0962723152", "micaela@gmail.com", 1, null, null, new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7605), 2, "Micaela", "0931600548", 1, null },
                    { 2, null, "Lasso", "0931600549", "0962723152", "sonia@gmail.com", 1, null, null, new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7665), 2, "Sonia", "0931600549", 2, null },
                    { 3, null, "Marion", "0931600550", "0962723152", "milo@gmail.com", 1, null, null, new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7667), 1, "Milo", "0931600550", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Habitaciones",
                columns: new[] { "Id", "AdministradorId", "EstadoId", "FechaModificacion", "FechaRegistro", "Foto", "Numero", "Precio", "TipoHabitacionId" },
                values: new object[,]
                {
                    { 1, null, 1, null, new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7795), null, 400, null, null },
                    { 2, null, 1, null, new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7796), null, 401, null, null },
                    { 3, null, 1, null, new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7797), null, 402, null, null }
                });

            migrationBuilder.InsertData(
                table: "Huespedes",
                columns: new[] { "Id", "AdministradorId", "Apellidos", "Cedula", "Celular", "Email", "FechaModificacion", "FechaRegistro", "GeneroId", "Nombres" },
                values: new object[,]
                {
                    { 1, null, "Karita", "0931600897", "0962723152", "Keila@gmail.com", null, new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7761), 2, "Keila" },
                    { 2, null, "Alesso", "0931600898", "0962723152", "Alejandro@gmail.com", null, new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7763), 1, "Alejandro" },
                    { 3, null, "Toala", "0931600899", "0962723152", "Pepe@gmail.com", null, new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7764), 1, "Pepe" }
                });

            migrationBuilder.InsertData(
                table: "ServiciosOfrecidos",
                columns: new[] { "Id", "AdministradorId", "Codigo", "EstadoId", "FechaModificacion", "FechaRegistro", "Nombre" },
                values: new object[,]
                {
                    { 1, null, "NET", 1, null, new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7780), "Internet" },
                    { 2, null, "TV", 1, null, new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7781), "Television Cable" },
                    { 3, null, "AIR", 1, null, new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7782), "Aire Acondicionado" }
                });

            migrationBuilder.InsertData(
                table: "HabitacionServicioOfrecido",
                columns: new[] { "HabitacionId", "ServicioOfrecidoId", "FechaRegistro" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7808) },
                    { 1, 2, new DateTime(2024, 1, 7, 19, 5, 18, 7, DateTimeKind.Local).AddTicks(7809) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AbonosReservas_Pagos_PagoId",
                table: "AbonosReservas",
                column: "PagoId",
                principalTable: "Pagos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbonosReservas_Pagos_PagoId",
                table: "AbonosReservas");

            migrationBuilder.DeleteData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Administradores",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HabitacionServicioOfrecido",
                keyColumns: new[] { "HabitacionId", "ServicioOfrecidoId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "HabitacionServicioOfrecido",
                keyColumns: new[] { "HabitacionId", "ServicioOfrecidoId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Huespedes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Habitaciones",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ServiciosOfrecidos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorPagado",
                table: "Pagos",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldPrecision: 5,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorAPagar",
                table: "Pagos",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldPrecision: 5,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ServiciosHabitacion",
                table: "Pagos",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdTipoPago",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HuespedId",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HabitacionId",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "Pagos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaModificacion",
                table: "Pagos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaInicio",
                table: "Pagos",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaFin",
                table: "Pagos",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "ValorPagado",
                table: "AbonosReservas",
                type: "decimal(5,2)",
                precision: 5,
                scale: 2,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)",
                oldPrecision: 5,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PagoId",
                table: "AbonosReservas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdAdminRegistro",
                table: "AbonosReservas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaRegistro",
                table: "AbonosReservas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AbonosReservas_Pagos_PagoId",
                table: "AbonosReservas",
                column: "PagoId",
                principalTable: "Pagos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
