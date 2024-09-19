using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MinDescription",
                table: "Auctions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MinDescription", "TimeEnd", "TimeStart" },
                values: new object[] { "500-hp V8, Rare DTM-Inspired CLK, Mostly Unmodified", new DateTime(2024, 9, 26, 0, 16, 57, 248, DateTimeKind.Local).AddTicks(3213), new DateTime(2024, 9, 19, 0, 16, 57, 248, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MinDescription", "TimeEnd", "TimeStart" },
                values: new object[] { "~18,000 Miles, 2 Owners, Supercharged AMG V6, Unmodified", new DateTime(2024, 9, 26, 0, 16, 57, 248, DateTimeKind.Local).AddTicks(3230), new DateTime(2024, 9, 19, 0, 16, 57, 248, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MinDescription", "TimeEnd", "TimeStart" },
                values: new object[] { "Twin-Turbo V8, Sport Package, Some Modifications", new DateTime(2024, 9, 26, 0, 16, 57, 248, DateTimeKind.Local).AddTicks(3239), new DateTime(2024, 9, 19, 0, 16, 57, 248, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MinDescription", "TimeEnd", "TimeStart" },
                values: new object[] { "V10 Power, Rod Bearings Replaced, Mostly Unmodified", new DateTime(2024, 9, 26, 0, 16, 57, 248, DateTimeKind.Local).AddTicks(3247), new DateTime(2024, 9, 19, 0, 16, 57, 248, DateTimeKind.Local).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MinDescription", "TimeEnd", "TimeStart" },
                values: new object[] { "~37,000 Miles, Rare Coupe Model, 5-Speed Manual, Extensively Modified", new DateTime(2024, 9, 26, 0, 16, 57, 248, DateTimeKind.Local).AddTicks(3255), new DateTime(2024, 9, 19, 0, 16, 57, 248, DateTimeKind.Local).AddTicks(3252) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MinDescription",
                table: "Auctions");

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 12, 15, 414, DateTimeKind.Local).AddTicks(707), new DateTime(2024, 9, 15, 16, 12, 15, 414, DateTimeKind.Local).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 12, 15, 414, DateTimeKind.Local).AddTicks(714), new DateTime(2024, 9, 15, 16, 12, 15, 414, DateTimeKind.Local).AddTicks(713) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 12, 15, 414, DateTimeKind.Local).AddTicks(719), new DateTime(2024, 9, 15, 16, 12, 15, 414, DateTimeKind.Local).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 12, 15, 414, DateTimeKind.Local).AddTicks(723), new DateTime(2024, 9, 15, 16, 12, 15, 414, DateTimeKind.Local).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 9, 22, 16, 12, 15, 414, DateTimeKind.Local).AddTicks(727), new DateTime(2024, 9, 15, 16, 12, 15, 414, DateTimeKind.Local).AddTicks(726) });
        }
    }
}
