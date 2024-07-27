using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen_2__Josue_David.Migrations
{
    /// <inheritdoc />
    public partial class Actualizacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "comissiion",
                schema: "dto",
                table: "Cliente",
                newName: "Comission");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Comission",
                schema: "dto",
                table: "Cliente",
                newName: "comissiion");
        }
    }
}
