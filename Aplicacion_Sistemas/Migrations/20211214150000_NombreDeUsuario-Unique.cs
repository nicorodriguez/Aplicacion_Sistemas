using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplicacion_Sistemas.Migrations
{
    public partial class NombreDeUsuarioUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Usuario_nombre_de_usuario",
                table: "Usuario",
                column: "nombre_de_usuario",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Usuario_nombre_de_usuario",
                table: "Usuario");
        }
    }
}
