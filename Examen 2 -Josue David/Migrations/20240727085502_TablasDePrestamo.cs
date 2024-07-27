using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen_2__Josue_David.Migrations
{
    /// <inheritdoc />
    public partial class TablasDePrestamo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Tiempo_del_Prestamo",
                schema: "dto",
                table: "plan_de_pago",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tiempo_del_Prestamo",
                schema: "dto",
                table: "plan_de_pago");
        }
    }
}
