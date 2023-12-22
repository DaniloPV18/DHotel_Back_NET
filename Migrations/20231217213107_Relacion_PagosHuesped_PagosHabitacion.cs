using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DHotelBack.Migrations
{
    /// <inheritdoc />
    public partial class RelacionPagosHuespedPagosHabitacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Habitaciones_HabitacionId",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Huespedes_HuespedId",
                table: "Pagos");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Habitaciones_HabitacionId",
                table: "Pagos",
                column: "HabitacionId",
                principalTable: "Habitaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Huespedes_HuespedId",
                table: "Pagos",
                column: "HuespedId",
                principalTable: "Huespedes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Habitaciones_HabitacionId",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Huespedes_HuespedId",
                table: "Pagos");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Habitaciones_HabitacionId",
                table: "Pagos",
                column: "HabitacionId",
                principalTable: "Habitaciones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Huespedes_HuespedId",
                table: "Pagos",
                column: "HuespedId",
                principalTable: "Huespedes",
                principalColumn: "Id");
        }
    }
}
