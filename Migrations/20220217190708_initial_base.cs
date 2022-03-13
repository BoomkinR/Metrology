using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Metrology.Migrations
{
    public partial class initial_base : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "metrology");

            migrationBuilder.CreateTable(
                name: "device_type",
                schema: "metrology",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NAME = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_device_type", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "location_type",
                schema: "metrology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NAME = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_location_type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "presence_status",
                schema: "metrology",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NAME = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_presence_status", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "role",
                schema: "metrology",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NAME = table.Column<string>(type: "text", nullable: true),
                    PREVILEGIES = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "locations",
                schema: "metrology",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    REGION = table.Column<string>(type: "text", nullable: true),
                    NAME = table.Column<string>(type: "text", nullable: true),
                    LocationTypeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_locations_location_type_LocationTypeId",
                        column: x => x.LocationTypeId,
                        principalSchema: "metrology",
                        principalTable: "location_type",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "users",
                schema: "metrology",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NAME = table.Column<string>(type: "text", nullable: true),
                    SURNAME = table.Column<string>(type: "text", nullable: true),
                    PATRTNAME = table.Column<string>(type: "text", nullable: true),
                    EMAIL = table.Column<string>(type: "text", nullable: true),
                    BIRTHDAY = table.Column<DateTime>(type: "TIMESTAMP(0)", nullable: false),
                    REGISTRATION_DATE = table.Column<DateTime>(type: "TIMESTAMP(0)", nullable: false),
                    PHONE = table.Column<string>(type: "text", nullable: true),
                    LOGIN = table.Column<string>(type: "text", nullable: true),
                    PASSWORD = table.Column<string>(type: "text", nullable: true),
                    RoleId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_users_role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "metrology",
                        principalTable: "role",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "devices",
                schema: "metrology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NAME = table.Column<string>(type: "text", nullable: true),
                    TypeID = table.Column<int>(type: "integer", nullable: true),
                    DEVICE_DATE = table.Column<DateTime>(type: "TIMESTAMP(0)", nullable: false),
                    DATE_EXPLOTATION_START = table.Column<DateTime>(type: "TIMESTAMP(0)", nullable: false),
                    DATE_EXPLOTATION_END = table.Column<DateTime>(type: "TIMESTAMP(0)", nullable: false),
                    SERIAL_NUMBER = table.Column<string>(type: "text", nullable: true),
                    LocationID = table.Column<int>(type: "integer", nullable: true),
                    StatusId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_devices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_devices_device_type_TypeID",
                        column: x => x.TypeID,
                        principalSchema: "metrology",
                        principalTable: "device_type",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_devices_locations_LocationID",
                        column: x => x.LocationID,
                        principalSchema: "metrology",
                        principalTable: "locations",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_devices_presence_status_StatusId",
                        column: x => x.StatusId,
                        principalSchema: "metrology",
                        principalTable: "presence_status",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                schema: "metrology",
                table: "device_type",
                columns: new[] { "ID", "NAME" },
                values: new object[] { 1, "Измерительные" });

            migrationBuilder.InsertData(
                schema: "metrology",
                table: "location_type",
                columns: new[] { "Id", "NAME" },
                values: new object[,]
                {
                    { 1, "В Ремонте" },
                    { 2, "ТСМ" },
                    { 3, "Куст" }
                });

            migrationBuilder.InsertData(
                schema: "metrology",
                table: "presence_status",
                columns: new[] { "ID", "NAME" },
                values: new object[,]
                {
                    { 1, "В Наличие" },
                    { 2, "Передан" }
                });

            migrationBuilder.InsertData(
                schema: "metrology",
                table: "role",
                columns: new[] { "ID", "NAME", "PREVILEGIES" },
                values: new object[,]
                {
                    { 1, "Администратор", 7 },
                    { 2, "Главный Метролог", 5 },
                    { 3, "Метролог", 3 }
                });

            migrationBuilder.InsertData(
                schema: "metrology",
                table: "users",
                columns: new[] { "ID", "BIRTHDAY", "EMAIL", "LOGIN", "NAME", "PASSWORD", "PATRTNAME", "PHONE", "REGISTRATION_DATE", "RoleId", "SURNAME" },
                values: new object[] { 1, new DateTime(2022, 2, 17, 22, 7, 7, 823, DateTimeKind.Local).AddTicks(4087), "admin@admin.ru", "admin", "Admin", "�iv�A���M�߱g��s�K��o*�H�", "Adminov", "88888888888", new DateTime(2022, 2, 17, 22, 7, 7, 823, DateTimeKind.Local).AddTicks(4094), null, "Adminovich" });

            migrationBuilder.CreateIndex(
                name: "IX_devices_LocationID",
                schema: "metrology",
                table: "devices",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_devices_StatusId",
                schema: "metrology",
                table: "devices",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_devices_TypeID",
                schema: "metrology",
                table: "devices",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_locations_LocationTypeId",
                schema: "metrology",
                table: "locations",
                column: "LocationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_users_RoleId",
                schema: "metrology",
                table: "users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "devices",
                schema: "metrology");

            migrationBuilder.DropTable(
                name: "users",
                schema: "metrology");

            migrationBuilder.DropTable(
                name: "device_type",
                schema: "metrology");

            migrationBuilder.DropTable(
                name: "locations",
                schema: "metrology");

            migrationBuilder.DropTable(
                name: "presence_status",
                schema: "metrology");

            migrationBuilder.DropTable(
                name: "role",
                schema: "metrology");

            migrationBuilder.DropTable(
                name: "location_type",
                schema: "metrology");
        }
    }
}
