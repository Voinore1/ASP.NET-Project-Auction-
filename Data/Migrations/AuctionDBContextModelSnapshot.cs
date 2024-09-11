﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AuctionDBContext))]
    partial class AuctionDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AuctionUser", b =>
                {
                    b.Property<int>("WatchListId")
                        .HasColumnType("int");

                    b.Property<int>("WatchersId")
                        .HasColumnType("int");

                    b.HasKey("WatchListId", "WatchersId");

                    b.HasIndex("WatchersId");

                    b.ToTable("AuctionUser");
                });

            modelBuilder.Entity("Data.Entities.Auction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityNow")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CurrentPrice")
                        .HasColumnType("int");

                    b.Property<bool>("IsSold")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SellerId")
                        .HasColumnType("int");

                    b.Property<int>("StartPrice")
                        .HasColumnType("int");

                    b.Property<int>("Step")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.Property<int>("VenichleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.HasIndex("VenichleId")
                        .IsUnique();

                    b.ToTable("Auctions");
                });

            modelBuilder.Entity("Data.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuctionId")
                        .HasColumnType("int");

                    b.Property<bool>("IsReply")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSeller")
                        .HasColumnType("bit");

                    b.Property<int?>("ReplyCommentId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuctionId");

                    b.HasIndex("ReplyCommentId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Balance")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Balance = 1000000,
                            Email = "admin@gmail.com",
                            Password = "1",
                            PhoneNumber = 1954161,
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.BodyStyle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Style")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BodyStyles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Style = "Sedan"
                        },
                        new
                        {
                            Id = 2,
                            Style = "Coupe"
                        },
                        new
                        {
                            Id = 3,
                            Style = "Hatchback"
                        },
                        new
                        {
                            Id = 4,
                            Style = "SUV"
                        },
                        new
                        {
                            Id = 5,
                            Style = "Crossover"
                        },
                        new
                        {
                            Id = 6,
                            Style = "Convertible"
                        },
                        new
                        {
                            Id = 7,
                            Style = "Wagon"
                        },
                        new
                        {
                            Id = 8,
                            Style = "Van"
                        },
                        new
                        {
                            Id = 9,
                            Style = "Truck"
                        },
                        new
                        {
                            Id = 10,
                            Style = "Minivan"
                        },
                        new
                        {
                            Id = 11,
                            Style = "Pickup"
                        },
                        new
                        {
                            Id = 12,
                            Style = "Bus"
                        },
                        new
                        {
                            Id = 13,
                            Style = "Limousine"
                        },
                        new
                        {
                            Id = 14,
                            Style = "Cabriolet"
                        },
                        new
                        {
                            Id = 15,
                            Style = "Roadster"
                        });
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Audi"
                        },
                        new
                        {
                            Id = 2,
                            Name = "BMW"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Chevrolet"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ford"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Honda"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Hyundai"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Kia"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Mazda"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Mercedes-Benz"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Nissan"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Toyota"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Volkswagen"
                        });
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.FuelType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FuelTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Gasoline"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Diesel"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Electric"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Hybrid"
                        },
                        new
                        {
                            Id = 5,
                            Name = "LPG"
                        },
                        new
                        {
                            Id = 6,
                            Name = "CNG"
                        });
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Models");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandId = 1,
                            Name = "A3"
                        },
                        new
                        {
                            Id = 2,
                            BrandId = 1,
                            Name = "A4"
                        },
                        new
                        {
                            Id = 3,
                            BrandId = 1,
                            Name = "A5"
                        },
                        new
                        {
                            Id = 4,
                            BrandId = 1,
                            Name = "A6"
                        },
                        new
                        {
                            Id = 5,
                            BrandId = 1,
                            Name = "A7"
                        },
                        new
                        {
                            Id = 6,
                            BrandId = 1,
                            Name = "A8"
                        },
                        new
                        {
                            Id = 7,
                            BrandId = 1,
                            Name = "Q3"
                        },
                        new
                        {
                            Id = 8,
                            BrandId = 1,
                            Name = "Q5"
                        },
                        new
                        {
                            Id = 9,
                            BrandId = 1,
                            Name = "Q7"
                        },
                        new
                        {
                            Id = 10,
                            BrandId = 1,
                            Name = "Q8"
                        },
                        new
                        {
                            Id = 11,
                            BrandId = 2,
                            Name = "X1"
                        },
                        new
                        {
                            Id = 12,
                            BrandId = 2,
                            Name = "X2"
                        },
                        new
                        {
                            Id = 13,
                            BrandId = 2,
                            Name = "X3"
                        },
                        new
                        {
                            Id = 14,
                            BrandId = 2,
                            Name = "X4"
                        },
                        new
                        {
                            Id = 15,
                            BrandId = 2,
                            Name = "X5"
                        },
                        new
                        {
                            Id = 16,
                            BrandId = 2,
                            Name = "X6"
                        },
                        new
                        {
                            Id = 17,
                            BrandId = 2,
                            Name = "X7"
                        },
                        new
                        {
                            Id = 18,
                            BrandId = 3,
                            Name = "Corvette"
                        },
                        new
                        {
                            Id = 19,
                            BrandId = 3,
                            Name = "Camaro"
                        },
                        new
                        {
                            Id = 20,
                            BrandId = 3,
                            Name = "Malibu"
                        },
                        new
                        {
                            Id = 21,
                            BrandId = 3,
                            Name = "Impala"
                        },
                        new
                        {
                            Id = 22,
                            BrandId = 4,
                            Name = "Mustang"
                        },
                        new
                        {
                            Id = 23,
                            BrandId = 4,
                            Name = "Fiesta"
                        },
                        new
                        {
                            Id = 24,
                            BrandId = 4,
                            Name = "Focus"
                        });
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.Transmission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Transmissions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Manual"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Automatic"
                        },
                        new
                        {
                            Id = 3,
                            Name = "CVT"
                        },
                        new
                        {
                            Id = 4,
                            Name = "DCT"
                        });
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.Venichle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AuctionId")
                        .HasColumnType("int");

                    b.Property<int>("BodyStyleId")
                        .HasColumnType("int");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("ExteriorColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FuelConsumption")
                        .HasColumnType("float");

                    b.Property<int>("FuelTypeId")
                        .HasColumnType("int");

                    b.Property<int>("ManufactureDate")
                        .HasColumnType("int");

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<int>("Odometr")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<string>("PictureURLs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Seats")
                        .HasColumnType("int");

                    b.Property<double>("ToHundred")
                        .HasColumnType("float");

                    b.Property<int>("TransmissionId")
                        .HasColumnType("int");

                    b.Property<string>("VIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BodyStyleId");

                    b.HasIndex("BrandId");

                    b.HasIndex("FuelTypeId");

                    b.HasIndex("ModelId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("TransmissionId");

                    b.ToTable("Venichles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BodyStyleId = 1,
                            BrandId = 1,
                            ExteriorColor = "Black",
                            FuelConsumption = 6.5,
                            FuelTypeId = 1,
                            ManufactureDate = 2020,
                            ModelId = 1,
                            Odometr = 0,
                            OwnerId = 1,
                            Seats = 5,
                            ToHundred = 8.4000000000000004,
                            TransmissionId = 2,
                            VIN = "1"
                        },
                        new
                        {
                            Id = 2,
                            BodyStyleId = 1,
                            BrandId = 2,
                            ExteriorColor = "White",
                            FuelConsumption = 7.5,
                            FuelTypeId = 1,
                            ManufactureDate = 2019,
                            ModelId = 11,
                            Odometr = 0,
                            OwnerId = 1,
                            Seats = 5,
                            ToHundred = 7.4000000000000004,
                            TransmissionId = 2,
                            VIN = "2"
                        },
                        new
                        {
                            Id = 3,
                            BodyStyleId = 2,
                            BrandId = 3,
                            ExteriorColor = "Red",
                            FuelConsumption = 9.5,
                            FuelTypeId = 1,
                            ManufactureDate = 2018,
                            ModelId = 18,
                            Odometr = 0,
                            OwnerId = 1,
                            Seats = 2,
                            ToHundred = 4.4000000000000004,
                            TransmissionId = 1,
                            VIN = "3"
                        },
                        new
                        {
                            Id = 4,
                            BodyStyleId = 2,
                            BrandId = 4,
                            ExteriorColor = "Blue",
                            FuelConsumption = 10.5,
                            FuelTypeId = 1,
                            ManufactureDate = 2017,
                            ModelId = 22,
                            Odometr = 0,
                            OwnerId = 1,
                            Seats = 2,
                            ToHundred = 5.4000000000000004,
                            TransmissionId = 1,
                            VIN = "4"
                        });
                });

            modelBuilder.Entity("AuctionUser", b =>
                {
                    b.HasOne("Data.Entities.Auction", null)
                        .WithMany()
                        .HasForeignKey("WatchListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("WatchersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.Auction", b =>
                {
                    b.HasOne("Data.Entities.User", "Seller")
                        .WithMany("Auctions")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.VenichleInfo.Venichle", "Venichle")
                        .WithOne("Auction")
                        .HasForeignKey("Data.Entities.Auction", "VenichleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Seller");

                    b.Navigation("Venichle");
                });

            modelBuilder.Entity("Data.Entities.Comment", b =>
                {
                    b.HasOne("Data.Entities.Auction", "Auction")
                        .WithMany("Comments")
                        .HasForeignKey("AuctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Comment", "ReplyComment")
                        .WithMany("AddresedComments")
                        .HasForeignKey("ReplyCommentId");

                    b.HasOne("Data.Entities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auction");

                    b.Navigation("ReplyComment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.Model", b =>
                {
                    b.HasOne("Data.Entities.VenichleInfo.Brand", "Brand")
                        .WithMany("Model")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.Venichle", b =>
                {
                    b.HasOne("Data.Entities.VenichleInfo.BodyStyle", "BodyStyle")
                        .WithMany("Venichles")
                        .HasForeignKey("BodyStyleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.VenichleInfo.Brand", "Brand")
                        .WithMany("Venichles")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.VenichleInfo.FuelType", "FuelType")
                        .WithMany("Venichles")
                        .HasForeignKey("FuelTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.VenichleInfo.Model", "Model")
                        .WithMany("Venichles")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.User", "Owner")
                        .WithMany("Venichles")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.VenichleInfo.Transmission", "Transmission")
                        .WithMany("Venichles")
                        .HasForeignKey("TransmissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BodyStyle");

                    b.Navigation("Brand");

                    b.Navigation("FuelType");

                    b.Navigation("Model");

                    b.Navigation("Owner");

                    b.Navigation("Transmission");
                });

            modelBuilder.Entity("Data.Entities.Auction", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Data.Entities.Comment", b =>
                {
                    b.Navigation("AddresedComments");
                });

            modelBuilder.Entity("Data.Entities.User", b =>
                {
                    b.Navigation("Auctions");

                    b.Navigation("Comments");

                    b.Navigation("Venichles");
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.BodyStyle", b =>
                {
                    b.Navigation("Venichles");
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.Brand", b =>
                {
                    b.Navigation("Model");

                    b.Navigation("Venichles");
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.FuelType", b =>
                {
                    b.Navigation("Venichles");
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.Model", b =>
                {
                    b.Navigation("Venichles");
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.Transmission", b =>
                {
                    b.Navigation("Venichles");
                });

            modelBuilder.Entity("Data.Entities.VenichleInfo.Venichle", b =>
                {
                    b.Navigation("Auction");
                });
#pragma warning restore 612, 618
        }
    }
}