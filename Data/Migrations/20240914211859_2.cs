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
            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 1,
                column: "MainPhotoURL",
                value: "https://images.unsplash.com/photo-1672151574300-b32db79a42db?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D");

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 2,
                column: "MainPhotoURL",
                value: "https://images.unsplash.com/photo-1717711081688-985a7a3e6a9f?q=80&w=1932&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D");

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 3,
                column: "MainPhotoURL",
                value: "https://www.topgear.com/sites/default/files/2022/11/P90485000_highRes_bmw-330e-xdrive-tour.jpg");

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 4,
                column: "MainPhotoURL",
                value: "https://i.infocar.ua/i/12/6467/1400x936.jpg");

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 5,
                column: "MainPhotoURL",
                value: "https://tsk.ua/datacache/f/8/f/9/4/f8f948db809a2713f2790bb16426a365a26df356.jpeg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 1,
                column: "MainPhotoURL",
                value: "https://www.ixbt.com/news/2023/01/18/chevrolet-corvette-e-ray-stealth.html");

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 2,
                column: "MainPhotoURL",
                value: "https://uk.m.wikipedia.org/wiki/%D0%A4%D0%B0%D0%B9%D0%BB:2020_Audi_A3_S_Line_Edition_1_35_TD_2.0.jpg");

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 3,
                column: "MainPhotoURL",
                value: "https://www.topgear.com/car-reviews/bmw/3-series");

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 4,
                column: "MainPhotoURL",
                value: "https://focus.ua/auto/592146-prezentovan-novyy-ford-f-150-2024-kak-izmenilsya-samyy-populyarnyy-v-mire-pikap-video");

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 5,
                column: "MainPhotoURL",
                value: "https://tesla-model-3.infocar.ua/");
        }
    }
}
