using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Metrology.Migrations
{
    public partial class TransferDeleteReq2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TRANSFER_DATE",
                schema: "metrology",
                table: "transfer_log",
                type: "TIMESTAMP(0)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(0)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ACCEPTED_DATE",
                schema: "metrology",
                table: "transfer_log",
                type: "TIMESTAMP(0)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(0)");

            migrationBuilder.AlterColumn<bool>(
                name: "ACCEPTED",
                schema: "metrology",
                table: "transfer_log",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.UpdateData(
                schema: "metrology",
                table: "users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BIRTHDAY", "REGISTRATION_DATE" },
                values: new object[] { new DateTime(2022, 3, 15, 18, 3, 14, 391, DateTimeKind.Local).AddTicks(3885), new DateTime(2022, 3, 15, 18, 3, 14, 391, DateTimeKind.Local).AddTicks(3894) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TRANSFER_DATE",
                schema: "metrology",
                table: "transfer_log",
                type: "TIMESTAMP(0)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ACCEPTED_DATE",
                schema: "metrology",
                table: "transfer_log",
                type: "TIMESTAMP(0)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TIMESTAMP(0)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ACCEPTED",
                schema: "metrology",
                table: "transfer_log",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "metrology",
                table: "users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BIRTHDAY", "REGISTRATION_DATE" },
                values: new object[] { new DateTime(2022, 3, 15, 17, 55, 30, 816, DateTimeKind.Local).AddTicks(9475), new DateTime(2022, 3, 15, 17, 55, 30, 816, DateTimeKind.Local).AddTicks(9483) });
        }
    }
}
