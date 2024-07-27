using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen_2__Josue_David.Migrations
{
    /// <inheritdoc />
    public partial class ActualizacionCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "identity_number",
                schema: "dto",
                table: "Cliente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "identity_number",
                schema: "dto",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
