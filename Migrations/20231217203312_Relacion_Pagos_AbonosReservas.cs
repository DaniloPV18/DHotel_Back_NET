using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DHotelBack.Migrations
{
    /// <inheritdoc />
    public partial class RelacionPagosAbonosReservas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdHabitacion",
                table: "Pagos",
                newName: "IdAdministrador");

            migrationBuilder.RenameColumn(
                name: "IdPagos",
                table: "AbonosReservas",
                newName: "PagoId");

            migrationBuilder.AlterColumn<int>(
                name: "AdministradorId",
                table: "Pagos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_AdministradorId",
                table: "Pagos",
                column: "AdministradorId");

            migrationBuilder.CreateIndex(
                name: "IX_AbonosReservas_PagoId",
                table: "AbonosReservas",
                column: "PagoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AbonosReservas_Pagos_PagoId",
                table: "AbonosReservas",
                column: "PagoId",
                principalTable: "Pagos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Administradores_AdministradorId",
                table: "Pagos",
                column: "AdministradorId",
                principalTable: "Administradores",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbonosReservas_Pagos_PagoId",
                table: "AbonosReservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Administradores_AdministradorId",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_AdministradorId",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_AbonosReservas_PagoId",
                table: "AbonosReservas");

            migrationBuilder.RenameColumn(
                name: "IdAdministrador",
                table: "Pagos",
                newName: "IdHabitacion");

            migrationBuilder.RenameColumn(
                name: "PagoId",
                table: "AbonosReservas",
                newName: "IdPagos");

            migrationBuilder.AlterColumn<int>(
                name: "AdministradorId",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
