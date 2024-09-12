using Data.Entities.VenichleInfo;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection;

namespace Data
{
    public class AuctionDBContext : DbContext
    {
        public AuctionDBContext() : base() {}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AuctionDB;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Seed();

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        DbSet<BodyStyle> BodyStyles { get; set; }
        DbSet<Brand> Brands { get; set; }
        DbSet<FuelType> FuelTypes { get; set; }
        DbSet<Entities.VenichleInfo.Model> Models { get; set; }
        DbSet<Transmission> Transmissions { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Venichle> Venichles { get; set; }
        DbSet<Auction> Auctions { get; set; }
        DbSet<Comment> Comments { get; set; }

    }
}
