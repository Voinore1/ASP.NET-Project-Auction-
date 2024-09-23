using Data.Entities.VenichleInfo;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class DBSeedExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new[]
            {
               new User { Id = 1, Username = "admin", Email = "admin@gmail.com", Password = "1", PhoneNumber = 1954161, Balance = 1_000_000 }
            });

            modelBuilder.Entity<BodyStyle>().HasData(new[]
            {
                new BodyStyle { Id = 1, Style = "Sedan" },
                new BodyStyle { Id = 2, Style = "Coupe" },
                new BodyStyle { Id = 3, Style = "Hatchback" },
                new BodyStyle { Id = 4, Style = "SUV" },
                new BodyStyle { Id = 5, Style = "Crossover" },
                new BodyStyle { Id = 6, Style = "Convertible" },
                new BodyStyle { Id = 7, Style = "Wagon" },
                new BodyStyle { Id = 8, Style = "Van" },
                new BodyStyle { Id = 9, Style = "Truck" },
                new BodyStyle { Id = 10, Style = "Minivan" },
                new BodyStyle { Id = 11, Style = "Pickup" },
                new BodyStyle { Id = 12, Style = "Bus" },
                new BodyStyle { Id = 13, Style = "Limousine" },
                new BodyStyle { Id = 14, Style = "Cabriolet" },
                new BodyStyle { Id = 15, Style = "Roadster" }
            });

            modelBuilder.Entity<Brand>().HasData(new[]
            {
                new Brand { Id = 1, Name = "Audi" },
                new Brand { Id = 2, Name = "BMW" },
                new Brand { Id = 3, Name = "Chevrolet" },
                new Brand { Id = 4, Name = "Ford" },
                new Brand { Id = 5, Name = "Honda" },
                new Brand { Id = 6, Name = "Hyundai" },
                new Brand { Id = 7, Name = "Kia" },
                new Brand { Id = 8, Name = "Mazda" },
                new Brand { Id = 9, Name = "Mercedes-Benz" },
                new Brand { Id = 10, Name = "Nissan" },
                new Brand { Id = 11, Name = "Toyota" },
                new Brand { Id = 12, Name = "Volkswagen" }
            });

            modelBuilder.Entity<FuelType>().HasData(new[]
            {
                new FuelType { Id = 1, Name = "Gasoline" },
                new FuelType { Id = 2, Name = "Diesel" },
                new FuelType { Id = 3, Name = "Electric" },
                new FuelType { Id = 4, Name = "Hybrid" },
                new FuelType { Id = 5, Name = "LPG" },
                new FuelType { Id = 6, Name = "CNG" }
            });

            modelBuilder.Entity<Transmission>().HasData(new[]
            {
                new Transmission { Id = 1, Name = "Manual" },
                new Transmission { Id = 2, Name = "Automatic" },
                new Transmission { Id = 3, Name = "CVT" },
                new Transmission { Id = 4, Name = "DCT" }
            });

            modelBuilder.Entity<Model>().HasData(new[] {
                new Model { Id = 1, Name = "A3", BrandId = 1 },
                new Model { Id = 2, Name = "A4", BrandId = 1 },
                new Model { Id = 3, Name = "A5", BrandId = 1 },
                new Model { Id = 4, Name = "A6", BrandId = 1 },
                new Model { Id = 5, Name = "A7", BrandId = 1 },
                new Model { Id = 6, Name = "A8", BrandId = 1 },
                new Model { Id = 7, Name = "Q3", BrandId = 1 },
                new Model { Id = 8, Name = "Q5", BrandId = 1 },
                new Model { Id = 9, Name = "Q7", BrandId = 1 },
                new Model { Id = 10, Name = "Q8", BrandId = 1 },
                new Model { Id = 11, Name = "X1", BrandId = 2 },
                new Model { Id = 12, Name = "X2", BrandId = 2 },
                new Model { Id = 13, Name = "X3", BrandId = 2 },
                new Model { Id = 14, Name = "X4", BrandId = 2 },
                new Model { Id = 15, Name = "X5", BrandId = 2 },
                new Model { Id = 16, Name = "X6", BrandId = 2 },
                new Model { Id = 17, Name = "X7", BrandId = 2 },
                new Model { Id = 18, Name = "Corvette", BrandId = 3 },
                new Model { Id = 19, Name = "Camaro", BrandId = 3 },
                new Model { Id = 20, Name = "Malibu", BrandId = 3 },
                new Model { Id = 21, Name = "Impala", BrandId = 3 },
                new Model { Id = 22, Name = "Mustang", BrandId = 4 },
                new Model { Id = 23, Name = "Fiesta", BrandId = 4 },
                new Model { Id = 24, Name = "Focus", BrandId = 4 },
            });

            modelBuilder.Entity<Venichle>().HasData(new[]
            {
                new Venichle
                {
                    Id = 1,
                    VIN = "1G1YY26U575100001",
                    ManufactureDate = 2007,
                    Odometr = 100_000,
                    Seats = 2,
                    ExteriorColor = "Black",
                    IsModified = true,
                    HaveProblems = false,
                    Description = "Good car",
                    MainPhotoURL = "https://images.unsplash.com/photo-1672151574300-b32db79a42db?q=80&w=2070&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    BrandId = 3,
                    ModelId = 18,
                    BodyStyleId = 2,
                    FuelTypeId = 1,
                    TransmissionId = 2,
                    OwnerId = 1
                },
                new Venichle
                {
                    Id = 2,
                    VIN = "WAUZZZ8V7KA123456",
                    ManufactureDate = 2019,
                    Odometr = 20_000,
                    Seats = 5,
                    ExteriorColor = "White",
                    IsModified = false,
                    HaveProblems = false,
                    Description = "Audi A3 in excellent condition",
                    MainPhotoURL = "https://images.unsplash.com/photo-1717711081688-985a7a3e6a9f?q=80&w=1932&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D",
                    BrandId = 1,
                    ModelId = 1,
                    BodyStyleId = 1,
                    FuelTypeId = 1,
                    TransmissionId = 2,
                    OwnerId = 1
                },
                new Venichle
                {
                    Id = 3,
                    VIN = "WBA3A5C50DF123456",
                    ManufactureDate = 2013,
                    Odometr = 60_000,
                    Seats = 5,
                    ExteriorColor = "Blue",
                    IsModified = false,
                    HaveProblems = false,
                    Description = "BMW 3 Series, well maintained",
                    MainPhotoURL = "https://www.topgear.com/sites/default/files/2022/11/P90485000_highRes_bmw-330e-xdrive-tour.jpg",
                    BrandId = 2,
                    ModelId = 11,
                    BodyStyleId = 1,
                    FuelTypeId = 1,
                    TransmissionId = 2,
                    OwnerId = 1
                },
                new Venichle
                {
                    Id = 4,
                    VIN = "1FTFW1EF1EK123456",
                    ManufactureDate = 2014,
                    Odometr = 70_000,
                    Seats = 5,
                    ExteriorColor = "Silver",
                    IsModified = true,
                    HaveProblems = false,
                    Description = "Ford F-150, great for off-road",
                    MainPhotoURL = "https://i.infocar.ua/i/12/6467/1400x936.jpg",
                    BrandId = 4,
                    ModelId = 22,
                    BodyStyleId = 11,
                    FuelTypeId = 2,
                    TransmissionId = 2,
                    OwnerId = 1
                },
                new Venichle
                {
                    Id = 5,
                    VIN = "5YJ3E1EA7KF123456",
                    ManufactureDate = 2019,
                    Odometr = 20_000,
                    Seats = 5,
                    ExteriorColor = "Black",
                    IsModified = false,
                    HaveProblems = false,
                    Description = "Tesla Model 3, electric car",
                    MainPhotoURL = "https://tsk.ua/datacache/f/8/f/9/4/f8f948db809a2713f2790bb16426a365a26df356.jpeg",
                    BrandId = 10,
                    ModelId = 24,
                    BodyStyleId = 1,
                    FuelTypeId = 3,
                    TransmissionId = 2,
                    OwnerId = 1
                }
            });

            modelBuilder.Entity<Auction>().HasData(new[]
            {
                new Auction
                {
                    Id = 1,
                    VenichleId = 1,
                    SellerId = 1,
                    TimeStart = DateTime.Now,
                    TimeEnd = DateTime.Now.AddDays(7),
                    Name = "Chevrolet Corvette 2007",
                    StartPrice = 20_000,
                    CurrentPrice = 20_000,
                    IsSold = false,
                    CityNow = "Kyiv",
                    MinDescription = "500-hp V8, Rare DTM-Inspired CLK, Mostly Unmodified"
                },
                new Auction
                {
                    Id = 2,
                    VenichleId = 2,
                    SellerId = 1,
                    TimeStart = DateTime.Now,
                    TimeEnd = DateTime.Now.AddDays(7),
                    Name = "Audi A3 2019",
                    StartPrice = 30_000,
                    CurrentPrice = 30_000,
                    IsSold = false,
                    CityNow = "Kyiv",
                    MinDescription = "~18,000 Miles, 2 Owners, Supercharged AMG V6, Unmodified"
                },
                new Auction
                {
                    Id = 3,
                    VenichleId = 3,
                    SellerId = 1,
                    TimeStart = DateTime.Now,
                    TimeEnd = DateTime.Now.AddDays(7),
                    Name = "BMW 3 Series 2013",
                    StartPrice = 25_000,
                    CurrentPrice = 25_000,
                    IsSold = false,
                    CityNow = "Kyiv",
                    MinDescription = "Twin-Turbo V8, Sport Package, Some Modifications"
                },
                new Auction
                {
                    Id = 4,
                    VenichleId = 4,
                    SellerId = 1,
                    TimeStart = DateTime.Now,
                    TimeEnd = DateTime.Now.AddDays(7),
                    Name = "Ford F-150 2014",
                    StartPrice = 35_000,
                    CurrentPrice = 35_000,
                    IsSold = false,
                    CityNow = "Kyiv",
                    MinDescription = "V10 Power, Rod Bearings Replaced, Mostly Unmodified"
                },
                new Auction
                {
                    Id = 5,
                    VenichleId = 5,
                    SellerId = 1,
                    TimeStart = DateTime.Now,
                    TimeEnd = DateTime.Now.AddDays(7),
                    Name = "Tesla Model 3 2019",
                    StartPrice = 40_000,
                    CurrentPrice = 40_000,
                    IsSold = false,
                    CityNow = "Kyiv",
                    MinDescription = "~37,000 Miles, Rare Coupe Model, 5-Speed Manual, Extensively Modified"
                }
            });
        }
    }
}
