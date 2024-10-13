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
            migrationBuilder.DropForeignKey(
                name: "FK_Auctions_Venichles_VenichleId",
                table: "Auctions");

            migrationBuilder.DropForeignKey(
                name: "FK_Venichles_Models_ModelId",
                table: "Venichles");

            migrationBuilder.DropIndex(
                name: "IX_Auctions_VenichleId",
                table: "Auctions");

            migrationBuilder.AlterColumn<int>(
                name: "VenichleId",
                table: "Auctions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 18, 17, 2, 44, 328, DateTimeKind.Local).AddTicks(9691), new DateTime(2024, 10, 11, 17, 2, 44, 328, DateTimeKind.Local).AddTicks(9635) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 18, 17, 2, 44, 328, DateTimeKind.Local).AddTicks(9701), new DateTime(2024, 10, 11, 17, 2, 44, 328, DateTimeKind.Local).AddTicks(9699) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 18, 17, 2, 44, 328, DateTimeKind.Local).AddTicks(9706), new DateTime(2024, 10, 11, 17, 2, 44, 328, DateTimeKind.Local).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 18, 17, 2, 44, 328, DateTimeKind.Local).AddTicks(9711), new DateTime(2024, 10, 11, 17, 2, 44, 328, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 18, 17, 2, 44, 328, DateTimeKind.Local).AddTicks(9716), new DateTime(2024, 10, 11, 17, 2, 44, 328, DateTimeKind.Local).AddTicks(9715) });

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_VenichleId",
                table: "Auctions",
                column: "VenichleId",
                unique: true,
                filter: "[VenichleId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Auctions_Venichles_VenichleId",
                table: "Auctions",
                column: "VenichleId",
                principalTable: "Venichles",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Venichles_Models_ModelId",
                table: "Venichles",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auctions_Venichles_VenichleId",
                table: "Auctions");

            migrationBuilder.DropForeignKey(
                name: "FK_Venichles_Models_ModelId",
                table: "Venichles");

            migrationBuilder.DropIndex(
                name: "IX_Auctions_VenichleId",
                table: "Auctions");

            migrationBuilder.AlterColumn<int>(
                name: "VenichleId",
                table: "Auctions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 17, 23, 26, 2, 344, DateTimeKind.Local).AddTicks(3818), new DateTime(2024, 10, 10, 23, 26, 2, 344, DateTimeKind.Local).AddTicks(3763) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 17, 23, 26, 2, 344, DateTimeKind.Local).AddTicks(3827), new DateTime(2024, 10, 10, 23, 26, 2, 344, DateTimeKind.Local).AddTicks(3825) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 17, 23, 26, 2, 344, DateTimeKind.Local).AddTicks(3832), new DateTime(2024, 10, 10, 23, 26, 2, 344, DateTimeKind.Local).AddTicks(3831) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 17, 23, 26, 2, 344, DateTimeKind.Local).AddTicks(3838), new DateTime(2024, 10, 10, 23, 26, 2, 344, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "Auctions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "TimeEnd", "TimeStart" },
                values: new object[] { new DateTime(2024, 10, 17, 23, 26, 2, 344, DateTimeKind.Local).AddTicks(3843), new DateTime(2024, 10, 10, 23, 26, 2, 344, DateTimeKind.Local).AddTicks(3841) });

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_VenichleId",
                table: "Auctions",
                column: "VenichleId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Auctions_Venichles_VenichleId",
                table: "Auctions",
                column: "VenichleId",
                principalTable: "Venichles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Venichles_Models_ModelId",
                table: "Venichles",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
