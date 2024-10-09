using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExteriorPhotosURLId", "InteriorPhotosURLId" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1608412217976-cdbed1034b41?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\",\"https://images.unsplash.com/photo-1608412218116-dbec61977136?w=500\\u0026auto=format\\u0026fit=crop\\u0026q=60\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1yZWxhdGVkfDF8fHxlbnwwfHx8fHw%3D\",\"https://images.unsplash.com/photo-1608412977534-c235d8c31b14?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\",\"https://images.unsplash.com/photo-1608412217889-1ec8ac1d5878?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\"]", "[\"https://images.unsplash.com/photo-1608412217976-cdbed1034b41?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\",\"https://images.unsplash.com/photo-1608412218116-dbec61977136?w=500\\u0026auto=format\\u0026fit=crop\\u0026q=60\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1yZWxhdGVkfDF8fHxlbnwwfHx8fHw%3D\",\"https://images.unsplash.com/photo-1608412977534-c235d8c31b14?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\",\"https://images.unsplash.com/photo-1608412217889-1ec8ac1d5878?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\"]" });

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExteriorPhotosURLId", "InteriorPhotosURLId" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1608412217976-cdbed1034b41?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\",\"https://images.unsplash.com/photo-1608412218116-dbec61977136?w=500\\u0026auto=format\\u0026fit=crop\\u0026q=60\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1yZWxhdGVkfDF8fHxlbnwwfHx8fHw%3D\",\"https://images.unsplash.com/photo-1608412977534-c235d8c31b14?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\",\"https://images.unsplash.com/photo-1608412217889-1ec8ac1d5878?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\"]", "[\"https://images.unsplash.com/photo-1608412217976-cdbed1034b41?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\",\"https://images.unsplash.com/photo-1608412218116-dbec61977136?w=500\\u0026auto=format\\u0026fit=crop\\u0026q=60\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1yZWxhdGVkfDF8fHxlbnwwfHx8fHw%3D\",\"https://images.unsplash.com/photo-1608412977534-c235d8c31b14?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\",\"https://images.unsplash.com/photo-1608412217889-1ec8ac1d5878?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\"]" });

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExteriorPhotosURLId", "InteriorPhotosURLId" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1608412217976-cdbed1034b41?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\",\"https://images.unsplash.com/photo-1608412218116-dbec61977136?w=500\\u0026auto=format\\u0026fit=crop\\u0026q=60\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1yZWxhdGVkfDF8fHxlbnwwfHx8fHw%3D\",\"https://images.unsplash.com/photo-1608412977534-c235d8c31b14?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\",\"https://images.unsplash.com/photo-1608412217889-1ec8ac1d5878?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\"]", "[\"https://images.unsplash.com/photo-1608412217976-cdbed1034b41?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\",\"https://images.unsplash.com/photo-1608412218116-dbec61977136?w=500\\u0026auto=format\\u0026fit=crop\\u0026q=60\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1yZWxhdGVkfDF8fHxlbnwwfHx8fHw%3D\",\"https://images.unsplash.com/photo-1608412977534-c235d8c31b14?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\",\"https://images.unsplash.com/photo-1608412217889-1ec8ac1d5878?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\"]" });

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExteriorPhotosURLId", "InteriorPhotosURLId" },
                values: new object[] { "[\"https://images.unsplash.com/photo-1608412217976-cdbed1034b41?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\",\"https://images.unsplash.com/photo-1608412218116-dbec61977136?w=500\\u0026auto=format\\u0026fit=crop\\u0026q=60\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1yZWxhdGVkfDF8fHxlbnwwfHx8fHw%3D\",\"https://images.unsplash.com/photo-1608412977534-c235d8c31b14?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\",\"https://images.unsplash.com/photo-1608412217889-1ec8ac1d5878?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\"]", "[\"https://images.unsplash.com/photo-1608412217976-cdbed1034b41?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\",\"https://images.unsplash.com/photo-1608412218116-dbec61977136?w=500\\u0026auto=format\\u0026fit=crop\\u0026q=60\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1yZWxhdGVkfDF8fHxlbnwwfHx8fHw%3D\",\"https://images.unsplash.com/photo-1608412977534-c235d8c31b14?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\",\"https://images.unsplash.com/photo-1608412217889-1ec8ac1d5878?q=80\\u0026w=2070\\u0026auto=format\\u0026fit=crop\\u0026ixlib=rb-4.0.3\\u0026ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D\"]" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 7, 20, 40, 26, 149, DateTimeKind.Local).AddTicks(1429), new DateTime(2024, 9, 30, 20, 40, 26, 149, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 7, 20, 40, 26, 149, DateTimeKind.Local).AddTicks(1437), new DateTime(2024, 9, 30, 20, 40, 26, 149, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 7, 20, 40, 26, 149, DateTimeKind.Local).AddTicks(1442), new DateTime(2024, 9, 30, 20, 40, 26, 149, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 7, 20, 40, 26, 149, DateTimeKind.Local).AddTicks(1448), new DateTime(2024, 9, 30, 20, 40, 26, 149, DateTimeKind.Local).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 7, 20, 40, 26, 149, DateTimeKind.Local).AddTicks(1454), new DateTime(2024, 9, 30, 20, 40, 26, 149, DateTimeKind.Local).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ExteriorPhotosURLId", "InteriorPhotosURLId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ExteriorPhotosURLId", "InteriorPhotosURLId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ExteriorPhotosURLId", "InteriorPhotosURLId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ExteriorPhotosURLId", "InteriorPhotosURLId" },
                values: new object[] { null, null });
        }
    }
}
