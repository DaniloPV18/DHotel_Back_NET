using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DHotelBack.Migrations
{
    /// <inheritdoc />
    public partial class RelacionAdministradorHabitacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdTipoHabitacion",
                table: "Habitaciones",
                newName: "TipoHabitacionId");

            migrationBuilder.RenameColumn(
                name: "IdEstado",
                table: "Habitaciones",
                newName: "EstadoId");

            migrationBuilder.RenameColumn(
                name: "IdAdministrador",
                table: "Habitaciones",
                newName: "AdministradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Habitaciones_AdministradorId",
                table: "Habitaciones",
                column: "AdministradorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Habitaciones_Administradores_AdministradorId",
                table: "Habitaciones",
                column: "AdministradorId",
                principalTable: "Administradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Habitaciones_Administradores_AdministradorId",
                table: "Habitaciones");

            migrationBuilder.DropIndex(
                name: "IX_Habitaciones_AdministradorId",
                table: "Habitaciones");

            migrationBuilder.RenameColumn(
                name: "TipoHabitacionId",
                table: "Habitaciones",
                newName: "IdTipoHabitacion");

            migrationBuilder.RenameColumn(
                name: "EstadoId",
                table: "Habitaciones",
                newName: "IdEstado");

            migrationBuilder.RenameColumn(
                name: "AdministradorId",
                table: "Habitaciones",
                newName: "IdAdministrador");
        }
    }
}
