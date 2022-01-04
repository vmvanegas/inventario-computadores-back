using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mispollos.Persistence.Migrations
{
    public partial class ramandbackupfieldaddedtolaptoptable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: new Guid("7b12e84a-6cfc-46b2-bf95-64999608acfe"));

            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: new Guid("947b03ad-eb52-4006-9c4b-eaa6e5c2822b"));

            migrationBuilder.AddColumn<string>(
                name: "Backup",
                table: "Laptop",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ram",
                table: "Laptop",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreatedOn", "Nombre", "UpdatedOn" },
                values: new object[] { new Guid("f405a4be-46c1-4bb8-851e-c994273ab139"), new DateTime(2021, 12, 29, 13, 52, 26, 269, DateTimeKind.Local).AddTicks(7286), "Admin", new DateTime(2021, 12, 29, 13, 52, 26, 270, DateTimeKind.Local).AddTicks(3354) });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreatedOn", "Nombre", "UpdatedOn" },
                values: new object[] { new Guid("0e338e89-15f1-451c-8b74-af412937cd2b"), new DateTime(2021, 12, 29, 13, 52, 26, 270, DateTimeKind.Local).AddTicks(4161), "Usuario", new DateTime(2021, 12, 29, 13, 52, 26, 270, DateTimeKind.Local).AddTicks(4167) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: new Guid("0e338e89-15f1-451c-8b74-af412937cd2b"));

            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: new Guid("f405a4be-46c1-4bb8-851e-c994273ab139"));

            migrationBuilder.DropColumn(
                name: "Backup",
                table: "Laptop");

            migrationBuilder.DropColumn(
                name: "Ram",
                table: "Laptop");

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreatedOn", "Nombre", "UpdatedOn" },
                values: new object[] { new Guid("947b03ad-eb52-4006-9c4b-eaa6e5c2822b"), new DateTime(2021, 12, 28, 14, 0, 6, 52, DateTimeKind.Local).AddTicks(3747), "Admin", new DateTime(2021, 12, 28, 14, 0, 6, 53, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreatedOn", "Nombre", "UpdatedOn" },
                values: new object[] { new Guid("7b12e84a-6cfc-46b2-bf95-64999608acfe"), new DateTime(2021, 12, 28, 14, 0, 6, 53, DateTimeKind.Local).AddTicks(1376), "Usuario", new DateTime(2021, 12, 28, 14, 0, 6, 53, DateTimeKind.Local).AddTicks(1382) });
        }
    }
}
