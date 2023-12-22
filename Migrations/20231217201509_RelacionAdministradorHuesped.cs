using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DHotelBack.Migrations
{
    /// <inheritdoc />
    public partial class RelacionAdministradorHuesped : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdGenero",
                table: "Huespedes",
                newName: "GeneroId");

            migrationBuilder.RenameColumn(
                name: "IdAdministrador",
                table: "Huespedes",
                newName: "AdministradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Huespedes_AdministradorId",
                table: "Huespedes",
                column: "AdministradorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Huespedes_Administradores_AdministradorId",
                table: "Huespedes",
                column: "AdministradorId",
                principalTable: "Administradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Huespedes_Administradores_AdministradorId",
                table: "Huespedes");

            migrationBuilder.DropIndex(
                name: "IX_Huespedes_AdministradorId",
                table: "Huespedes");

            migrationBuilder.RenameColumn(
                name: "GeneroId",
                table: "Huespedes",
                newName: "IdGenero");

            migrationBuilder.RenameColumn(
                name: "AdministradorId",
                table: "Huespedes",
                newName: "IdAdministrador");
        }
    }
}
