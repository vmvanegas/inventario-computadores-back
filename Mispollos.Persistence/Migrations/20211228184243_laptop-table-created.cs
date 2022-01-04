using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mispollos.Persistence.Migrations
{
    public partial class laptoptablecreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: new Guid("0f98b103-5966-46dd-9d04-2b8366e85bc8"));

            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: new Guid("e83e2050-45af-40db-b664-e81f3c065c25"));

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreatedOn", "Nombre", "UpdatedOn" },
                values: new object[] { new Guid("c507f6f2-fd7f-404d-82a2-8bff29de44c7"), new DateTime(2021, 12, 28, 13, 42, 43, 407, DateTimeKind.Local).AddTicks(3818), "Admin", new DateTime(2021, 12, 28, 13, 42, 43, 407, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreatedOn", "Nombre", "UpdatedOn" },
                values: new object[] { new Guid("a3bce346-142f-406e-85a9-666c3f806c17"), new DateTime(2021, 12, 28, 13, 42, 43, 408, DateTimeKind.Local).AddTicks(770), "Usuario", new DateTime(2021, 12, 28, 13, 42, 43, 408, DateTimeKind.Local).AddTicks(775) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: new Guid("a3bce346-142f-406e-85a9-666c3f806c17"));

            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: new Guid("c507f6f2-fd7f-404d-82a2-8bff29de44c7"));

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreatedOn", "Nombre", "UpdatedOn" },
                values: new object[] { new Guid("e83e2050-45af-40db-b664-e81f3c065c25"), new DateTime(2021, 7, 6, 19, 7, 40, 561, DateTimeKind.Local).AddTicks(8796), "Admin", new DateTime(2021, 7, 6, 19, 7, 40, 562, DateTimeKind.Local).AddTicks(6127) });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreatedOn", "Nombre", "UpdatedOn" },
                values: new object[] { new Guid("0f98b103-5966-46dd-9d04-2b8366e85bc8"), new DateTime(2021, 7, 6, 19, 7, 40, 562, DateTimeKind.Local).AddTicks(7016), "Usuario", new DateTime(2021, 7, 6, 19, 7, 40, 562, DateTimeKind.Local).AddTicks(7022) });
        }
    }
}
