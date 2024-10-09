using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BodyStyles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BodyStyles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuelTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transmissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Balance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Venichles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManufactureDate = table.Column<int>(type: "int", nullable: false),
                    Odometr = table.Column<int>(type: "int", nullable: false),
                    ExteriorColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsModified = table.Column<bool>(type: "bit", nullable: false),
                    HaveProblems = table.Column<bool>(type: "bit", nullable: false),
                    Problems = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsHTMLProblemList = table.Column<bool>(type: "bit", nullable: false),
                    IsHTMLDescription = table.Column<bool>(type: "bit", nullable: false),
                    MainPhotoURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExteriorPhotosURLId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InteriorPhotosURLId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    AuctionId = table.Column<int>(type: "int", nullable: true),
                    BodyStyleId = table.Column<int>(type: "int", nullable: false),
                    FuelTypeId = table.Column<int>(type: "int", nullable: false),
                    TransmissionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venichles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Venichles_BodyStyles_BodyStyleId",
                        column: x => x.BodyStyleId,
                        principalTable: "BodyStyles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Venichles_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Venichles_FuelTypes_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "FuelTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Venichles_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Venichles_Transmissions_TransmissionId",
                        column: x => x.TransmissionId,
                        principalTable: "Transmissions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Venichles_Users_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Auctions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VenichleId = table.Column<int>(type: "int", nullable: false),
                    SellerId = table.Column<int>(type: "int", nullable: false),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartPrice = table.Column<int>(type: "int", nullable: false),
                    CurrentPrice = table.Column<int>(type: "int", nullable: false),
                    IsSold = table.Column<bool>(type: "bit", nullable: false),
                    CityNow = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auctions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Auctions_Users_SellerId",
                        column: x => x.SellerId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Auctions_Venichles_VenichleId",
                        column: x => x.VenichleId,
                        principalTable: "Venichles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AuctionUser",
                columns: table => new
                {
                    ViewersId = table.Column<int>(type: "int", nullable: false),
                    WatchListId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuctionUser", x => new { x.ViewersId, x.WatchListId });
                    table.ForeignKey(
                        name: "FK_AuctionUser_Auctions_WatchListId",
                        column: x => x.WatchListId,
                        principalTable: "Auctions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuctionUser_Users_ViewersId",
                        column: x => x.ViewersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bid",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AuctionId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    BidTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bid_Auctions_AuctionId",
                        column: x => x.AuctionId,
                        principalTable: "Auctions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bid_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuctionId = table.Column<int>(type: "int", nullable: false),
                    ReplyCommentId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsReply = table.Column<bool>(type: "bit", nullable: false),
                    IsSeller = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Auctions_AuctionId",
                        column: x => x.AuctionId,
                        principalTable: "Auctions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "BodyStyles",
                columns: new[] { "Id", "Style" },
                values: new object[,]
                {
                    { 1, "Sedan" },
                    { 2, "Coupe" },
                    { 3, "Hatchback" },
                    { 4, "SUV" },
                    { 5, "Crossover" },
                    { 6, "Convertible" },
                    { 7, "Wagon" },
                    { 8, "Van" },
                    { 9, "Truck" },
                    { 10, "Minivan" },
                    { 11, "Pickup" },
                    { 12, "Bus" },
                    { 13, "Limousine" },
                    { 14, "Cabriolet" },
                    { 15, "Roadster" }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Audi" },
                    { 2, "BMW" },
                    { 3, "Chevrolet" },
                    { 4, "Ford" },
                    { 5, "Honda" },
                    { 6, "Hyundai" },
                    { 7, "Kia" },
                    { 8, "Mazda" },
                    { 9, "Mercedes-Benz" },
                    { 10, "Nissan" },
                    { 11, "Toyota" },
                    { 12, "Volkswagen" }
                });

            migrationBuilder.InsertData(
                table: "FuelTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Gasoline" },
                    { 2, "Diesel" },
                    { 3, "Electric" },
                    { 4, "Hybrid" },
                    { 5, "LPG" },
                    { 6, "CNG" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Manual" },
                    { 2, "Automatic" },
                    { 3, "CVT" },
                    { 4, "DCT" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Balance", "Email", "Password", "PhoneNumber", "Username" },
                values: new object[] { 1, 1000000, "admin@gmail.com", "1", 1954161, "admin" });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "BrandId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "A3" },
                    { 2, 1, "A4" },
                    { 3, 1, "A5" },
                    { 4, 1, "A6" },
                    { 5, 1, "A7" },
                    { 6, 1, "A8" },
                    { 7, 1, "Q3" },
                    { 8, 1, "Q5" },
                    { 9, 1, "Q7" },
                    { 10, 1, "Q8" },
                    { 11, 2, "X1" },
                    { 12, 2, "X2" },
                    { 13, 2, "X3" },
                    { 14, 2, "X4" },
                    { 15, 2, "X5" },
                    { 16, 2, "X6" },
                    { 17, 2, "X7" },
                    { 18, 3, "Corvette" },
                    { 19, 3, "Camaro" },
                    { 20, 3, "Malibu" },
                    { 21, 3, "Impala" },
                    { 22, 4, "Mustang" },
                    { 23, 4, "Fiesta" },
                    { 24, 4, "Focus" }
                });

            migrationBuilder.InsertData(
                table: "Venichles",
                columns: new[] { "Id", "AuctionId", "BodyStyleId", "BrandId", "Description", "ExteriorColor", "ExteriorPhotosURLId", "FuelTypeId", "HaveProblems", "InteriorPhotosURLId", "IsHTMLDescription", "IsHTMLProblemList", "IsModified", "MainPhotoURL", "ManufactureDate", "ModelId", "Odometr", "OwnerId", "Problems", "TransmissionId", "VIN" },
                values: new object[,]
                {
                    { 1, null, 2, 3, "Good car", "Black", null, 1, false, null, false, false, true, "https://images.unsplash.com/photo-1672151574300-b32db79a42db?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", 2007, 18, 100000, 1, null, 2, "1G1YY26U575100001" },
                    { 2, null, 1, 1, "Audi A3 in excellent condition", "White", null, 1, false, null, false, false, false, "https://images.unsplash.com/photo-1717711081688-985a7a3e6a9f?q=80&w=1932&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", 2019, 1, 20000, 1, null, 2, "WAUZZZ8V7KA123456" },
                    { 3, null, 1, 2, "BMW 3 Series, well maintained", "Blue", null, 1, false, null, false, false, false, "https://www.topgear.com/sites/default/files/2022/11/P90485000_highRes_bmw-330e-xdrive-tour.jpg", 2013, 11, 60000, 1, null, 2, "WBA3A5C50DF123456" },
                    { 4, null, 11, 4, "Ford F-150, great for off-road", "Silver", null, 2, false, null, false, false, true, "https://i.infocar.ua/i/12/6467/1400x936.jpg", 2014, 22, 70000, 1, null, 2, "1FTFW1EF1EK123456" },
                    { 5, null, 1, 10, "Tesla Model 3, electric car", "Black", null, 3, false, null, false, false, false, "https://tsk.ua/datacache/f/8/f/9/4/f8f948db809a2713f2790bb16426a365a26df356.jpeg", 2019, 24, 20000, 1, null, 2, "5YJ3E1EA7KF123456" }
                });

            migrationBuilder.InsertData(
                table: "Auctions",
                columns: new[] { "Id", "CityNow", "CurrentPrice", "IsSold", "MinDescription", "Name", "SellerId", "StartPrice", "TimeEnd", "TimeStart", "VenichleId" },
                values: new object[,]
                {
                    { 1, "Kyiv", 20000, false, "500-hp V8, Rare DTM-Inspired CLK, Mostly Unmodified", "Chevrolet Corvette 2007", 1, 20000, new DateTime(2024, 10, 7, 20, 40, 26, 149, DateTimeKind.Local).AddTicks(1429), new DateTime(2024, 9, 30, 20, 40, 26, 149, DateTimeKind.Local).AddTicks(1377), 1 },
                    { 2, "Kyiv", 30000, false, "~18,000 Miles, 2 Owners, Supercharged AMG V6, Unmodified", "Audi A3 2019", 1, 30000, new DateTime(2024, 10, 7, 20, 40, 26, 149, DateTimeKind.Local).AddTicks(1437), new DateTime(2024, 9, 30, 20, 40, 26, 149, DateTimeKind.Local).AddTicks(1435), 2 },
                    { 3, "Kyiv", 25000, false, "Twin-Turbo V8, Sport Package, Some Modifications", "BMW 3 Series 2013", 1, 25000, new DateTime(2024, 10, 7, 20, 40, 26, 149, DateTimeKind.Local).AddTicks(1442), new DateTime(2024, 9, 30, 20, 40, 26, 149, DateTimeKind.Local).AddTicks(1440), 3 },
                    { 4, "Kyiv", 35000, false, "V10 Power, Rod Bearings Replaced, Mostly Unmodified", "Ford F-150 2014", 1, 35000, new DateTime(2024, 10, 7, 20, 40, 26, 149, DateTimeKind.Local).AddTicks(1448), new DateTime(2024, 9, 30, 20, 40, 26, 149, DateTimeKind.Local).AddTicks(1447), 4 },
                    { 5, "Kyiv", 40000, false, "~37,000 Miles, Rare Coupe Model, 5-Speed Manual, Extensively Modified", "Tesla Model 3 2019", 1, 40000, new DateTime(2024, 10, 7, 20, 40, 26, 149, DateTimeKind.Local).AddTicks(1454), new DateTime(2024, 9, 30, 20, 40, 26, 149, DateTimeKind.Local).AddTicks(1452), 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_SellerId",
                table: "Auctions",
                column: "SellerId");

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_VenichleId",
                table: "Auctions",
                column: "VenichleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuctionUser_WatchListId",
                table: "AuctionUser",
                column: "WatchListId");

            migrationBuilder.CreateIndex(
                name: "IX_Bid_AuctionId",
                table: "Bid",
                column: "AuctionId");

            migrationBuilder.CreateIndex(
                name: "IX_Bid_UserId",
                table: "Bid",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuctionId",
                table: "Comments",
                column: "AuctionId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandId",
                table: "Models",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Venichles_BodyStyleId",
                table: "Venichles",
                column: "BodyStyleId");

            migrationBuilder.CreateIndex(
                name: "IX_Venichles_BrandId",
                table: "Venichles",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Venichles_FuelTypeId",
                table: "Venichles",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Venichles_ModelId",
                table: "Venichles",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Venichles_OwnerId",
                table: "Venichles",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Venichles_TransmissionId",
                table: "Venichles",
                column: "TransmissionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuctionUser");

            migrationBuilder.DropTable(
                name: "Bid");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Auctions");

            migrationBuilder.DropTable(
                name: "Venichles");

            migrationBuilder.DropTable(
                name: "BodyStyles");

            migrationBuilder.DropTable(
                name: "FuelTypes");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Transmissions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
