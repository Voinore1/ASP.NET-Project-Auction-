using Data.Entities.VenichleInfo;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Data
{
    public class AuctionDBContext : DbContext
    {
        public AuctionDBContext(DbContextOptions options) : base() {}
        public AuctionDBContext() {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.NavigationBaseIncludeIgnored));


            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AuctionDB;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Seed();

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        public DbSet<BodyStyle> BodyStyles { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Entities.VenichleInfo.Model> Models { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Venichle> Venichles { get; set; }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
