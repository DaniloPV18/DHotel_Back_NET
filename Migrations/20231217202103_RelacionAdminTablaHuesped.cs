using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DHotelBack.Migrations
{
    /// <inheritdoc />
    public partial class RelacionAdminTablaHuesped : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Huespedes_Administradores_AdministradorId",
                table: "Huespedes");

            migrationBuilder.AlterColumn<int>(
                name: "AdministradorId",
                table: "Huespedes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AlterColumn<int>(
                name: "AdministradorId",
                table: "Huespedes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Huespedes_Administradores_AdministradorId",
                table: "Huespedes",
                column: "AdministradorId",
                principalTable: "Administradores",
                principalColumn: "Id");
        }
    }
}
