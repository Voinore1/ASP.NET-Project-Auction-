using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InteriorColor",
                table: "Venichles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 8, 20, 23, 52, 811, DateTimeKind.Local).AddTicks(6576), new DateTime(2024, 10, 1, 20, 23, 52, 811, DateTimeKind.Local).AddTicks(6522) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 8, 20, 23, 52, 811, DateTimeKind.Local).AddTicks(6584), new DateTime(2024, 10, 1, 20, 23, 52, 811, DateTimeKind.Local).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 8, 20, 23, 52, 811, DateTimeKind.Local).AddTicks(6590), new DateTime(2024, 10, 1, 20, 23, 52, 811, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 8, 20, 23, 52, 811, DateTimeKind.Local).AddTicks(6596), new DateTime(2024, 10, 1, 20, 23, 52, 811, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 8, 20, 23, 52, 811, DateTimeKind.Local).AddTicks(6601), new DateTime(2024, 10, 1, 20, 23, 52, 811, DateTimeKind.Local).AddTicks(6599) });

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 1,
                column: "InteriorColor",
                value: "Black");

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 2,
                column: "InteriorColor",
                value: "Black");

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 3,
                column: "InteriorColor",
                value: "Black");

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 4,
                column: "InteriorColor",
                value: "Black");

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 5,
                column: "InteriorColor",
                value: "Black");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InteriorColor",
                table: "Venichles");

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 8, 20, 1, 11, 556, DateTimeKind.Local).AddTicks(4262), new DateTime(2024, 10, 1, 20, 1, 11, 556, DateTimeKind.Local).AddTicks(4205) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 8, 20, 1, 11, 556, DateTimeKind.Local).AddTicks(4270), new DateTime(2024, 10, 1, 20, 1, 11, 556, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 8, 20, 1, 11, 556, DateTimeKind.Local).AddTicks(4276), new DateTime(2024, 10, 1, 20, 1, 11, 556, DateTimeKind.Local).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 8, 20, 1, 11, 556, DateTimeKind.Local).AddTicks(4280), new DateTime(2024, 10, 1, 20, 1, 11, 556, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 8, 20, 1, 11, 556, DateTimeKind.Local).AddTicks(4286), new DateTime(2024, 10, 1, 20, 1, 11, 556, DateTimeKind.Local).AddTicks(4284) });
        }
    }
}
