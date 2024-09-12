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
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    AuctionId = table.Column<int>(type: "int", nullable: true),
                    ManufactureDate = table.Column<int>(type: "int", nullable: false),
                    Odometr = table.Column<int>(type: "int", nullable: false),
                    FuelConsumption = table.Column<double>(type: "float", nullable: false),
                    Seats = table.Column<int>(type: "int", nullable: false),
                    ToHundred = table.Column<double>(type: "float", nullable: false),
                    ExteriorColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BodyStyleId = table.Column<int>(type: "int", nullable: false),
                    FuelTypeId = table.Column<int>(type: "int", nullable: false),
                    TransmissionId = table.Column<int>(type: "int", nullable: false),
                    PictureURLs = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    StartPrice = table.Column<int>(type: "int", nullable: false),
                    CurrentPrice = table.Column<int>(type: "int", nullable: false),
                    Step = table.Column<int>(type: "int", nullable: false),
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
                columns: new[] { "Id", "AuctionId", "BodyStyleId", "BrandId", "ExteriorColor", "FuelConsumption", "FuelTypeId", "ManufactureDate", "ModelId", "Odometr", "OwnerId", "PictureURLs", "Seats", "ToHundred", "TransmissionId", "VIN" },
                values: new object[,]
                {
                    { 1, null, 1, 1, "Black", 6.5, 1, 2020, 1, 0, 1, null, 5, 8.4000000000000004, 2, "1" },
                    { 2, null, 1, 2, "White", 7.5, 1, 2019, 11, 0, 1, null, 5, 7.4000000000000004, 2, "2" },
                    { 3, null, 2, 3, "Red", 9.5, 1, 2018, 18, 0, 1, null, 2, 4.4000000000000004, 1, "3" },
                    { 4, null, 2, 4, "Blue", 10.5, 1, 2017, 22, 0, 1, null, 2, 5.4000000000000004, 1, "4" }
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
