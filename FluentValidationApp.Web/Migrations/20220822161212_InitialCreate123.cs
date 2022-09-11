using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FluentValidationApp.Web.Migrations
{
    public partial class InitialCreate123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AjusteRecibos_Recibo_ReciboId",
                table: "AjusteRecibos");

            migrationBuilder.DropForeignKey(
                name: "FK_AjusteRecibos_TipoAjusteRecibo_TipoAjusteReciboId",
                table: "AjusteRecibos");

            migrationBuilder.DropForeignKey(
                name: "FK_Bajas_Recibo_ReciboId",
                table: "Bajas");

            migrationBuilder.DropForeignKey(
                name: "FK_ConfiguracionFinanciamiento_CampaniaFinanciamientos_CampaniaFinanciamientoId",
                table: "ConfiguracionFinanciamiento");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleBaja_Bajas_BajaId",
                table: "DetalleBaja");

            migrationBuilder.DropForeignKey(
                name: "FK_Financiamiento_CampaniaFinanciamientos_CampaniaFinanciamientoId",
                table: "Financiamiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CampaniaGenerales",
                table: "CampaniaGenerales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CampaniaFinanciamientos",
                table: "CampaniaFinanciamientos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bajas",
                table: "Bajas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AjusteRecibos",
                table: "AjusteRecibos");

            migrationBuilder.RenameTable(
                name: "CampaniaGenerales",
                newName: "CampaniaGeneral");

            migrationBuilder.RenameTable(
                name: "CampaniaFinanciamientos",
                newName: "CampaniaFinanciamiento");

            migrationBuilder.RenameTable(
                name: "Bajas",
                newName: "Baja");

            migrationBuilder.RenameTable(
                name: "AjusteRecibos",
                newName: "AjusteRecibo");

            migrationBuilder.RenameIndex(
                name: "IX_Bajas_ReciboId",
                table: "Baja",
                newName: "IX_Baja_ReciboId");

            migrationBuilder.RenameIndex(
                name: "IX_AjusteRecibos_TipoAjusteReciboId",
                table: "AjusteRecibo",
                newName: "IX_AjusteRecibo_TipoAjusteReciboId");

            migrationBuilder.RenameIndex(
                name: "IX_AjusteRecibos_ReciboId",
                table: "AjusteRecibo",
                newName: "IX_AjusteRecibo_ReciboId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CampaniaGeneral",
                table: "CampaniaGeneral",
                column: "CampaniaGeneralId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CampaniaFinanciamiento",
                table: "CampaniaFinanciamiento",
                column: "CampaniaFinanciamientoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Baja",
                table: "Baja",
                column: "BajaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AjusteRecibo",
                table: "AjusteRecibo",
                column: "AjusteReciboId");

            migrationBuilder.UpdateData(
                table: "Cargas",
                keyColumn: "CargaId",
                keyValue: 1L,
                columns: new[] { "Ciclo", "FechaProgramada", "Fin", "Inicio", "creado" },
                values: new object[] { new DateTime(2022, 8, 22, 11, 12, 12, 323, DateTimeKind.Local).AddTicks(5196), new DateTime(2022, 8, 22, 11, 12, 12, 328, DateTimeKind.Local).AddTicks(3364), new DateTime(2022, 8, 22, 11, 12, 12, 328, DateTimeKind.Local).AddTicks(4233), new DateTime(2022, 8, 22, 11, 12, 12, 328, DateTimeKind.Local).AddTicks(3954), new DateTime(2022, 8, 22, 11, 12, 12, 328, DateTimeKind.Local).AddTicks(4501) });

            migrationBuilder.AddForeignKey(
                name: "FK_AjusteRecibo_Recibo_ReciboId",
                table: "AjusteRecibo",
                column: "ReciboId",
                principalTable: "Recibo",
                principalColumn: "ReciboId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AjusteRecibo_TipoAjusteRecibo_TipoAjusteReciboId",
                table: "AjusteRecibo",
                column: "TipoAjusteReciboId",
                principalTable: "TipoAjusteRecibo",
                principalColumn: "TipoAjusteReciboId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Baja_Recibo_ReciboId",
                table: "Baja",
                column: "ReciboId",
                principalTable: "Recibo",
                principalColumn: "ReciboId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConfiguracionFinanciamiento_CampaniaFinanciamiento_CampaniaFinanciamientoId",
                table: "ConfiguracionFinanciamiento",
                column: "CampaniaFinanciamientoId",
                principalTable: "CampaniaFinanciamiento",
                principalColumn: "CampaniaFinanciamientoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleBaja_Baja_BajaId",
                table: "DetalleBaja",
                column: "BajaId",
                principalTable: "Baja",
                principalColumn: "BajaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Financiamiento_CampaniaFinanciamiento_CampaniaFinanciamientoId",
                table: "Financiamiento",
                column: "CampaniaFinanciamientoId",
                principalTable: "CampaniaFinanciamiento",
                principalColumn: "CampaniaFinanciamientoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AjusteRecibo_Recibo_ReciboId",
                table: "AjusteRecibo");

            migrationBuilder.DropForeignKey(
                name: "FK_AjusteRecibo_TipoAjusteRecibo_TipoAjusteReciboId",
                table: "AjusteRecibo");

            migrationBuilder.DropForeignKey(
                name: "FK_Baja_Recibo_ReciboId",
                table: "Baja");

            migrationBuilder.DropForeignKey(
                name: "FK_ConfiguracionFinanciamiento_CampaniaFinanciamiento_CampaniaFinanciamientoId",
                table: "ConfiguracionFinanciamiento");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleBaja_Baja_BajaId",
                table: "DetalleBaja");

            migrationBuilder.DropForeignKey(
                name: "FK_Financiamiento_CampaniaFinanciamiento_CampaniaFinanciamientoId",
                table: "Financiamiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CampaniaGeneral",
                table: "CampaniaGeneral");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CampaniaFinanciamiento",
                table: "CampaniaFinanciamiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Baja",
                table: "Baja");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AjusteRecibo",
                table: "AjusteRecibo");

            migrationBuilder.RenameTable(
                name: "CampaniaGeneral",
                newName: "CampaniaGenerales");

            migrationBuilder.RenameTable(
                name: "CampaniaFinanciamiento",
                newName: "CampaniaFinanciamientos");

            migrationBuilder.RenameTable(
                name: "Baja",
                newName: "Bajas");

            migrationBuilder.RenameTable(
                name: "AjusteRecibo",
                newName: "AjusteRecibos");

            migrationBuilder.RenameIndex(
                name: "IX_Baja_ReciboId",
                table: "Bajas",
                newName: "IX_Bajas_ReciboId");

            migrationBuilder.RenameIndex(
                name: "IX_AjusteRecibo_TipoAjusteReciboId",
                table: "AjusteRecibos",
                newName: "IX_AjusteRecibos_TipoAjusteReciboId");

            migrationBuilder.RenameIndex(
                name: "IX_AjusteRecibo_ReciboId",
                table: "AjusteRecibos",
                newName: "IX_AjusteRecibos_ReciboId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CampaniaGenerales",
                table: "CampaniaGenerales",
                column: "CampaniaGeneralId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CampaniaFinanciamientos",
                table: "CampaniaFinanciamientos",
                column: "CampaniaFinanciamientoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bajas",
                table: "Bajas",
                column: "BajaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AjusteRecibos",
                table: "AjusteRecibos",
                column: "AjusteReciboId");

            migrationBuilder.UpdateData(
                table: "Cargas",
                keyColumn: "CargaId",
                keyValue: 1L,
                columns: new[] { "Ciclo", "FechaProgramada", "Fin", "Inicio", "creado" },
                values: new object[] { new DateTime(2022, 8, 22, 9, 10, 7, 166, DateTimeKind.Local).AddTicks(1217), new DateTime(2022, 8, 22, 9, 10, 7, 173, DateTimeKind.Local).AddTicks(7231), new DateTime(2022, 8, 22, 9, 10, 7, 173, DateTimeKind.Local).AddTicks(9570), new DateTime(2022, 8, 22, 9, 10, 7, 173, DateTimeKind.Local).AddTicks(8667), new DateTime(2022, 8, 22, 9, 10, 7, 174, DateTimeKind.Local).AddTicks(302) });

            migrationBuilder.AddForeignKey(
                name: "FK_AjusteRecibos_Recibo_ReciboId",
                table: "AjusteRecibos",
                column: "ReciboId",
                principalTable: "Recibo",
                principalColumn: "ReciboId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AjusteRecibos_TipoAjusteRecibo_TipoAjusteReciboId",
                table: "AjusteRecibos",
                column: "TipoAjusteReciboId",
                principalTable: "TipoAjusteRecibo",
                principalColumn: "TipoAjusteReciboId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bajas_Recibo_ReciboId",
                table: "Bajas",
                column: "ReciboId",
                principalTable: "Recibo",
                principalColumn: "ReciboId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ConfiguracionFinanciamiento_CampaniaFinanciamientos_CampaniaFinanciamientoId",
                table: "ConfiguracionFinanciamiento",
                column: "CampaniaFinanciamientoId",
                principalTable: "CampaniaFinanciamientos",
                principalColumn: "CampaniaFinanciamientoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleBaja_Bajas_BajaId",
                table: "DetalleBaja",
                column: "BajaId",
                principalTable: "Bajas",
                principalColumn: "BajaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Financiamiento_CampaniaFinanciamientos_CampaniaFinanciamientoId",
                table: "Financiamiento",
                column: "CampaniaFinanciamientoId",
                principalTable: "CampaniaFinanciamientos",
                principalColumn: "CampaniaFinanciamientoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
