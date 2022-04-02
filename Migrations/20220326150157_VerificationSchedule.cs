using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Metrology.Migrations
{
    public partial class VerificationSchedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "organizations",
                schema: "metrology",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organizations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "verification_journal",
                schema: "metrology",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DeviceId = table.Column<int>(type: "integer", nullable: true),
                    OrganizationID = table.Column<int>(type: "integer", nullable: true),
                    IS_DONE = table.Column<bool>(type: "boolean", nullable: false),
                    VERIFICATION_DATE = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_verification_journal", x => x.ID);
                    table.ForeignKey(
                        name: "FK_verification_journal_devices_DeviceId",
                        column: x => x.DeviceId,
                        principalSchema: "metrology",
                        principalTable: "devices",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_verification_journal_organizations_OrganizationID",
                        column: x => x.OrganizationID,
                        principalSchema: "metrology",
                        principalTable: "organizations",
                        principalColumn: "ID");
                });

            migrationBuilder.UpdateData(
                schema: "metrology",
                table: "users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BIRTHDAY", "REGISTRATION_DATE" },
                values: new object[] { new DateTime(2022, 3, 26, 18, 1, 57, 102, DateTimeKind.Local).AddTicks(5906), new DateTime(2022, 3, 26, 18, 1, 57, 102, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.CreateIndex(
                name: "IX_verification_journal_DeviceId",
                schema: "metrology",
                table: "verification_journal",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_verification_journal_OrganizationID",
                schema: "metrology",
                table: "verification_journal",
                column: "OrganizationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "verification_journal",
                schema: "metrology");

            migrationBuilder.DropTable(
                name: "organizations",
                schema: "metrology");

            migrationBuilder.UpdateData(
                schema: "metrology",
                table: "users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "BIRTHDAY", "REGISTRATION_DATE" },
                values: new object[] { new DateTime(2022, 3, 15, 18, 3, 14, 391, DateTimeKind.Local).AddTicks(3885), new DateTime(2022, 3, 15, 18, 3, 14, 391, DateTimeKind.Local).AddTicks(3894) });
        }
    }
}
