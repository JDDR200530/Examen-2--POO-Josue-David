using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen_2__Josue_David.Migrations
{
    /// <inheritdoc />
    public partial class ActualizaciondeTodoelProyecto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cliente_planepago_Cliente_ClienteId",
                schema: "dto",
                table: "cliente_planepago");

            migrationBuilder.DropForeignKey(
                name: "FK_cliente_planepago_plan_de_pago_PlandePagoNo",
                schema: "dto",
                table: "cliente_planepago");

            migrationBuilder.DropForeignKey(
                name: "FK_plan_de_pago_Cliente_ClienteId",
                schema: "dto",
                table: "plan_de_pago");

            migrationBuilder.DropPrimaryKey(
                name: "PK_plan_de_pago",
                schema: "dto",
                table: "plan_de_pago");

            migrationBuilder.DropIndex(
                name: "IX_plan_de_pago_ClienteId",
                schema: "dto",
                table: "plan_de_pago");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cliente_planepago",
                schema: "dto",
                table: "cliente_planepago");

            migrationBuilder.DropIndex(
                name: "IX_cliente_planepago_PlandePagoNo",
                schema: "dto",
                table: "cliente_planepago");

            migrationBuilder.DropColumn(
                name: "No",
                schema: "dto",
                table: "plan_de_pago");

            migrationBuilder.DropColumn(
                name: "Days",
                schema: "dto",
                table: "plan_de_pago");

            migrationBuilder.DropColumn(
                name: "balance_Principal",
                schema: "dto",
                table: "plan_de_pago");

            migrationBuilder.DropColumn(
                name: "seguro_de_vida",
                schema: "dto",
                table: "plan_de_pago");

            migrationBuilder.DropColumn(
                name: "No",
                schema: "dto",
                table: "cliente_planepago");

            migrationBuilder.DropColumn(
                name: "Pago_Principal",
                schema: "dto",
                table: "cliente_planepago");

            migrationBuilder.DropColumn(
                name: "PlandePagoNo",
                schema: "dto",
                table: "cliente_planepago");

            migrationBuilder.DropColumn(
                name: "Comission",
                schema: "dto",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "day_create",
                schema: "dto",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "interert",
                schema: "dto",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "loan_amount",
                schema: "dto",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "term",
                schema: "dto",
                table: "Cliente");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                schema: "dto",
                table: "plan_de_pago",
                newName: "Cliente_Id");

            migrationBuilder.RenameColumn(
                name: "pago_principal",
                schema: "dto",
                table: "plan_de_pago",
                newName: "Tasa_de_Interes");

            migrationBuilder.RenameColumn(
                name: "Interest",
                schema: "dto",
                table: "plan_de_pago",
                newName: "Comision");

            migrationBuilder.RenameColumn(
                name: "Date_Time",
                schema: "dto",
                table: "plan_de_pago",
                newName: "Fecha_Prestamo");

            migrationBuilder.RenameColumn(
                name: "Seguro_de_Vida",
                schema: "dto",
                table: "cliente_planepago",
                newName: "Nivel_Pago_Con_VSD");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                schema: "dto",
                table: "cliente_planepago",
                newName: "PrestamoEntityClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_cliente_planepago_ClienteId",
                schema: "dto",
                table: "cliente_planepago",
                newName: "IX_cliente_planepago_PrestamoEntityClienteId");

            migrationBuilder.AlterColumn<Guid>(
                name: "Cliente_Id",
                schema: "dto",
                table: "plan_de_pago",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClienteEntityClienteId",
                schema: "dto",
                table: "plan_de_pago",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Prestamo_Id",
                schema: "dto",
                table: "plan_de_pago",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<double>(
                name: "Intereses",
                schema: "dto",
                table: "cliente_planepago",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Balance_Principal",
                schema: "dto",
                table: "cliente_planepago",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<Guid>(
                name: "Prestamo_Id",
                schema: "dto",
                table: "cliente_planepago",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha_de_Pago",
                schema: "dto",
                table: "cliente_planepago",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "Nivel_Pago_Sin_VSD",
                schema: "dto",
                table: "cliente_planepago",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Principal",
                schema: "dto",
                table: "cliente_planepago",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddPrimaryKey(
                name: "PK_plan_de_pago",
                schema: "dto",
                table: "plan_de_pago",
                column: "Cliente_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cliente_planepago",
                schema: "dto",
                table: "cliente_planepago",
                column: "Prestamo_Id");

            migrationBuilder.CreateIndex(
                name: "IX_plan_de_pago_ClienteEntityClienteId",
                schema: "dto",
                table: "plan_de_pago",
                column: "ClienteEntityClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_cliente_planepago_plan_de_pago_PrestamoEntityClienteId",
                schema: "dto",
                table: "cliente_planepago",
                column: "PrestamoEntityClienteId",
                principalSchema: "dto",
                principalTable: "plan_de_pago",
                principalColumn: "Cliente_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_plan_de_pago_Cliente_ClienteEntityClienteId",
                schema: "dto",
                table: "plan_de_pago",
                column: "ClienteEntityClienteId",
                principalSchema: "dto",
                principalTable: "Cliente",
                principalColumn: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cliente_planepago_plan_de_pago_PrestamoEntityClienteId",
                schema: "dto",
                table: "cliente_planepago");

            migrationBuilder.DropForeignKey(
                name: "FK_plan_de_pago_Cliente_ClienteEntityClienteId",
                schema: "dto",
                table: "plan_de_pago");

            migrationBuilder.DropPrimaryKey(
                name: "PK_plan_de_pago",
                schema: "dto",
                table: "plan_de_pago");

            migrationBuilder.DropIndex(
                name: "IX_plan_de_pago_ClienteEntityClienteId",
                schema: "dto",
                table: "plan_de_pago");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cliente_planepago",
                schema: "dto",
                table: "cliente_planepago");

            migrationBuilder.DropColumn(
                name: "ClienteEntityClienteId",
                schema: "dto",
                table: "plan_de_pago");

            migrationBuilder.DropColumn(
                name: "Prestamo_Id",
                schema: "dto",
                table: "plan_de_pago");

            migrationBuilder.DropColumn(
                name: "Prestamo_Id",
                schema: "dto",
                table: "cliente_planepago");

            migrationBuilder.DropColumn(
                name: "Fecha_de_Pago",
                schema: "dto",
                table: "cliente_planepago");

            migrationBuilder.DropColumn(
                name: "Nivel_Pago_Sin_VSD",
                schema: "dto",
                table: "cliente_planepago");

            migrationBuilder.DropColumn(
                name: "Principal",
                schema: "dto",
                table: "cliente_planepago");

            migrationBuilder.RenameColumn(
                name: "Cliente_Id",
                schema: "dto",
                table: "plan_de_pago",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "Tasa_de_Interes",
                schema: "dto",
                table: "plan_de_pago",
                newName: "pago_principal");

            migrationBuilder.RenameColumn(
                name: "Fecha_Prestamo",
                schema: "dto",
                table: "plan_de_pago",
                newName: "Date_Time");

            migrationBuilder.RenameColumn(
                name: "Comision",
                schema: "dto",
                table: "plan_de_pago",
                newName: "Interest");

            migrationBuilder.RenameColumn(
                name: "PrestamoEntityClienteId",
                schema: "dto",
                table: "cliente_planepago",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "Nivel_Pago_Con_VSD",
                schema: "dto",
                table: "cliente_planepago",
                newName: "Seguro_de_Vida");

            migrationBuilder.RenameIndex(
                name: "IX_cliente_planepago_PrestamoEntityClienteId",
                schema: "dto",
                table: "cliente_planepago",
                newName: "IX_cliente_planepago_ClienteId");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClienteId",
                schema: "dto",
                table: "plan_de_pago",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<int>(
                name: "No",
                schema: "dto",
                table: "plan_de_pago",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Days",
                schema: "dto",
                table: "plan_de_pago",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "balance_Principal",
                schema: "dto",
                table: "plan_de_pago",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "seguro_de_vida",
                schema: "dto",
                table: "plan_de_pago",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<int>(
                name: "Intereses",
                schema: "dto",
                table: "cliente_planepago",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "Balance_Principal",
                schema: "dto",
                table: "cliente_planepago",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "No",
                schema: "dto",
                table: "cliente_planepago",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Pago_Principal",
                schema: "dto",
                table: "cliente_planepago",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlandePagoNo",
                schema: "dto",
                table: "cliente_planepago",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Comission",
                schema: "dto",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "day_create",
                schema: "dto",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "interert",
                schema: "dto",
                table: "Cliente",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "loan_amount",
                schema: "dto",
                table: "Cliente",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "term",
                schema: "dto",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_plan_de_pago",
                schema: "dto",
                table: "plan_de_pago",
                column: "No");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cliente_planepago",
                schema: "dto",
                table: "cliente_planepago",
                column: "No");

            migrationBuilder.CreateIndex(
                name: "IX_plan_de_pago_ClienteId",
                schema: "dto",
                table: "plan_de_pago",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_planepago_PlandePagoNo",
                schema: "dto",
                table: "cliente_planepago",
                column: "PlandePagoNo");

            migrationBuilder.AddForeignKey(
                name: "FK_cliente_planepago_Cliente_ClienteId",
                schema: "dto",
                table: "cliente_planepago",
                column: "ClienteId",
                principalSchema: "dto",
                principalTable: "Cliente",
                principalColumn: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_cliente_planepago_plan_de_pago_PlandePagoNo",
                schema: "dto",
                table: "cliente_planepago",
                column: "PlandePagoNo",
                principalSchema: "dto",
                principalTable: "plan_de_pago",
                principalColumn: "No");

            migrationBuilder.AddForeignKey(
                name: "FK_plan_de_pago_Cliente_ClienteId",
                schema: "dto",
                table: "plan_de_pago",
                column: "ClienteId",
                principalSchema: "dto",
                principalTable: "Cliente",
                principalColumn: "ClienteId");
        }
    }
}
