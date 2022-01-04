using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mispollos.Persistence.Migrations
{
    public partial class tablasinventariocomputadores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: new Guid("0e338e89-15f1-451c-8b74-af412937cd2b"));

            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: new Guid("f405a4be-46c1-4bb8-851e-c994273ab139"));

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreatedOn", "Nombre", "UpdatedOn" },
                values: new object[] { new Guid("9d773913-8f84-42bb-b1af-78445419f69d"), new DateTime(2022, 1, 2, 12, 22, 40, 384, DateTimeKind.Local).AddTicks(7936), "Admin", new DateTime(2022, 1, 2, 12, 22, 40, 385, DateTimeKind.Local).AddTicks(3959) });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreatedOn", "Nombre", "UpdatedOn" },
                values: new object[] { new Guid("9548c59c-9a02-4b83-849c-f62e84918012"), new DateTime(2022, 1, 2, 12, 22, 40, 385, DateTimeKind.Local).AddTicks(4780), "Usuario", new DateTime(2022, 1, 2, 12, 22, 40, 385, DateTimeKind.Local).AddTicks(4786) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: new Guid("9548c59c-9a02-4b83-849c-f62e84918012"));

            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: new Guid("9d773913-8f84-42bb-b1af-78445419f69d"));

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreatedOn", "Nombre", "UpdatedOn" },
                values: new object[] { new Guid("f405a4be-46c1-4bb8-851e-c994273ab139"), new DateTime(2021, 12, 29, 13, 52, 26, 269, DateTimeKind.Local).AddTicks(7286), "Admin", new DateTime(2021, 12, 29, 13, 52, 26, 270, DateTimeKind.Local).AddTicks(3354) });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreatedOn", "Nombre", "UpdatedOn" },
                values: new object[] { new Guid("0e338e89-15f1-451c-8b74-af412937cd2b"), new DateTime(2021, 12, 29, 13, 52, 26, 270, DateTimeKind.Local).AddTicks(4161), "Usuario", new DateTime(2021, 12, 29, 13, 52, 26, 270, DateTimeKind.Local).AddTicks(4167) });
        }
    }
}
