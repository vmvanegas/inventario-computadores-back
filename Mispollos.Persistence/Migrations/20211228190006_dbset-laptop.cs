using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mispollos.Persistence.Migrations
{
    public partial class dbsetlaptop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: new Guid("a3bce346-142f-406e-85a9-666c3f806c17"));

            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: new Guid("c507f6f2-fd7f-404d-82a2-8bff29de44c7"));

            migrationBuilder.CreateTable(
                name: "Laptop",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cpu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ranura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SsdHdd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Responsable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    So = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptop", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreatedOn", "Nombre", "UpdatedOn" },
                values: new object[] { new Guid("947b03ad-eb52-4006-9c4b-eaa6e5c2822b"), new DateTime(2021, 12, 28, 14, 0, 6, 52, DateTimeKind.Local).AddTicks(3747), "Admin", new DateTime(2021, 12, 28, 14, 0, 6, 53, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreatedOn", "Nombre", "UpdatedOn" },
                values: new object[] { new Guid("7b12e84a-6cfc-46b2-bf95-64999608acfe"), new DateTime(2021, 12, 28, 14, 0, 6, 53, DateTimeKind.Local).AddTicks(1376), "Usuario", new DateTime(2021, 12, 28, 14, 0, 6, 53, DateTimeKind.Local).AddTicks(1382) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Laptop");

            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: new Guid("7b12e84a-6cfc-46b2-bf95-64999608acfe"));

            migrationBuilder.DeleteData(
                table: "Rol",
                keyColumn: "Id",
                keyValue: new Guid("947b03ad-eb52-4006-9c4b-eaa6e5c2822b"));

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreatedOn", "Nombre", "UpdatedOn" },
                values: new object[] { new Guid("c507f6f2-fd7f-404d-82a2-8bff29de44c7"), new DateTime(2021, 12, 28, 13, 42, 43, 407, DateTimeKind.Local).AddTicks(3818), "Admin", new DateTime(2021, 12, 28, 13, 42, 43, 407, DateTimeKind.Local).AddTicks(9942) });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "Id", "CreatedOn", "Nombre", "UpdatedOn" },
                values: new object[] { new Guid("a3bce346-142f-406e-85a9-666c3f806c17"), new DateTime(2021, 12, 28, 13, 42, 43, 408, DateTimeKind.Local).AddTicks(770), "Usuario", new DateTime(2021, 12, 28, 13, 42, 43, 408, DateTimeKind.Local).AddTicks(775) });
        }
    }
}
