using Microsoft.EntityFrameworkCore.Migrations;

namespace Aplicacion_Sistemas.Migrations
{
    public partial class GeneratedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TipoProducto_Producto",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_RolUsuario",
                table: "Usuario");

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "id", "nombre" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Empleado" }
                });

            migrationBuilder.InsertData(
                table: "Tipo_Producto",
                columns: new[] { "id", "nombre" },
                values: new object[,]
                {
                    { 1, "Carnes" },
                    { 2, "Verduras" },
                    { 3, "Bebidas" },
                    { 4, "Electrodomésticos" },
                    { 5, "Golosinas" },
                    { 6, "Envasados" }
                });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "id", "cantidad", "marca", "nombre", "precio", "tipo_producto_id" },
                values: new object[,]
                {
                    { 4, 20, "Excelente", "Papa blanca 1Kg", 40m, 2 },
                    { 2, 30, "Kunington", "Gaseosa sabor Ginger Ale 1.5L", 80m, 3 },
                    { 3, 90, "Kunington", "Gaseosa sabor Cola 1.5L", 85m, 3 },
                    { 1, 10, "La Mejor", "Ventilador", 10.500m, 4 }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "id", "apellido", "nombre", "nombre_de_usuario", "rol_id" },
                values: new object[,]
                {
                    { 1, "Saltirana", "Carla", "carlasaltirana", 1 },
                    { 2, "Perez", "Jorge", "jorgeperez", 2 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TipoProducto_Producto",
                table: "Producto",
                column: "tipo_producto_id",
                principalTable: "Tipo_Producto",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolUsuario",
                table: "Usuario",
                column: "rol_id",
                principalTable: "Rol",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TipoProducto_Producto",
                table: "Producto");

            migrationBuilder.DropForeignKey(
                name: "FK_RolUsuario",
                table: "Usuario");

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tipo_Producto",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tipo_Producto",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tipo_Producto",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tipo_Producto",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tipo_Producto",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tipo_Producto",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.AddForeignKey(
                name: "FK_TipoProducto_Producto",
                table: "Producto",
                column: "tipo_producto_id",
                principalTable: "Tipo_Producto",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RolUsuario",
                table: "Usuario",
                column: "rol_id",
                principalTable: "Rol",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
