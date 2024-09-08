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
    public class AuctionDBContext : DbContext
    {
        DbSet<BodyStyle> BodyStyles { get; set; }
        DbSet<Brand> Brands { get; set; }
        DbSet<FuelType> FuelTypes { get; set; }
        DbSet<Model> Models { get; set; }
        DbSet<Series> Series { get; set; }
        DbSet<Transmission> Transmissions { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Venichle> Venichles { get; set; }
        DbSet<Auction> Auctions { get; set; }
        DbSet<Comment> Comments { get; set; }

    }
}
