using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DHotelBack.Migrations
{
    /// <inheritdoc />
    public partial class ModificacionEntidades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdAdminRegistro",
                table: "Pagos",
                newName: "IdHuesped");

            migrationBuilder.RenameColumn(
                name: "IdAdminRegistro",
                table: "Huespedes",
                newName: "IdAdministrador");

            migrationBuilder.RenameColumn(
                name: "IdAdminRegistro",
                table: "Habitaciones",
                newName: "IdAdministrador");

            migrationBuilder.AddColumn<int>(
                name: "IdAdministrador",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdAdministrador",
                table: "Pagos");

            migrationBuilder.RenameColumn(
                name: "IdHuesped",
                table: "Pagos",
                newName: "IdAdminRegistro");

            migrationBuilder.RenameColumn(
                name: "IdAdministrador",
                table: "Huespedes",
                newName: "IdAdminRegistro");

            migrationBuilder.RenameColumn(
                name: "IdAdministrador",
                table: "Habitaciones",
                newName: "IdAdminRegistro");
        }
    }
}
