using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Metrology.Migrations
{
    public partial class TransferNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NOTE",
                schema: "metrology",
                table: "transfer_log",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "metrology",
                table: "users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BIRTHDAY", "REGISTRATION_DATE" },
                values: new object[] { new DateTime(2022, 3, 13, 17, 14, 52, 77, DateTimeKind.Local).AddTicks(5554), new DateTime(2022, 3, 13, 17, 14, 52, 77, DateTimeKind.Local).AddTicks(5563) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NOTE",
                schema: "metrology",
                table: "transfer_log");

            migrationBuilder.UpdateData(
                schema: "metrology",
                table: "users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BIRTHDAY", "REGISTRATION_DATE" },
                values: new object[] { new DateTime(2022, 3, 13, 16, 40, 56, 157, DateTimeKind.Local).AddTicks(200), new DateTime(2022, 3, 13, 16, 40, 56, 157, DateTimeKind.Local).AddTicks(208) });
        }
    }
}
