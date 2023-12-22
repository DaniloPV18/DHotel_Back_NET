using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DHotelBack.Migrations
{
    /// <inheritdoc />
    public partial class AtributosAdministrador : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdRol",
                table: "Administradores",
                newName: "RolId");

            migrationBuilder.RenameColumn(
                name: "IdGenero",
                table: "Administradores",
                newName: "GeneroId");

            migrationBuilder.RenameColumn(
                name: "IdEstado",
                table: "Administradores",
                newName: "EstadoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RolId",
                table: "Administradores",
                newName: "IdRol");

            migrationBuilder.RenameColumn(
                name: "GeneroId",
                table: "Administradores",
                newName: "IdGenero");

            migrationBuilder.RenameColumn(
                name: "EstadoId",
                table: "Administradores",
                newName: "IdEstado");
        }
    }
}
