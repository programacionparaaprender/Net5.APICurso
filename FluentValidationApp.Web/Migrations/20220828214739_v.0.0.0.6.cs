using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FluentValidationApp.Web.Migrations
{
    public partial class v0006 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Cargas",
                keyColumn: "CargaId",
                keyValue: 1L,
                columns: new[] { "Ciclo", "FechaProgramada", "Fin", "Inicio", "creado" },
                values: new object[] { new DateTime(2022, 8, 28, 16, 47, 39, 39, DateTimeKind.Local).AddTicks(9903), new DateTime(2022, 8, 28, 16, 47, 39, 41, DateTimeKind.Local).AddTicks(1483), new DateTime(2022, 8, 28, 16, 47, 39, 41, DateTimeKind.Local).AddTicks(2888), new DateTime(2022, 8, 28, 16, 47, 39, 41, DateTimeKind.Local).AddTicks(2498), new DateTime(2022, 8, 28, 16, 47, 39, 41, DateTimeKind.Local).AddTicks(3357) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "Cargas",
                keyColumn: "CargaId",
                keyValue: 1L,
                columns: new[] { "Ciclo", "FechaProgramada", "Fin", "Inicio", "creado" },
                values: new object[] { new DateTime(2022, 8, 22, 11, 12, 12, 323, DateTimeKind.Local).AddTicks(5196), new DateTime(2022, 8, 22, 11, 12, 12, 328, DateTimeKind.Local).AddTicks(3364), new DateTime(2022, 8, 22, 11, 12, 12, 328, DateTimeKind.Local).AddTicks(4233), new DateTime(2022, 8, 22, 11, 12, 12, 328, DateTimeKind.Local).AddTicks(3954), new DateTime(2022, 8, 22, 11, 12, 12, 328, DateTimeKind.Local).AddTicks(4501) });
        }
    }
}
