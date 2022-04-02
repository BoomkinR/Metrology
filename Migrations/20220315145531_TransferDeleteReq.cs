using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Metrology.Migrations
{
    public partial class TransferDeleteReq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "metrology",
                table: "users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BIRTHDAY", "REGISTRATION_DATE" },
                values: new object[] { new DateTime(2022, 3, 15, 17, 55, 30, 816, DateTimeKind.Local).AddTicks(9475), new DateTime(2022, 3, 15, 17, 55, 30, 816, DateTimeKind.Local).AddTicks(9483) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "metrology",
                table: "users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BIRTHDAY", "REGISTRATION_DATE" },
                values: new object[] { new DateTime(2022, 3, 13, 17, 14, 52, 77, DateTimeKind.Local).AddTicks(5554), new DateTime(2022, 3, 13, 17, 14, 52, 77, DateTimeKind.Local).AddTicks(5563) });
        }
    }
}
