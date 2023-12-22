using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DHotelBack.Migrations
{
    /// <inheritdoc />
    public partial class RelacionAdminServiciosOfre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdAdminRegistro",
                table: "ServiciosOfrecidos",
                newName: "AdministradorId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiciosOfrecidos_AdministradorId",
                table: "ServiciosOfrecidos",
                column: "AdministradorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiciosOfrecidos_Administradores_AdministradorId",
                table: "ServiciosOfrecidos",
                column: "AdministradorId",
                principalTable: "Administradores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiciosOfrecidos_Administradores_AdministradorId",
                table: "ServiciosOfrecidos");

            migrationBuilder.DropIndex(
                name: "IX_ServiciosOfrecidos_AdministradorId",
                table: "ServiciosOfrecidos");

            migrationBuilder.RenameColumn(
                name: "AdministradorId",
                table: "ServiciosOfrecidos",
                newName: "IdAdminRegistro");
        }
    }
}
