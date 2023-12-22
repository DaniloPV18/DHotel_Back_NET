using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DHotelBack.Migrations
{
    /// <inheritdoc />
    public partial class RelacionHuespedPago : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdHuesped",
                table: "Pagos",
                newName: "HuespedId");

            migrationBuilder.RenameColumn(
                name: "IdAdministrador",
                table: "Pagos",
                newName: "AdministradorId");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_HuespedId",
                table: "Pagos",
                column: "HuespedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Huespedes_HuespedId",
                table: "Pagos",
                column: "HuespedId",
                principalTable: "Huespedes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Huespedes_HuespedId",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_HuespedId",
                table: "Pagos");

            migrationBuilder.RenameColumn(
                name: "HuespedId",
                table: "Pagos",
                newName: "IdHuesped");

            migrationBuilder.RenameColumn(
                name: "AdministradorId",
                table: "Pagos",
                newName: "IdAdministrador");
        }
    }
}
