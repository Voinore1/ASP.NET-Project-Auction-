using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Auctions",
                columns: new[] { "Id", "CityNow", "CurrentPrice", "IsSold", "Name", "SellerId", "StartPrice", "Step", "TimeEnd", "TimeStart", "VenichleId" },
                values: new object[,]
                {
                    { 1, "Kyiv", 20000, false, "Chevrolet Corvette 2007", 1, 20000, 500, new DateTime(2024, 9, 22, 16, 12, 15, 414, DateTimeKind.Local).AddTicks(707), new DateTime(2024, 9, 15, 16, 12, 15, 414, DateTimeKind.Local).AddTicks(659), 1 },
                    { 2, "Kyiv", 30000, false, "Audi A3 2019", 1, 30000, 500, new DateTime(2024, 9, 22, 16, 12, 15, 414, DateTimeKind.Local).AddTicks(714), new DateTime(2024, 9, 15, 16, 12, 15, 414, DateTimeKind.Local).AddTicks(713), 2 },
                    { 3, "Kyiv", 25000, false, "BMW 3 Series 2013", 1, 25000, 500, new DateTime(2024, 9, 22, 16, 12, 15, 414, DateTimeKind.Local).AddTicks(719), new DateTime(2024, 9, 15, 16, 12, 15, 414, DateTimeKind.Local).AddTicks(717), 3 },
                    { 4, "Kyiv", 35000, false, "Ford F-150 2014", 1, 35000, 500, new DateTime(2024, 9, 22, 16, 12, 15, 414, DateTimeKind.Local).AddTicks(723), new DateTime(2024, 9, 15, 16, 12, 15, 414, DateTimeKind.Local).AddTicks(722), 4 },
                    { 5, "Kyiv", 40000, false, "Tesla Model 3 2019", 1, 40000, 500, new DateTime(2024, 9, 22, 16, 12, 15, 414, DateTimeKind.Local).AddTicks(727), new DateTime(2024, 9, 15, 16, 12, 15, 414, DateTimeKind.Local).AddTicks(726), 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
