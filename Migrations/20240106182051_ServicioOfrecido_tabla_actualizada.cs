using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DHotelBack.Migrations
{
    /// <inheritdoc />
    public partial class ServicioOfrecidotablaactualizada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdEstado",
                table: "ServiciosOfrecidos",
                newName: "EstadoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EstadoId",
                table: "ServiciosOfrecidos",
                newName: "IdEstado");
        }
    }
}
