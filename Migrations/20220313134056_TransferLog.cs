using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Metrology.Migrations
{
    public partial class TransferLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_devices_device_type_TypeID",
                schema: "metrology",
                table: "devices");

            migrationBuilder.AlterColumn<int>(
                name: "TypeID",
                schema: "metrology",
                table: "devices",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NAME",
                schema: "metrology",
                table: "devices",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerUserID",
                schema: "metrology",
                table: "devices",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "contractors",
                schema: "metrology",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ORGANISATION_NAME = table.Column<string>(type: "text", nullable: true),
                    INN = table.Column<string>(type: "text", nullable: true),
                    CONTACT_CLIENT = table.Column<string>(type: "text", nullable: true),
                    CONTACT_NUMBER = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contractors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "transfer_log",
                schema: "metrology",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserFromID = table.Column<int>(type: "integer", nullable: true),
                    UserToID = table.Column<int>(type: "integer", nullable: true),
                    DeviceId = table.Column<int>(type: "integer", nullable: true),
                    ACCEPTED = table.Column<bool>(type: "boolean", nullable: false),
                    TRANSFER_DATE = table.Column<DateTime>(type: "TIMESTAMP(0)", nullable: false),
                    ACCEPTED_DATE = table.Column<DateTime>(type: "TIMESTAMP(0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transfer_log", x => x.ID);
                    table.ForeignKey(
                        name: "FK_transfer_log_devices_DeviceId",
                        column: x => x.DeviceId,
                        principalSchema: "metrology",
                        principalTable: "devices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_transfer_log_users_UserFromID",
                        column: x => x.UserFromID,
                        principalSchema: "metrology",
                        principalTable: "users",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_transfer_log_users_UserToID",
                        column: x => x.UserToID,
                        principalSchema: "metrology",
                        principalTable: "users",
                        principalColumn: "ID");
                });

            migrationBuilder.UpdateData(
                schema: "metrology",
                table: "users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BIRTHDAY", "REGISTRATION_DATE" },
                values: new object[] { new DateTime(2022, 3, 13, 16, 40, 56, 157, DateTimeKind.Local).AddTicks(200), new DateTime(2022, 3, 13, 16, 40, 56, 157, DateTimeKind.Local).AddTicks(208) });

            migrationBuilder.CreateIndex(
                name: "IX_devices_OwnerUserID",
                schema: "metrology",
                table: "devices",
                column: "OwnerUserID");

            migrationBuilder.CreateIndex(
                name: "IX_transfer_log_DeviceId",
                schema: "metrology",
                table: "transfer_log",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_transfer_log_UserFromID",
                schema: "metrology",
                table: "transfer_log",
                column: "UserFromID");

            migrationBuilder.CreateIndex(
                name: "IX_transfer_log_UserToID",
                schema: "metrology",
                table: "transfer_log",
                column: "UserToID");

            migrationBuilder.AddForeignKey(
                name: "FK_devices_device_type_TypeID",
                schema: "metrology",
                table: "devices",
                column: "TypeID",
                principalSchema: "metrology",
                principalTable: "device_type",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_devices_users_OwnerUserID",
                schema: "metrology",
                table: "devices",
                column: "OwnerUserID",
                principalSchema: "metrology",
                principalTable: "users",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_devices_device_type_TypeID",
                schema: "metrology",
                table: "devices");

            migrationBuilder.DropForeignKey(
                name: "FK_devices_users_OwnerUserID",
                schema: "metrology",
                table: "devices");

            migrationBuilder.DropTable(
                name: "contractors",
                schema: "metrology");

            migrationBuilder.DropTable(
                name: "transfer_log",
                schema: "metrology");

            migrationBuilder.DropIndex(
                name: "IX_devices_OwnerUserID",
                schema: "metrology",
                table: "devices");

            migrationBuilder.DropColumn(
                name: "OwnerUserID",
                schema: "metrology",
                table: "devices");

            migrationBuilder.AlterColumn<int>(
                name: "TypeID",
                schema: "metrology",
                table: "devices",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "NAME",
                schema: "metrology",
                table: "devices",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                schema: "metrology",
                table: "users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BIRTHDAY", "REGISTRATION_DATE" },
                values: new object[] { new DateTime(2022, 2, 17, 22, 7, 7, 823, DateTimeKind.Local).AddTicks(4087), new DateTime(2022, 2, 17, 22, 7, 7, 823, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.AddForeignKey(
                name: "FK_devices_device_type_TypeID",
                schema: "metrology",
                table: "devices",
                column: "TypeID",
                principalSchema: "metrology",
                principalTable: "device_type",
                principalColumn: "ID");
        }
    }
}
