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
            migrationBuilder.DropColumn(
                name: "FuelConsumption",
                table: "Venichles");

            migrationBuilder.DropColumn(
                name: "ToHundred",
                table: "Venichles");

            migrationBuilder.RenameColumn(
                name: "PictureURLs",
                table: "Venichles",
                newName: "Problems");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Venichles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExteriorPhotosURL",
                table: "Venichles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HaveProblems",
                table: "Venichles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "InteriorPhotosURL",
                table: "Venichles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsModified",
                table: "Venichles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MainPhotoURL",
                table: "Venichles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BodyStyleId", "BrandId", "Description", "ExteriorPhotosURL", "HaveProblems", "InteriorPhotosURL", "IsModified", "MainPhotoURL", "ManufactureDate", "ModelId", "Odometr", "Seats", "VIN" },
                values: new object[] { 2, 3, "Good car", null, false, null, true, "https://www.ixbt.com/news/2023/01/18/chevrolet-corvette-e-ray-stealth.html", 2007, 18, 100000, 2, "1G1YY26U575100001" });

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "Description", "ExteriorPhotosURL", "HaveProblems", "InteriorPhotosURL", "IsModified", "MainPhotoURL", "ModelId", "Odometr", "VIN" },
                values: new object[] { 1, "Audi A3 in excellent condition", null, false, null, false, "https://uk.m.wikipedia.org/wiki/%D0%A4%D0%B0%D0%B9%D0%BB:2020_Audi_A3_S_Line_Edition_1_35_TD_2.0.jpg", 1, 20000, "WAUZZZ8V7KA123456" });

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BodyStyleId", "BrandId", "Description", "ExteriorColor", "ExteriorPhotosURL", "HaveProblems", "InteriorPhotosURL", "IsModified", "MainPhotoURL", "ManufactureDate", "ModelId", "Odometr", "Seats", "TransmissionId", "VIN" },
                values: new object[] { 1, 2, "BMW 3 Series, well maintained", "Blue", null, false, null, false, "https://www.topgear.com/car-reviews/bmw/3-series", 2013, 11, 60000, 5, 2, "WBA3A5C50DF123456" });

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BodyStyleId", "Description", "ExteriorColor", "ExteriorPhotosURL", "FuelTypeId", "HaveProblems", "InteriorPhotosURL", "IsModified", "MainPhotoURL", "ManufactureDate", "Odometr", "Seats", "TransmissionId", "VIN" },
                values: new object[] { 11, "Ford F-150, great for off-road", "Silver", null, 2, false, null, true, "https://focus.ua/auto/592146-prezentovan-novyy-ford-f-150-2024-kak-izmenilsya-samyy-populyarnyy-v-mire-pikap-video", 2014, 70000, 5, 2, "1FTFW1EF1EK123456" });

            migrationBuilder.InsertData(
                table: "Venichles",
                columns: new[] { "Id", "AuctionId", "BodyStyleId", "BrandId", "Description", "ExteriorColor", "ExteriorPhotosURL", "FuelTypeId", "HaveProblems", "InteriorPhotosURL", "IsModified", "MainPhotoURL", "ManufactureDate", "ModelId", "Odometr", "OwnerId", "Problems", "Seats", "TransmissionId", "VIN" },
                values: new object[] { 5, null, 1, 10, "Tesla Model 3, electric car", "Black", null, 3, false, null, false, "https://tesla-model-3.infocar.ua/", 2019, 24, 20000, 1, null, 5, 2, "5YJ3E1EA7KF123456" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Venichles");

            migrationBuilder.DropColumn(
                name: "ExteriorPhotosURL",
                table: "Venichles");

            migrationBuilder.DropColumn(
                name: "HaveProblems",
                table: "Venichles");

            migrationBuilder.DropColumn(
                name: "InteriorPhotosURL",
                table: "Venichles");

            migrationBuilder.DropColumn(
                name: "IsModified",
                table: "Venichles");

            migrationBuilder.DropColumn(
                name: "MainPhotoURL",
                table: "Venichles");

            migrationBuilder.RenameColumn(
                name: "Problems",
                table: "Venichles",
                newName: "PictureURLs");

            migrationBuilder.AddColumn<double>(
                name: "FuelConsumption",
                table: "Venichles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ToHundred",
                table: "Venichles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BodyStyleId", "BrandId", "FuelConsumption", "ManufactureDate", "ModelId", "Odometr", "Seats", "ToHundred", "VIN" },
                values: new object[] { 1, 1, 6.5, 2020, 1, 0, 5, 8.4000000000000004, "1" });

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "FuelConsumption", "ModelId", "Odometr", "ToHundred", "VIN" },
                values: new object[] { 2, 7.5, 11, 0, 7.4000000000000004, "2" });

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BodyStyleId", "BrandId", "ExteriorColor", "FuelConsumption", "ManufactureDate", "ModelId", "Odometr", "Seats", "ToHundred", "TransmissionId", "VIN" },
                values: new object[] { 2, 3, "Red", 9.5, 2018, 18, 0, 2, 4.4000000000000004, 1, "3" });

            migrationBuilder.UpdateData(
                table: "Venichles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BodyStyleId", "ExteriorColor", "FuelConsumption", "FuelTypeId", "ManufactureDate", "Odometr", "Seats", "ToHundred", "TransmissionId", "VIN" },
                values: new object[] { 2, "Blue", 10.5, 1, 2017, 0, 2, 5.4000000000000004, 1, "4" });
        }
    }
}
