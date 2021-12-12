using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplicacion_Sistemas.Migrations
{
    public partial class Contrasenia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "contrasena",
                table: "Usuario",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "id",
                keyValue: 1,
                column: "contrasena",
                value: "123456");

            migrationBuilder.UpdateData(
                table: "Usuario",
                keyColumn: "id",
                keyValue: 2,
                column: "contrasena",
                value: "empleado");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "contrasena",
                table: "Usuario");
        }
    }
}
