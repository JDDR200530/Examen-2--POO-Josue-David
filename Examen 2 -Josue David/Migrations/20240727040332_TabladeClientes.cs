using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen_2__Josue_David.Migrations
{
    /// <inheritdoc />
    public partial class TabladeClientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dto");

            migrationBuilder.CreateTable(
                name: "Cliente",
                schema: "dto",
                columns: table => new
                {
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cliente_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    identity_number = table.Column<int>(type: "int", nullable: false),
                    loan_amount = table.Column<double>(type: "float", nullable: false),
                    comissiion = table.Column<int>(type: "int", nullable: false),
                    interert = table.Column<double>(type: "float", nullable: false),
                    term = table.Column<int>(type: "int", nullable: false),
                    day_create = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "plan_de_pago",
                schema: "dto",
                columns: table => new
                {
                    No = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Days = table.Column<int>(type: "int", nullable: false),
                    Interest = table.Column<int>(type: "int", nullable: false),
                    pago_principal = table.Column<int>(type: "int", nullable: false),
                    seguro_de_vida = table.Column<double>(type: "float", nullable: false),
                    balance_Principal = table.Column<double>(type: "float", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plan_de_pago", x => x.No);
                    table.ForeignKey(
                        name: "FK_plan_de_pago_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalSchema: "dto",
                        principalTable: "Cliente",
                        principalColumn: "ClienteId");
                });

            migrationBuilder.CreateTable(
                name: "cliente_planepago",
                schema: "dto",
                columns: table => new
                {
                    No = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dia_de_Creacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dias = table.Column<int>(type: "int", nullable: false),
                    Intereses = table.Column<int>(type: "int", nullable: false),
                    Pago_Principal = table.Column<int>(type: "int", nullable: false),
                    Seguro_de_Vida = table.Column<double>(type: "float", nullable: false),
                    Balance_Principal = table.Column<double>(type: "float", nullable: false),
                    PlandePagoNo = table.Column<int>(type: "int", nullable: true),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente_planepago", x => x.No);
                    table.ForeignKey(
                        name: "FK_cliente_planepago_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalSchema: "dto",
                        principalTable: "Cliente",
                        principalColumn: "ClienteId");
                    table.ForeignKey(
                        name: "FK_cliente_planepago_plan_de_pago_PlandePagoNo",
                        column: x => x.PlandePagoNo,
                        principalSchema: "dto",
                        principalTable: "plan_de_pago",
                        principalColumn: "No");
                });

            migrationBuilder.CreateIndex(
                name: "IX_cliente_planepago_ClienteId",
                schema: "dto",
                table: "cliente_planepago",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_planepago_PlandePagoNo",
                schema: "dto",
                table: "cliente_planepago",
                column: "PlandePagoNo");

            migrationBuilder.CreateIndex(
                name: "IX_plan_de_pago_ClienteId",
                schema: "dto",
                table: "plan_de_pago",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cliente_planepago",
                schema: "dto");

            migrationBuilder.DropTable(
                name: "plan_de_pago",
                schema: "dto");

            migrationBuilder.DropTable(
                name: "Cliente",
                schema: "dto");
        }
    }
}
