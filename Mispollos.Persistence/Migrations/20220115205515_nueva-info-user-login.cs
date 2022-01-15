using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mispollos.Persistence.Migrations
{
    public partial class nuevainfouserlogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Rol_IdRol",
                table: "Usuario");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Tienda_IdTienda",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_IdRol",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_IdTienda",
                table: "Usuario");

            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: new Guid("3328ba4b-1ad5-41ba-bf7a-2c7e5f1e79e5"));

            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: new Guid("a0706beb-5214-46b0-9d16-950b22d595c0"));

            migrationBuilder.DropColumn(
                name: "IdRol",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "IdTienda",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "TokenExpiration",
                table: "Usuario");

            migrationBuilder.RenameColumn(
                name: "Correo",
                table: "Usuario",
                newName: "NombreDeUsuario");

            migrationBuilder.AddColumn<string>(
                name: "Cargo",
                table: "Usuario",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreatedOn", "Nombre", "UpdatedOn" },
                values: new object[] { new Guid("df5c6c2b-dc58-472a-9744-a79b5e928d6b"), new DateTime(2022, 1, 15, 15, 55, 14, 634, DateTimeKind.Local).AddTicks(5061), "Admin", new DateTime(2022, 1, 15, 15, 55, 14, 635, DateTimeKind.Local).AddTicks(1454) });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreatedOn", "Nombre", "UpdatedOn" },
                values: new object[] { new Guid("024b38d6-4504-467a-91ce-c56c51b56061"), new DateTime(2022, 1, 15, 15, 55, 14, 635, DateTimeKind.Local).AddTicks(2345), "Usuario", new DateTime(2022, 1, 15, 15, 55, 14, 635, DateTimeKind.Local).AddTicks(2350) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: new Guid("024b38d6-4504-467a-91ce-c56c51b56061"));

            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: new Guid("df5c6c2b-dc58-472a-9744-a79b5e928d6b"));

            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "Usuario");

            migrationBuilder.RenameColumn(
                name: "NombreDeUsuario",
                table: "Usuario",
                newName: "Correo");

            migrationBuilder.AddColumn<Guid>(
                name: "IdRol",
                table: "Usuario",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdTienda",
                table: "Usuario",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Token",
                table: "Usuario",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "TokenExpiration",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreatedOn", "Nombre", "UpdatedOn" },
                values: new object[] { new Guid("a0706beb-5214-46b0-9d16-950b22d595c0"), new DateTime(2022, 1, 2, 12, 55, 9, 432, DateTimeKind.Local).AddTicks(485), "Admin", new DateTime(2022, 1, 2, 12, 55, 9, 432, DateTimeKind.Local).AddTicks(6912) });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreatedOn", "Nombre", "UpdatedOn" },
                values: new object[] { new Guid("3328ba4b-1ad5-41ba-bf7a-2c7e5f1e79e5"), new DateTime(2022, 1, 2, 12, 55, 9, 432, DateTimeKind.Local).AddTicks(7715), "Usuario", new DateTime(2022, 1, 2, 12, 55, 9, 432, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdRol",
                table: "Usuario",
                column: "IdRol");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdTienda",
                table: "Usuario",
                column: "IdTienda");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Rol_IdRol",
                table: "Usuario",
                column: "IdRol",
                principalTable: "Rol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Tienda_IdTienda",
                table: "Usuario",
                column: "IdTienda",
                principalTable: "Tienda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
