using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DHotelBack.Migrations
{
    /// <inheritdoc />
    public partial class RelacionPagoHabitacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HabitacionId",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_HabitacionId",
                table: "Pagos",
                column: "HabitacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Habitaciones_HabitacionId",
                table: "Pagos",
                column: "HabitacionId",
                principalTable: "Habitaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Habitaciones_HabitacionId",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_HabitacionId",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "HabitacionId",
                table: "Pagos");
        }
    }
}
