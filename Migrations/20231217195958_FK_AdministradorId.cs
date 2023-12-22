using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DHotelBack.Migrations
{
    /// <inheritdoc />
    public partial class FKAdministradorId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdAdministrador",
                table: "Administradores",
                newName: "AdministradorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdministradorId",
                table: "Administradores",
                newName: "IdAdministrador");
        }
    }
}
